using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QMSViewer.QMSAPI;
using QMSViewer.ServiceSupport;
//using System.ServiceModel.Security;

namespace QMSViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            //Connection connection = new Connection("http://ushdc0154:4799/QMS/Service", "x","x","x");
            //Connection connection = new Connection("http://usndc0153:4799/QMS/Service", "x", "x", "x");
            Connection connection = new Connection("http://10.6.3.101:4799/QMS/Service", "x", "x", "x");

            QMSClient client = connection.getClient();


            QVDistributionServer server = new QVDistributionServer(client);
            //List<DocumentNode> sourceDocuments = qds.documentNodes;
            //foreach (DocumentNode document in sourceDocuments) {
            //    Console.WriteLine( $"RelativePath: {document.RelativePath}; Name: {document.Name}; TaskCount: {document.TaskCount};" );
            //}
            List<TaskInfo> tasks = server.tasks;
            foreach (TaskInfo task in tasks) {
                Console.WriteLine($"ID: {task.ID}; Name: {task.Name};");
            }


            //Guid taskId = new Guid("201c22ad-ea23-45dc-bbf8-53b2a8d75405");
            //QMSAPI.TaskStatus taskStatus = client.GetTaskStatus(taskId, TaskStatusScope.Extended);
            //Console.WriteLine(taskStatus.Extended.TaskSummary);
            //Console.WriteLine(taskStatus.Extended.FinishedTime);

            //QVServer server = new QVServer(client);
            //List<AssignedNamedCAL> currentCALs = server.calls.NamedCALs.AssignedCALs.ToList();
            //foreach (AssignedNamedCAL call in currentCALs) {
            //    Console.WriteLine($"UserName: {call.UserName}; LastUsed: {call.LastUsed};");
            //}

            //QVManagementService qms = new QVManagementService(client);








        }
    }
}
