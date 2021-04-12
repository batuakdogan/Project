using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string productsText = "Ürünler";


            string addToCartButtonText = "Sepete ekle";
            string cartText = "Sepetiniz";

            var removeFromCartButtonText = "Sepetten çıkar";


            lbxProducts.Text = productsText;

            btnAddToCard.Text = addToCartButtonText;

            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;


            lblProducts.Text = "Ürünler";





            string[] products = new string[] { "Laptop", "Masaüstü PC", "Klavye" };




            // for (int i = 0; i < products.Length; i++)
            //{
            //   lbxProducts.Items.Add(products[i]);

            //}


            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }





        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {

            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;

            }
            else
            {
                MessageBox.Show("Ürün seçin!");
            }

        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem!=null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncelikle ürün seçmelisiniz");
            }

            


            if (lbxCart.Items.Count ==0)
            {
                btnRemoveFromCart.Enabled = false;
            }

        }
    }
}
