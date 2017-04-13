using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace ImageStorageLibrary
{
    // TODO: PEBKAC issue getting DocDB library integrated.
    public class DocumentDBHelper
    {
        static DocumentDBHelper()
        {
            InitializeDocumentDB();
        }

        //private static DocumentClient documentClient;

        private static string endpointURI;
        public static string EndpointURI
        {
            get
            {
                return endpointURI;
            }

            set
            {
                var changed = endpointURI != value;
                endpointURI = value;
                if (changed)
                {
                    InitializeDocumentDB();
                }
            }
        }

        private static string accessKey;
        public static string AccessKey
        {
            get
            {
                return accessKey;
            }
            set
            {
                var changed = accessKey != value;
                accessKey = value;
                if (changed)
                {
                    InitializeDocumentDB();
                }
            }
        }

        private static void InitializeDocumentDB()
        {
            //documentClient = new DocumentClient(new Uri(endpointURI), accessKey);
        }
    }
}
