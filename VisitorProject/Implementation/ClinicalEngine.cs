using System;
using VisitorProject.Interfaces;

namespace VisitorProject.Implementation
{
    public class ClinicalEngine : IClinicalEngine, IOperations
    {
        #region Clinical 
        public void FormatReports(Guid reportId, Guid enrollmentId)
        {
            Console.WriteLine("Formating report...");
        }

        public void PurgeData(Guid enrollmentId, Guid prescriptionId)
        {
            Console.WriteLine("Purgin Data...");
        }

        public void ResetDevice(Guid enrollmentId, Guid prescriptionId)
        {
            Console.WriteLine("Reseting Device...");
        }
        #endregion

        #region Common Operations
        public void ReturnDevice(Guid enrollmentId, Guid prescriptionId)
        {
            ResetDevice(enrollmentId, prescriptionId);
            PurgeData(enrollmentId, prescriptionId);

            Console.WriteLine("Deleting reports asociated");
        }
        #endregion
    }
}
