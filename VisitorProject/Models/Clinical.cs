using VisitorProject.Visitable;
using VisitorProject.Visitors;

namespace VisitorProject.Models
{
    public class Clinical : BaseModel, IVisitableElement
    {
        public bool IsPastedClinicalReport { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitClinical(this);
        }
    }
}
