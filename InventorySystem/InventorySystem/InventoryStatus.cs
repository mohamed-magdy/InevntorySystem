using BuinessLayer;
using System;
using System.Linq;
using System.Windows.Forms;
namespace InventorySystem
{
    public partial class InventoryStatus : Form, IObserver
    {
        public InventoryStatus(BuinessLayer.Inventory inventory)
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
            if (gridViewProducts.Rows.Count > 0)
            {
                var row = SearchGridProduct(product.Name);
                if (row != null)
                {
                    int oldQuantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    int newQuantity = oldQuantity + product.Qunatity;
                    row.Cells["Quantity"].Value = newQuantity.ToString();
                    row.Cells["Date"].Value = DateTime.Now.ToString();
                    row.Cells["Description"].Value = string.Format("Quantity Changed from {0} to {1}", oldQuantity, newQuantity);
                }
                else
                {
                    product.Description = string.Format("Quantity Changed from 0 to {0}.", product.Qunatity);
                    gridViewProducts.Rows.Add(new string[] {product.Name,product.Qunatity.ToString()
                     ,product.Price.ToString(),product.AddedDate.ToString(),product.Description });
                }
            }
            else
            {
                product.Description = string.Format("Quantity Changed from 0 to {0}.", product.Qunatity);
                gridViewProducts.Rows.Add(new string[] {product.Name,product.Qunatity.ToString()
                     ,product.Price.ToString(),product.AddedDate.ToString(),product.Description });
            }
        }

        private void RemoveProduct(Product product)
        {
            if (gridViewProducts.Rows.Count > 0)
            {
                var row = SearchGridProduct(product.Name);
                if (row != null)
                {
                    int oldQuantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    int newQuantity = 0;
                    if (product.Qunatity <= oldQuantity)
                        newQuantity = oldQuantity - product.Qunatity;
                    row.Cells["Quantity"].Value = newQuantity.ToString();
                    row.Cells["Date"].Value = DateTime.Now.ToString();
                    row.Cells["Description"].Value = string.Format("Quantity Changed from {0} to {1}", oldQuantity, newQuantity);
                }
                else
                {
                    product.Description = string.Format("Quantity Changed from 0 to {0}.", product.Qunatity);
                    gridViewProducts.Rows.Add(new string[] {product.Name,product.Qunatity.ToString()
                     ,product.Price.ToString(),product.AddedDate.ToString(),product.Description });
                }
            }
            else
            {
                product.Description = string.Format("Quantity Changed from 0 to {0}.", product.Qunatity);
                gridViewProducts.Rows.Add(new string[] {product.Name,product.Qunatity.ToString()
                     ,product.Price.ToString(),product.AddedDate.ToString(),product.Description });
            }
        }

        private void InventoryStatus_Load(object sender, EventArgs e)
        {

        }

        private DataGridViewRow SearchGridProduct(string productName)
        {
            var row = gridViewProducts.Rows
           .Cast<DataGridViewRow>()
           .Where(r => r.Cells["ProductName"].Value.ToString().Equals(productName))
           .FirstOrDefault();
            return row;
        }
    }
}
