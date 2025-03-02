using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF;
using BookstoreManagementSystemLibrary.Database.EF.Enum;

namespace BookstoreManagementSystemLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnector> Connections { get; private set; } = [];
        public static string Salt = "WRlNzJmYmU3MDh";

        public static void InitilizeConnection(List<EFConnectionType> connectionTypes, Dictionary<EFConnectionType, string> connectionStringList, string salt)
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

        public static void Process(Action<IDataConnector, string> processor)
        {
            foreach (var item in Connections)
            {
                processor.Invoke(item, Salt);
            }
        }
    }
}
