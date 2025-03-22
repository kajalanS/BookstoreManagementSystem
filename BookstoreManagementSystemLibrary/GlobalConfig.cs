using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF;
using BookstoreManagementSystemLibrary.Database.EF.Connectors;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Models;
using DocumentFormat.OpenXml.InkML;

namespace BookstoreManagementSystemLibrary
{
  public static class GlobalConfig
  {
    public static List<IDataConnector> Connections { get; private set; } = [];
    public static string Salt = string.Empty;
    public static User? loggedInUser { get; private set; }

    /// <summary>
    /// Sets up connection instances based on the provided connection types and connection strings.
    /// </summary>
    /// <param name="connectionTypes">A list of connection types to set up.</param>
    /// <param name="connectionStringList">A dictionary containing connection strings for each connection type.</param>
    /// <param name="salt">A salt value used for additional configuration.</param>
    public static void SetupConnectionProviders(List<EFConnectionType> connectionTypes, Dictionary<EFConnectionType, string> connectionStringList, string salt)
    {
      if (connectionTypes is not null)
      {
        if (connectionStringList is not null)
        {
          foreach (var item in connectionTypes)
          {
            IDataConnector connector;
            if (item == EFConnectionType.Memory)
            {
              connector = new EFDataConnector(EFConnectionType.Memory, connectionStringList);
            }
            else
            {
              connector = new EFDataConnector(item, connectionStringList);
            }
            Connections.Add(connector);
          }
          if (string.IsNullOrWhiteSpace(salt))
          {
            throw new ArgumentException($"'{nameof(salt)}' cannot be null or whitespace.", nameof(salt));
          }

          Salt = salt;
        }
        else
        {
          throw new ArgumentNullException(nameof(connectionStringList));
        }
      }
      else
      {
        throw new ArgumentNullException(nameof(connectionTypes));
      }
    }

    public static void SetupConnectionProviders(EFConnectionType connectionTypes, Dictionary<EFConnectionType, string> connectionStringList, string salt)
    {
      SetupConnectionProviders([connectionTypes], connectionStringList, salt);
    }

    public static void Process(Action<IDataConnector, string> processor)
    {
      foreach (var item in Connections)
      {
        processor.Invoke(item, Salt);
      }
    }

    public static void SaveLoginUser(this User user)
    {
      /// remove password for safty
      user.PasswordHash = "";
      loggedInUser = user;
    }
  }
}
