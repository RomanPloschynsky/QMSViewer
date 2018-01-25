using QMSViewer.QMSAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMSViewer
{
    class QVManagementService : ServiceInfo {

        QMSClient client;
        ServiceInfo qms;


        public QVManagementService(QMSClient client) {
            this.client = client;
            qms = client.GetServices(ServiceTypes.QlikViewServer).FirstOrDefault();
            



        }








    }
}
