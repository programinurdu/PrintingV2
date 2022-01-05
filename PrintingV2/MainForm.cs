using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrintingV2.Models;
using PrintingV2.Properties;
using System.Configuration;
using System.Data.OleDb;

namespace PrintingV2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<CartItem> shoppingCart = new List<CartItem>();
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderButton.Enabled = false;
            PrintOrderButton.Enabled = true;
            PrintPreviewButton.Enabled = true;
            CancelOrderButton.Enabled = true;

            ItemGroupBox.Enabled = true;

            ClientNameTextBox.Focus();
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderButton.Enabled = true;
            PrintOrderButton.Enabled = false;
            PrintPreviewButton.Enabled = false;
            CancelOrderButton.Enabled = false;

            ItemGroupBox.Enabled = false;

            ClientNameTextBox.Clear();
            ItemNameComboBox.SelectedIndex = -1;
            QuantityTextBox.Clear();
            UnitPriceTextBox.Clear();

            TotalAmountTextBox.Text = "0";
            SalesTaxTextBox.Text = "0";
            TotalToPayTextBox.Text = "0";

            CartDataGridView.DataSource = null;
            shoppingCart.Clear();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                CartItem item = new CartItem()
                {
                    ItemName = ItemNameComboBox.Text,
                    Quantity = Convert.ToInt16(QuantityTextBox.Text.Trim()),
                    UnitPrice = Convert.ToDecimal(UnitPriceTextBox.Text.Trim()),
                    TotalPrice = Convert.ToInt16(QuantityTextBox.Text.Trim()) * Convert.ToDecimal(UnitPriceTextBox.Text.Trim())
                };

                // Array, Collection, List, DataTable and DataSet
                shoppingCart.Add(item);

                CartDataGridView.DataSource = null;
                CartDataGridView.DataSource = shoppingCart;

                decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
                TotalAmountTextBox.Text = totalAmount.ToString();

                decimal totalSalesTax = (16 * totalAmount) / 100;
                SalesTaxTextBox.Text = totalSalesTax.ToString();

                decimal totalPay = totalAmount + totalSalesTax;
                TotalToPayTextBox.Text = totalPay.ToString();

                ItemNameComboBox.SelectedIndex = -1;
                QuantityTextBox.Clear();
                UnitPriceTextBox.Clear();
            }
        }

        private bool IsValidated()
        {
            if (ClientNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Client Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClientNameTextBox.Focus();
                return false;
            }

            if (ItemNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Item Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Focus();
                return false;
            }
            else
            {
                int tempQuantity;
                bool isNumeric = int.TryParse(QuantityTextBox.Text.Trim(), out tempQuantity);

                if (!isNumeric)
                {
                    MessageBox.Show("Quantity should be integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Clear();
                    QuantityTextBox.Focus();
                    return false;
                }
            }

            if (UnitPriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Unit Price is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UnitPriceTextBox.Focus();
                return false;
            }
            else
            {
                decimal n;
                bool isDecimal = decimal.TryParse(UnitPriceTextBox.Text.Trim(), out n);

                if (!isDecimal)
                {
                    MessageBox.Show("Unit Price should be decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UnitPriceTextBox.Clear();
                    UnitPriceTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void CartDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = CartDataGridView.HitTest(e.X, e.Y);
                CartDataGridView.Rows[hti.RowIndex].Selected = true;

                contextMenuStrip1.Show(CartDataGridView, e.X, e.Y);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartDataGridView.CurrentCell.RowIndex;

            shoppingCart.RemoveAt(index);

            CartDataGridView.DataSource = null;
            CartDataGridView.DataSource = shoppingCart;

            decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
            TotalAmountTextBox.Text = totalAmount.ToString();

            decimal totalSalesTax = (16 * totalAmount) / 100;
            SalesTaxTextBox.Text = totalSalesTax.ToString();

            decimal totalPay = totalAmount + totalSalesTax;
            TotalToPayTextBox.Text = totalPay.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Properties.Resources.logo2;

            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));

            e.Graphics.DrawString("Client Name: " + ClientNameTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("Item Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Total Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(660, 255));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            int yPos = 295;

            for (int i = numberOfItemsPrintedSoFar; i < shoppingCart.Count; i++)
            {
                numberOfItemsPerPage++;

                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= shoppingCart.Count)
                    {
                        e.Graphics.DrawString(shoppingCart[i].ItemName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                        e.Graphics.DrawString(shoppingCart[i].Quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                        e.Graphics.DrawString(shoppingCart[i].UnitPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                        e.Graphics.DrawString(shoppingCart[i].TotalPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));

                        yPos += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("Total Amount:      £" + TotalAmountTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 30));
            e.Graphics.DrawString("Sales Tax (16%): £" + SalesTaxTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 60));
            e.Graphics.DrawString("Total To Pay:       £" + TotalToPayTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 90));

            // reset the variables
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void PrintPreviewButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ItemNameComboBox.SelectedValueChanged -= ItemNameComboBox_SelectedValueChanged;

            ItemNameComboBox.DataSource = GetProductsName();
            ItemNameComboBox.DisplayMember = "ProductName";
            ItemNameComboBox.ValueMember = "ProductPrice";

            ItemNameComboBox.SelectedIndex = -1;

            ItemNameComboBox.SelectedValueChanged += ItemNameComboBox_SelectedValueChanged;
        }

        private DataTable GetProductsName()
        {
            DataTable dtProducts = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT ProductName, ProductPrice FROM Products WHERE IsActive = true", conn))
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtProducts.Load(reader);
                }
            }

            return dtProducts;
        }

        private void PrintOrderButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void ItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            decimal productPrice = Convert.ToDecimal(ItemNameComboBox.SelectedValue);

            UnitPriceTextBox.Text = productPrice.ToString();
        }
    }
}
