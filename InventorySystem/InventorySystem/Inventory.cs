using BuinessLayer;
using System;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Inventory : Form
    {

        BuinessLayer.Inventory inventory = new BuinessLayer.Inventory();
        public Inventory()
        {
            InitializeComponent();
        }



        private void btnOpenInventoryStatus_Click(object sender, System.EventArgs e)
        {
            InventoryStatus inventoryStatus = new InventoryStatus(inventory);
            inventoryStatus.Show();
        }

        private void btnOpenInventoryTracking_Click(object sender, System.EventArgs e)
        {
            InventoryTracking inventoryTracking = new InventoryTracking(inventory);
            inventoryTracking.Show();
        }

        private void Inventory_Load(object sender, System.EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            ClearValidationLabels();
            if (ValidateInputs())
            {
                var product = new Product();
                product.Name = txtProductName.Text;
                product.Price = float.Parse(txtPrice.Text);
                product.Qunatity = int.Parse(txtQuantity.Text);
                product.AddedDate = DateTime.Now;
                inventory.AddProduct(product);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtPrice.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
        }

        private void ClearValidationLabels()
        {
            lblNameValidation.Text = string.Empty ;
            lblPriceValidation.Text = string.Empty;
            lblQuantityValidation.Text= string.Empty;
        }

        private bool ValidateInputs()
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(txtProductName.Text)
                && !string.IsNullOrEmpty(txtQuantity.Text)
                && !string.IsNullOrEmpty(txtPrice.Text))
            {
                int quantity = 0;
                float price = 0;
                if (int.TryParse(txtQuantity.Text, out quantity))
                {

                    if (float.TryParse(txtPrice.Text, out price))
                    {
                        isValid = true;
                    }
                    else
                    {
                        lblPriceValidation.Text = "Price Field must be a float number.";
                    }
                }
                else
                {
                    lblQuantityValidation.Text = "Quantity Field must be an integer number.";
                }

            }
            else
            {
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    lblNameValidation.Text = "Name Field is Required.";
                }
                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    lblQuantityValidation.Text = "Quantity Field is Required.";
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    lblPriceValidation.Text = "Price Field is Required.";
                }
            }
            return isValid;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            ClearValidationLabels();
            if (ValidateInputs())
            {
                var product = new Product();
                product.Name = txtProductName.Text;
                product.Price = float.Parse(txtPrice.Text);
                product.Qunatity = int.Parse(txtQuantity.Text);
                product.AddedDate = DateTime.Now;
                inventory.RemoveProduct(product);
                ClearInputs();
            }
        }
    }
}
