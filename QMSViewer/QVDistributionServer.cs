using QMSViewer.QMSAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMSViewer
{
    class QVDistributionServer : ServiceInfo {

        QMSClient client;
        ServiceInfo qds;
        public List<DocumentNode> documentNodes;
        public List<TaskInfo> tasks;

        public QVDistributionServer(QMSClient client) {
            this.client = client;
            qds = client.GetServices(ServiceTypes.QlikViewDistributionService).FirstOrDefault();
            documentNodes = client.GetSourceDocuments(qds.ID).ToList();
            tasks = client.GetTasks(qds.ID).ToList();

            TaskStatusFilter taskStatusFilter = new TaskStatusFilter();
            List<QMSAPI.TaskStatus> clientTaskStatuses = client.GetTaskStatuses(taskStatusFilter, TaskStatusScope.All).ToList();
            foreach (QMSAPI.TaskStatus taskStatus in clientTaskStatuses) {
                Console.WriteLine(taskStatus.TaskID);
            }



        }





        


    }
}
