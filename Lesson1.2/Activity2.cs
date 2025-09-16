using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1._2
{
    public partial class Activity2 : Form
    {
        int qty_total = 0;
        double discount_totalgiven = 0;
        double discounted_total = 0;
        double discount_amt;

        public Activity2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Combo Meal A";
            pricetxtbox.Text = "95.30";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Breakfast Meal 1";
            pricetxtbox.Text = "99.30";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Breakfast Meal 2";
            pricetxtbox.Text = "101.30";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken Meal A";
            pricetxtbox.Text = "120.30";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Combo Meal B";
            pricetxtbox.Text = "142.30";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Group Meal A";
            pricetxtbox.Text = "345.30";

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Group Meal B";
            pricetxtbox.Text = "499.30";

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken Spag Meal A";
            pricetxtbox.Text = "160.30";

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Twin Fries";
            pricetxtbox.Text = "182.30";

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Family Meal A";
            pricetxtbox.Text = "520.30";

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Spag Meal 1";
            pricetxtbox.Text = "123.30";

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Jolly Shake";
            pricetxtbox.Text = "65.30";

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "KFC Burger Combo Meal 1";
            pricetxtbox.Text = "180.30";

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken Group Meal";
            pricetxtbox.Text = "143.30";

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "KFC Family Meal A";
            pricetxtbox.Text = "799.30";

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "KFC Chicken Strips Meal";
            pricetxtbox.Text = "135.30";

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "KFC ChowFun Meal";
            pricetxtbox.Text = "120.30";

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Burger And Chaicken Meal C";
            pricetxtbox.Text = "185.30";

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "KFC Combo Meal A";
            pricetxtbox.Text = "168.30";

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

            itemnametxtbox.Text = "KFC Family Meal A";
            pricetxtbox.Text = "699.30";

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            // Disable textboxes for item details and totals.
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totalgiventxtbox.Enabled = false;

            //Load Images in the Textboxes
            pictureBox16.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\KFC chicken strips meal.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\KFC ChowFun meal.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\KFC Burger and Chicken meal.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\KFC Combo Meal A.png");
            pictureBox20.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\KFC Family Meal.png");

            //Inserting Names in the Textboxes
            label1.Text = "Combo Meal A";
            label2.Text = "Breakfast Meal 1";
            label3.Text = "Breakfast Meal 2";
            label4.Text = "Chicken Meal A";
            label5.Text = "Combo Meal B";
            label6.Text = "Group Meal A";
            label7.Text = "Group Meal B";
            label8.Text = "Chicken Spag Meal A";
            label9.Text = "Twin Fries";
            label10.Text = "Family Meal A";

        }

        private void SeniorCitizen_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price;
            // Validate quantity and price input before calculation
            if (!int.TryParse(quantitytxtbox.Text, out qty) || !double.TryParse(pricetxtbox.Text, out price))
            {
                MessageBox.Show("Please enter valid quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Calculate discount and discounted amount for senior citizen
            discount_amt = (qty * price) * 0.20;
            double discounted_amt = (qty * price) - discount_amt;
            // Display results in textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            // Uncheck other discount options
            WithDiscountCard.Checked = false;
            EmployeeDiscount.Checked = false;
            NoDiscount.Checked = false;

        }

        private void WithDiscountCard_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price;
            // Validate quantity and price input before calculation
            if (!int.TryParse(quantitytxtbox.Text, out qty) || !double.TryParse(pricetxtbox.Text, out price))
            {
                MessageBox.Show("Please enter valid quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Calculate discount and discounted amount for discount card
            discount_amt = (qty * price) * 0.10;
            double discounted_amt = (qty * price) - discount_amt;
            // Display results in textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            // Uncheck other discount options
            SeniorCitizen.Checked = false;
            EmployeeDiscount.Checked = false;
            NoDiscount.Checked = false;

        }

        private void EmployeeDiscount_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price;
            // Validate quantity and price input before calculation
            if (!int.TryParse(quantitytxtbox.Text, out qty) || !double.TryParse(pricetxtbox.Text, out price))
            {
                MessageBox.Show("Please enter valid quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Calculate discount and discounted amount for employee discount
            discount_amt = (qty * price) * 0.15;
            double discounted_amt = (qty * price) - discount_amt;
            // Display results in textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            // Uncheck other discount options
            SeniorCitizen.Checked = false;
            WithDiscountCard.Checked = false;
            NoDiscount.Checked = false;

        }

        private void NoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price;
            // Validate quantity and price input before calculation
            if (!int.TryParse(quantitytxtbox.Text, out qty) || !double.TryParse(pricetxtbox.Text, out price))
            {
                MessageBox.Show("Please enter valid quantity and price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // No discount applied
            discount_amt = 0;
            double discounted_amt = qty * price;
            // Display results in textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            // Uncheck other discount options
            SeniorCitizen.Checked = false;
            WithDiscountCard.Checked = false;
            EmployeeDiscount.Checked = false;

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int qty;
            double discounted_amt, cash_rendered, change;

            // Check for empty textboxes to prevent errors.
            if (string.IsNullOrEmpty(quantitytxtbox.Text) ||
                string.IsNullOrEmpty(pricetxtbox.Text) ||
                string.IsNullOrEmpty(cashrenderedtxtbox.Text) ||
                string.IsNullOrEmpty(discountedtxtbox.Text))
            {
                MessageBox.Show("Please enter a quantity, select an item, enter the cash tendered, and select a discount option.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate quantity input
            if (!int.TryParse(quantitytxtbox.Text, out qty))
            {
                MessageBox.Show("Invalid quantity entered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate discounted amount input
            if (!double.TryParse(discountedtxtbox.Text, out discounted_amt))
            {
                MessageBox.Show("Invalid discounted amount. Please select a discount option.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate cash rendered input
            if (!double.TryParse(cashrenderedtxtbox.Text, out cash_rendered))
            {
                MessageBox.Show("Invalid cash rendered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Accumulate totals for reporting
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            // Display totals and change
            qty_totaltxtbox.Text = qty_total.ToString();
            discount_totalgiventxtbox.Text = discount_totalgiven.ToString("n");
            discounted_totaltxtbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            // Check if calculation has been performed
            if (string.IsNullOrEmpty(qty_totaltxtbox.Text) || string.IsNullOrEmpty(discounted_totaltxtbox.Text))
            {
                MessageBox.Show("Please click 'Calculate' first to process the transaction.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a new instance of the print form
            Activity2_PrintFrm printForm = new Activity2_PrintFrm();

            // Pass the data to the new form's public properties
            printForm.ItemName = itemnametxtbox.Text;
            printForm.Quantity = quantitytxtbox.Text;
            printForm.Price = pricetxtbox.Text;
            printForm.DiscountAmount = discounttxtbox.Text;
            printForm.DiscountedAmount = discountedtxtbox.Text;
            printForm.TotalQuantity = qty_totaltxtbox.Text;
            printForm.TotalDiscountGiven = discount_totalgiventxtbox.Text;
            printForm.TotalDiscountedAmount = discounted_totaltxtbox.Text;
            printForm.Change = changetxtbox.Text;

            // Show the new form
            printForm.ShowDialog();
        }
    }
}
