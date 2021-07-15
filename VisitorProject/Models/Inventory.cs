using VisitorProject.Visitable;
using VisitorProject.Visitors;

namespace VisitorProject.Models
{
    public class Inventory : BaseModel, IVisitableElement
    {
        public bool IsPastedOnInventory { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitInventory(this);
        }
    }
}
