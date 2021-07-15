using Newtonsoft.Json;
using System;
using VisitorProject.Interfaces;

namespace VisitorProject.QueueHandlers
{
    public class ReturnDeviceHandler
    {
        private string QueueName => "Common.ReturnDeviceHandler";

        private readonly IOperations _operations;
        public ReturnDeviceHandler(IOperations operations)
        {
            _operations = operations;
        }

        public void Handle(string body)
        {
            var parameters = JsonConvert.DeserializeObject<Parameters>(body);
            _operations.ReturnDevice(parameters.EnrollmentId, parameters.PrescriptionId);
        }

        public class Parameters {
            public Guid EnrollmentId { get; set; }
            public Guid PrescriptionId { get; set; }
        }
    }
}
