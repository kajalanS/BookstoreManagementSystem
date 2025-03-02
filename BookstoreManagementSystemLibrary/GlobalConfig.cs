using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF;
using BookstoreManagementSystemLibrary.Database.EF.Enum;

namespace BookstoreManagementSystemLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnector> Connections { get; private set; } = [];

        public static void InitilizeConnection(List<EFConnectionType> connectionTypes)
        {
            foreach (var item in connectionTypes)
            {
                IDataConnector connector;

                if (item == EFConnectionType.None)
                {
                    connector = new EFDataConnector(EFConnectionType.Memory);
                }
                else
                {
                    connector = new EFDataConnector(item);
                }

                Connections.Add(connector);
            }
        }

        public static void Process(Action<IDataConnector> processor)
        {
            foreach (var item in Connections)
            {
                processor.Invoke(item);
            }
        }
    }
}
