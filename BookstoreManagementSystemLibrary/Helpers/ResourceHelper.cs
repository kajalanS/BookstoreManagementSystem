using System.Reflection;

namespace BookstoreManagementSystemLibrary.Helpers
{
  public static class ResourceHelper
  {
    /// <summary>
    /// Reads an embedded resource and returns its content as a string.
    /// </summary>
    /// <param name="resourceName">The full resource name (e.g., "MyProject.Templates.EmailTemplate.html").</param>
    /// <returns>The content of the embedded resource as a string.</returns>
    public static string ReadEmbeddedResource(this string resourceName)
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      using Stream? stream = assembly.GetManifestResourceStream(resourceName) ?? throw new Exception($"Resource '{resourceName}' not found.");
      using StreamReader reader = new(stream);
      return reader.ReadToEnd();
    }
  }
}
