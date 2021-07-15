using VisitorProject.Visitors;

namespace VisitorProject.Visitable
{
    public interface IVisitableElement
    {
        void Accept(IVisitor visitor);
    }
}
