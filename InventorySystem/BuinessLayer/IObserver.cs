namespace BuinessLayer
{
    public interface IObserver
    {
        void ProductAdded(Product product);

        void ProductRemoved(Product product);
    }
}
