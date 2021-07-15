using Newtonsoft.Json;
using System;
using VisitorProject.Models;
using VisitorProject.Visitors;

namespace VisitorProject.QueueHandlers
{
    public class ReportPastDueHandler
    {
        private Clinical clinical;
        private Inventory inventory;
        private string QueueName => "Common.ReportsPastDue";

        public ReportPastDueHandler()
        {
            clinical = new Clinical();
            inventory = new Inventory();
        }

        public void Handle(string body)
        {            
            var parameters = JsonConvert.DeserializeObject<Parameters>(body);

            AssignClinicalData(parameters);
            AssignInventoryData(parameters);

            ReportPastDueVisitor visitor = new ReportPastDueVisitor();

            clinical.Accept(visitor);
            inventory.Accept(visitor);

            if (visitor.IsTotallyPast())
                Console.WriteLine("The report was completed and stored on historical data");
            else
                Console.WriteLine("The report wasn't fully stored on historical registers");
        }

        public class Parameters
        {
            public Guid EnrollmentId { get; set; }
            public Guid PrescriptionId { get; set; }
        }

        private void AssignClinicalData(Parameters data)
        {
            clinical.PrescriptionId = data.PrescriptionId;
            clinical.EnrollmentId = data.EnrollmentId;
        }

        private void AssignInventoryData(Parameters data)
        {
            inventory.PrescriptionId = data.PrescriptionId;
            inventory.EnrollmentId = data.EnrollmentId;
        }
    }
}
