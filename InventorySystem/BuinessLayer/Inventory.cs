using System.Collections.Generic;
using System.Linq;

namespace BuinessLayer
{
    public class Inventory : ISubject
    {
        private List<Product> products = new List<Product>();
        private List<IObserver> observers = new List<IObserver>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Notify(product, OperationTypes.AddProduct);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
            Notify(product, OperationTypes.RemoveProduct);
        }

        public void Attach(IObserver Observer)
        {
            observers.Add(Observer);
        }

        public void Deattach(IObserver Observer)
        {
            observers.Remove(Observer);
        }

        public void Notify(Product product,OperationTypes operationType)
        {
            foreach(IObserver observer in observers)
            {
                switch(operationType)
                {
                    case OperationTypes.AddProduct:
                        observer.ProductAdded(product);
                        break;
                    case OperationTypes.RemoveProduct:
                        observer.ProductRemoved(product);
                        break;
                }
            }
        }

        public IQueryable<Product> Products()
        {
            return products.AsQueryable();
        }
    }
}
