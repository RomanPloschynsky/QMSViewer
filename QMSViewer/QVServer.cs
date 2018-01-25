using QMSViewer.QMSAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMSViewer
{
    class QVServer : ServiceInfo {

        QMSClient client;
        ServiceInfo qvs;
        public CALConfiguration calls;


        public QVServer(QMSClient client) {
            this.client = client;
            qvs = client.GetServices(ServiceTypes.QlikViewServer).FirstOrDefault();
            calls = client.GetCALConfiguration(qvs.ID, CALConfigurationScope.All);


        }








    }
}
