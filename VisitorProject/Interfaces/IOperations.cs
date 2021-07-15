using System;

namespace VisitorProject.Interfaces
{
    public interface IOperations
    {
        void ReturnDevice(Guid enrollmentId, Guid prescriptionId);
    }
}
