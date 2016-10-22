using BuinessLayer;
using System;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class InventoryTracking : Form, IObserver
    {
        
        public InventoryTracking(BuinessLayer.Inventory inventory)
        {
            InitializeComponent();
            inventory.Attach(this);
        }


        public void ProductAdded(Product product)
        {
            AddProduct(product);
        }

        public void ProductRemoved(Product product)
        {
            RemoveProduct(product);
        }

        private void AddProduct(Product product)
        {

            product.Description = string.Format("new product {0} is Added.", product.Name);
            gridProducts.Rows.Add(new string[] {product.Name,product.Qunatity.ToString()
            ,product.Price.ToString(),product.AddedDate.ToString(),product.Description });

        }


        private void RemoveProduct(Product product)
        {
            product.Description = string.Format("new product {0} is Removed.", product.Name);
            gridProducts.Rows.Add(new string[] {product.Name,product.Qunatity.ToString()
            ,product.Price.ToString(),product.AddedDate.ToString(),product.Description });
        }

        private void InventoryTracking_Load(object sender, EventArgs e)
        {
        }



        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
