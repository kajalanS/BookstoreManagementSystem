using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemUI.Helpers
{
    public static class ImageHelper
    {
        public static byte[] ImageToByteArray(this Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        public static Image? ByteArrayToImage(this byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        public static string ImageToString(this Image image)
        {
            using MemoryStream m = new();
            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();

            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;

        }
        public static Image? StringtoImage(this string image)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(image);
            using MemoryStream ms = new(imageBytes);
            return new Bitmap(ms);
        }

        /// <summary>
        /// Retrieves an image from the application's resources.
        /// </summary>
        /// <param name="resourceName">The name of the resource image.</param>
        /// <returns>The loaded Image or null if not found.</returns>
        public static Image? GetImageFromResources(this string resourceName)
        {
            if (string.IsNullOrEmpty(resourceName))
                throw new ArgumentNullException(nameof(resourceName), "Resource name cannot be null or empty.");

            var assembly = Assembly.GetExecutingAssembly();
            var resourceManager = new ResourceManager(assembly.GetName().Name + ".Properties.Resources", assembly);
            try
            {
                object? obj = resourceManager.GetObject(resourceName);
                return obj as Image;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading resource '{resourceName}': {ex.Message}");
                return null;
            }
        }
    }
}
