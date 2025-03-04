using System;
using System.Collections.Generic;

namespace BookstoreManagementSystemLibrary.Helpers
{
    public static class EmailTemplateHandler
    {
        private static readonly string TemplateRootResourcePath = "BookstoreManagementSystemLibrary";

        private static string FindTemplateByType(this EmailTemplateType templateType)
        {
            var outHtml = "";
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
                default:
                    break;
            }

            outHtml = templateCurrentPath.ReadEmbeddedResource();
            return outHtml;
        }

        /// <summary>
        /// Processes the given template HTML by replacing placeholders with provided values.
        /// </summary>
        /// <param name="templateType">The email template type.</param>
        /// <param name="values">A dictionary of placeholder keys and their values.</param>
        /// <param name="templateHtml">The HTML content with placeholders (e.g., {{username}}).</param>
        /// <returns>The processed HTML with placeholders replaced.</returns>
        public static string ProcessTemplate(this EmailTemplateType templateType, Dictionary<EmailTemplatePlaceHolder, string> values)
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
                // Format the placeholder key in the template format, e.g., {{username}}
                string token = $"{{{{{placeholder.FindPlaceHolderString()}}}}}";
                // Replace the token with the corresponding value if provided; otherwise, use an empty string.
                templateHtml = templateHtml.Replace(token, values.TryGetValue(placeholder, out string? value) ? value : string.Empty);
            }

            return templateHtml;
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
        PreOrderAvailableNow = 14
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
    }
}
