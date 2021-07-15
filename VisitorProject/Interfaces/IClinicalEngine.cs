using System;

namespace VisitorProject.Interfaces
{
    public interface IClinicalEngine
    {
        void ResetDevice(Guid enrollmentId, Guid prescriptionId);
        void PurgeData(Guid enrollmentId, Guid prescriptionId);
        void FormatReports(Guid reportId, Guid enrollmentId);
    }
}
