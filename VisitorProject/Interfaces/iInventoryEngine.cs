using System;

namespace VisitorProject.Interfaces
{
    public interface iInventoryEngine
    {
        void SendToSalesforce(Guid enrollmentId, Guid inventoryId);
        void AssignToStore(Guid enrollmentId, Guid inventoryId);
        void LiberatePhysician(Guid enrollmentId);
    }
}
