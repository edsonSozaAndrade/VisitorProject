using System;
using VisitorProject.Interfaces;

namespace VisitorProject.Implementation
{
    public class InventoryEngine : iInventoryEngine, IOperations
    {
        #region Inventory
        public void AssignToStore(Guid enrollmentId, Guid inventoryId)
        {
            Console.WriteLine("Assigning to a new store...");
        }

        public void LiberatePhysician(Guid enrollmentId)
        {
            Console.WriteLine("Liberating physician of device...");
        }

        public void SendToSalesforce(Guid enrollmentId, Guid inventoryId)
        {
            Console.WriteLine("Notifying salesforce...");
        }
        #endregion

        #region Common Operations
        public void ReturnDevice(Guid enrollmentId, Guid prescriptionId)
        {
            SendToSalesforce(enrollmentId, prescriptionId);
            LiberatePhysician(enrollmentId);

            Console.WriteLine("Recoding on historical inventory");
        }
        #endregion
    }
}
