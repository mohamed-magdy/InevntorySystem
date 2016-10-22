using BuinessLayer;

namespace BuinessLayerTests
{
    public interface IObserverTest
    {
        bool ProductAdded(Product product);

        bool ProductRemoved(Product product);
    }
}
