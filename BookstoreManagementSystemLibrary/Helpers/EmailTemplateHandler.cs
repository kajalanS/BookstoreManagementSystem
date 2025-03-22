using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookstoreManagementSystemLibrary.Helpers
{

    public static class EmailTemplateHandler
    {
        private static readonly string TemplateRootResourcePath = "BookstoreManagementSystemLibrary";

        private static string FindTemplateByType(this EmailTemplateType templateType)
        {
            var templateCurrentPath = TemplateRootResourcePath;
            switch (templateType)
            {
                case EmailTemplateType.OrderComplete:
                    templateCurrentPath = $"{templateCurrentPath}.Templates.order_complete_template.index.html";
                    break;
                case EmailTemplateType.PasswordReset:
                    templateCurrentPath = $"{templateCurrentPath}.Templates.password_reset_template.index.html";
                    break;
                case EmailTemplateType.PreOrder:
                    templateCurrentPath = $"{templateCurrentPath}.Templates.pre_order_available_now_template.index.html";
                    break;
                case EmailTemplateType.PreOrderAvailableNow:
                    templateCurrentPath = $"{templateCurrentPath}.Templates.pre_order_template.index.html";
                    break;
                case EmailTemplateType.OrderDetaile:
                    templateCurrentPath = $"{templateCurrentPath}.Templates.order_details_template.index.html";
                    break;
                case EmailTemplateType.Invoice:
                    templateCurrentPath = $"{templateCurrentPath}.Templates.invoice_template.index.html";
                    break;
                default:
                    break;
            }
            var outHtml = templateCurrentPath.ReadEmbeddedResource();
            return outHtml;
        }

        /// <summary>
        /// Processes the given template HTML by replacing placeholders with provided values.
        /// </summary>
        /// <param name="templateType">The email template type.</param>
        /// <param name="values">A dictionary of placeholder keys and their values.</param>
        /// <param name="templateHtml">The HTML content with placeholders (e.g., {{username}}).</param>
        /// <returns>The processed HTML with placeholders replaced.</returns>
        public static string ProcessTemplate(this EmailTemplateType templateType, Dictionary<EmailTemplatePlaceHolder, object> values)
        {
            // Get the list of expected placeholder keys for the chosen template type.
            if (!Placeholders.TryGetValue(templateType, out var placeholders))
            {
                throw new ArgumentException("Unknown template type", nameof(templateType));
            }

            var templateHtml = templateType.FindTemplateByType();

            // Loop through each placeholder and replace it in the template HTML.
            foreach (var placeholder in placeholders)
            {
                if (!values.TryGetValue(placeholder, out var value)) continue;
                if (placeholder == EmailTemplatePlaceHolder.OrderObject)
                {
                    if (templateType == EmailTemplateType.Invoice)
                    {
                        templateHtml = templateHtml.ReplaceOrderObject(templateType, value as Order);
                    }
                    else
                    {
                        templateHtml = templateHtml.ReplaceOrderObject(value as Order);
                    }
                }
                else
                {
                    // Replace the token with the corresponding orderData if provided; otherwise, use an empty string.
                    templateHtml = templateHtml.PlaceHolderReplace(placeholder.FindPlaceHolderString(), (string)value);
                }
            }

            return templateHtml;
        }

        public static string PlaceHolderReplace(this string template, string placeholder, string value)
        {
            // Format the placeholder key in the template format, e.g., {{username}}
            string token = $"{{{{{placeholder}}}}}";
            return template.Replace(token, value);
        }

        public static string ReplaceOrderObject(this string template, EmailTemplateType templateType, Order? orderData)
        {
            StringBuilder outString = new();

            if (orderData != null && orderData.OrderDetails != null)
            {
                foreach (var item in orderData.OrderDetails)
                {
                    outString.Append("<tr>");
                    outString.Append($"<td>{item.Book!.Title}</td>");
                    outString.Append($"<td>{item.Quantity}</td>");
                    outString.Append($"<td>{Math.Round(item.UnitPrice, 2)} LKR</td>");
                    outString.Append($"<td>{Math.Round(item.CalculatePrice(), 2)} LKR</td>");
                    outString.Append("</tr>");
                }
            }

            var val = outString.ToString();
            return template.PlaceHolderReplace("order_details", val);
        }

        public static string ReplaceOrderObject(this string template, Order? orderData)
        {
            StringBuilder outString = new();
            string templateDate = EmailTemplateType.OrderDetaile.FindTemplateByType();


            if (orderData != null && orderData.OrderDetails != null)
            {
                var tempDate = "";
                foreach (var item in orderData.OrderDetails)
                {
                    tempDate = templateDate;
                    tempDate = tempDate.PlaceHolderReplace("book_name", item.Book!.Title);
                    tempDate = tempDate.PlaceHolderReplace("quantity", item.Quantity.ToString());
                    tempDate = tempDate.PlaceHolderReplace("amount", Math.Round(item.CalculatePrice(), 2).ToString());
                    outString.Append(tempDate);
                }
            }

            var val = outString.ToString();
            return template.PlaceHolderReplace("order_details", val);
        }

        private static string FindPlaceHolderString(this EmailTemplatePlaceHolder placeHolder)
        {
            var outData = "";
            switch (placeHolder)
            {
                case EmailTemplatePlaceHolder.Status:
                    outData = "status";
                    break;
                case EmailTemplatePlaceHolder.Username:
                    outData = "username";
                    break;
                case EmailTemplatePlaceHolder.OrderId:
                    outData = "order_id";
                    break;
                case EmailTemplatePlaceHolder.SubTotal:
                    outData = "sub_total";
                    break;
                case EmailTemplatePlaceHolder.Discount:
                    outData = "discount";
                    break;
                case EmailTemplatePlaceHolder.Total:
                    outData = "total";
                    break;
                case EmailTemplatePlaceHolder.OrderDate:
                    outData = "order_date";
                    break;
                case EmailTemplatePlaceHolder.Password:
                    outData = "password";
                    break;
                default:
                    break;
            }

            return outData;
        }


        private static readonly Dictionary<EmailTemplateType, List<EmailTemplatePlaceHolder>> Placeholders = new()
        {
          {
            EmailTemplateType.OrderComplete,
            new List<EmailTemplatePlaceHolder> {
                EmailTemplatePlaceHolder.Status,
                EmailTemplatePlaceHolder.Username,
                EmailTemplatePlaceHolder.OrderId,
                EmailTemplatePlaceHolder.SubTotal,
                EmailTemplatePlaceHolder.Discount,
                EmailTemplatePlaceHolder.OrderObject,
                EmailTemplatePlaceHolder.Total,
            }
          },
          {
            EmailTemplateType.Invoice,
            new List<EmailTemplatePlaceHolder> {
                //EmailTemplatePlaceHolder.Status,
                //EmailTemplatePlaceHolder.Username,
                EmailTemplatePlaceHolder.OrderId,
                EmailTemplatePlaceHolder.SubTotal,
                EmailTemplatePlaceHolder.Discount,
                EmailTemplatePlaceHolder.OrderObject,
                EmailTemplatePlaceHolder.OrderDate,
                EmailTemplatePlaceHolder.Total,
            }
          },
          {
            EmailTemplateType.PasswordReset,
            new List<EmailTemplatePlaceHolder> {
                EmailTemplatePlaceHolder.Username,
                EmailTemplatePlaceHolder.Password,
            }
          },
          {
            EmailTemplateType.PreOrder,
            new List<EmailTemplatePlaceHolder> {
                EmailTemplatePlaceHolder.Status,
                EmailTemplatePlaceHolder.Username,
                EmailTemplatePlaceHolder.OrderId,
                EmailTemplatePlaceHolder.SubTotal,
                EmailTemplatePlaceHolder.Discount,
                EmailTemplatePlaceHolder.Total,
                EmailTemplatePlaceHolder.OrderObject,
                EmailTemplatePlaceHolder.OrderDate,
            }
          },
          {
            EmailTemplateType.PreOrderAvailableNow,
            new List<EmailTemplatePlaceHolder> {
                EmailTemplatePlaceHolder.Status,
                EmailTemplatePlaceHolder.Username,
                EmailTemplatePlaceHolder.OrderId,
                EmailTemplatePlaceHolder.SubTotal,
                EmailTemplatePlaceHolder.Discount,
                EmailTemplatePlaceHolder.Total,
            }
          }
        };
    }

    public enum EmailTemplateType
    {
        OrderComplete = 11,
        PasswordReset = 12,
        PreOrder = 13,
        PreOrderAvailableNow = 14,
        OrderDetaile = 15,
        Invoice = 16,
    }

    public enum EmailTemplatePlaceHolder
    {
        Status = 21,
        Username = 22,
        OrderId = 23,
        SubTotal = 24,
        Discount = 25,
        Total = 26,
        OrderDate = 27,
        Password = 28,
        OrderObject = 29,
    }
}
