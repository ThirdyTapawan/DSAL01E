using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1._2
{
    public partial class Activity1 : Form
    {
        //declaration of global variables
        private double amount_paid, price, cash_given, change;
        private int quantity;
        public Activity1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "121.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox

            qtyTxtbox.Clear(); // Clear quantity textbox
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Friend Meal A";
            priceTxtbox.Text = "391.90";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Double Value Meal A";
            priceTxtbox.Text = "191.00";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "799.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "91.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Lunch Value Meal 1";
            priceTxtbox.Text = "199.10";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "CHicken Meal A";
            priceTxtbox.Text = "177.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "999.90";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Pasta Meal 101";
            priceTxtbox.Text = "98.00";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "95.00";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Lunch Value Meal B";
            priceTxtbox.Text = "191.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "133.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void Activity1_Load(object sender, EventArgs e)
        {
            changeTxtbox.Enabled = false;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from the textboxes
                double amount_paid = Convert.ToDouble(amount_PaidTxtbox.Text);
                double cash_given = Convert.ToDouble(cash_givenTxtbox.Text);

                // Calculate the change
                double change = cash_given - amount_paid;

                // Display the change, formatted to two decimal places
                changeTxtbox.Text = change.ToString("n2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for 'Amount Paid' and 'Cash Given'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
            qtyTxtbox.Clear();
            amount_PaidTxtbox.Clear();
            cash_givenTxtbox.Clear();
            changeTxtbox.Clear();
            itemnameTxtbox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if both price and quantity textboxes have valid input
                if (!string.IsNullOrEmpty(priceTxtbox.Text) && !string.IsNullOrEmpty(qtyTxtbox.Text))
                {
                    // Convert the text to a number
                    double price = Convert.ToDouble(priceTxtbox.Text);
                    int quantity = Convert.ToInt32(qtyTxtbox.Text);

                    // Calculate the amount paid
                    double amount_paid = price * quantity;

                    // Display the result, formatted to two decimal places
                    amount_PaidTxtbox.Text = amount_paid.ToString("n2");
                }
                else
                {
                    // Clear the Amount Paid textbox if either input is empty
                    amount_PaidTxtbox.Clear();
                }
            }
            catch (FormatException)
            {
                // Handle cases where the input is not a valid number
                amount_PaidTxtbox.Clear();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Pancake Value Meal A";
            priceTxtbox.Text = "97.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Chicken Meal 2";
            priceTxtbox.Text = "191.30";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Palabok Meal";
            priceTxtbox.Text = "120.50";

            qtyTxtbox.Focus(); // Set focus to quantity textbox
        }

    }
}
