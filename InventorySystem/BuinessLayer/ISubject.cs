namespace BuinessLayer
{
    public interface ISubject
    {
        void Attach(IObserver Observer);

        void Deattach(IObserver Observer);

        void Notify(Product product, OperationTypes operationType);
    }
}
