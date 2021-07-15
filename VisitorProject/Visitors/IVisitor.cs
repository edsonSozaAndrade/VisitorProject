using VisitorProject.Models;

namespace VisitorProject.Visitors
{
    public interface IVisitor
    {
        void VisitClinical(Clinical clinical);
        void VisitInventory(Inventory inventory);
    }
}
