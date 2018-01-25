using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QMSViewer.QMSAPI;
using QMSViewer.ServiceSupport;
using System.ServiceModel.Security;

namespace QMSViewer
{
    public class Connection{
        private QMSClient client;
        public Connection(string url, string domain, string username, string password) {
            this.client = new QMSClient("BasicHttpBinding_IQMS", url);
            WindowsClientCredential creds = client.ClientCredentials.Windows;
            creds.ClientCredential.Domain = domain;
            creds.ClientCredential.UserName = username;
            creds.ClientCredential.Password = password;
            ServiceKeyClientMessageInspector.ServiceKey = client.GetTimeLimitedServiceKey();

        }

        public QMSClient getClient() {
            return client;
        }
    }

}





