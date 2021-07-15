using System;
using VisitorProject.QueueHandlers;

namespace VisitorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string payload = @"{""enrollmentId"" : ""16ba9d6d-dffc-4971-81e4-5aac77861b73"", ""prescriptionId"": ""93934703-d1f1-4beb-be60-e23aa1533982""}";
            var ReportPastDueHandler = new ReportPastDueHandler();
            ReportPastDueHandler.Handle(payload);
        }
    }
}
