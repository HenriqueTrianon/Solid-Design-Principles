namespace OCP.RightWay.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
