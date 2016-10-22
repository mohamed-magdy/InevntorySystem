using BuinessLayer;

namespace BuinessLayerTests
{
    public class ObserverTest : IObserverTest
    {
        public bool ProductAdded(Product product)
        {
            return true;
        }

        public bool ProductRemoved(Product product)
        {
            return true;
        }
    }
}
