using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lesson1._2
{
    public partial class Activity3 : Form
    {
        //codes for declaring a variables that is accessible to the whole form and can be access from one object to another
        private double total_amount = 0;
        private int total_qty = 0;
        public Activity3()
        {
            InitializeComponent();
        }

        // Start of Example 4 Back end Code
        private void Activity3_Load(object sender, EventArgs e)
        {
            //disabling textboxes
            priceTextbox.Enabled = false;
            discountedAmountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalBillsTxtbox.Enabled = false;
            discountTxtbox.Enabled = false;
            totalQtyTxtbox.Enabled = false;

            //codes for inserting image to a picturebox
            pizza6.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza Special A.png");
            pizza7.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza Special B.png");
            pizza8.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza Special C.png");
            pizza9.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza Special D.png");
            pizza10.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza Barbeque.png");
            pizza11.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 1.png");
            pizza12.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 2.png");
            pizza13.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 3.png");
            pizza14.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 4.png");
            pizza15.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 5.png");
            pizza16.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 6.png");
            pizza17.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 7.png");
            pizza18.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 8.png");
            pizza19.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Pizza 9.png");
            pizza20.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Amanos Pizza.png");

            //codes to disable in checkbox
            A_CokeCheckbox.Enabled = false;
            A_FriedChickenCheckbox.Enabled = false;
            A_FriesCheckbox.Enabled = false;
            A_sideDishCheckbox.Enabled = false;
            A_speciaPizzaCheckbox.Enabled = false;
            B_CarbonaraCheckbox.Enabled = false;
            B_ChickenCheckbox.Enabled = false;
            B_FriesCheckbox.Enabled = false;
            B_HaloHaloCheckbox.Enabled = false;
            B_HawaiianCheckbox.Enabled = false;
        }

        private void FoodBundleARadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
            FoodBundleBRadioBtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Amanos Pizza.png");

            A_CokeCheckbox.Checked = true;
            A_FriedChickenCheckbox.Checked = true;
            A_FriesCheckbox.Checked = true;
            A_sideDishCheckbox.Checked = true;
            A_speciaPizzaCheckbox.Checked = true;

            B_CarbonaraCheckbox.Checked = false;
            B_ChickenCheckbox.Checked = false;
            B_FriesCheckbox.Checked = false;
            B_HaloHaloCheckbox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            priceTextbox.Text = "1600.00";
            discountTxtbox.Text = "200.00";

            double price = 1600.00;
            double discount = 200.00;
            double bundleTotal = price - discount;
            totalBillsTxtbox.Text = bundleTotal.ToString("F2");

            displayListBox.Items.Add(FoodBundleARadioBtn.Text + " " + priceTextbox.Text);
            displayListBox.Items.Add("Discount Amount: " + discountTxtbox.Text);

            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void FoodBundleBRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            FoodBundleARadioBtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\Task 4 Amanos Pizza.png");

            A_CokeCheckbox.Checked = false;
            A_FriedChickenCheckbox.Checked = false;
            A_FriesCheckbox.Checked = false;
            A_sideDishCheckbox.Checked = false;
            A_speciaPizzaCheckbox.Checked = false;

            B_CarbonaraCheckbox.Checked = true;
            B_ChickenCheckbox.Checked = true;
            B_FriesCheckbox.Checked = true;
            B_HaloHaloCheckbox.Checked = true;
            B_HawaiianCheckbox.Checked = true;

            priceTextbox.Text = "1299.00";
            discountTxtbox.Text = "194.85";

            double price = 1299.00;
            double discount = 194.85;
            double bundleTotal = price - discount;
            totalBillsTxtbox.Text = bundleTotal.ToString("F2");

            displayListBox.Items.Add(FoodBundleBRadioBtn.Text + " " + priceTextbox.Text);
            displayListBox.Items.Add("Discount Amount: " + discountTxtbox.Text);

            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void CalculateBillBtn_Click(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount, cash_given, change;
            int qty;

            if (!double.TryParse(cashGivenTxtbox.Text, out cash_given))
            {
                MessageBox.Show("Please enter a valid number for Cash Given.");
                return;
            }

            if (!double.TryParse(priceTextbox.Text.Replace(",", "").Trim(), out price))
            {
                MessageBox.Show("Price is not set correctly.");
                return;
            }

            if (!int.TryParse(qtyTxtbox.Text, out qty))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string cleanedDiscount = discountTxtbox.Text.Replace("P", "").Replace("(5% of the Price)", "").Trim();
            if (!double.TryParse(cleanedDiscount, out discount_amount))
            {
                discount_amount = 0;
            }

            discounted_amount = (price * qty) - discount_amount;

            total_qty += qty;
            total_amount += discounted_amount;

            totalQtyTxtbox.Text = total_qty.ToString();
            totalBillsTxtbox.Text = total_amount.ToString("N");
            discountedAmountTxtbox.Text = discounted_amount.ToString("N");

            change = cash_given - total_amount;
            changeTxtbox.Text = change.ToString("N");

            displayListBox.Items.Add("Total Bills: " + totalBillsTxtbox.Text);
            displayListBox.Items.Add("Cash Given: " + cashGivenTxtbox.Text);
            displayListBox.Items.Add("Change: " + changeTxtbox.Text);
            displayListBox.Items.Add("Discounted Amount: " + discountedAmountTxtbox.Text);
            displayListBox.Items.Add("Total No. of Items: " + totalQtyTxtbox.Text);
        }

        private void PrintTransactionBtn_Click(object sender, EventArgs e)
        {
            Activity3_PrintFrm print = new Activity3_PrintFrm();
            print.printDisplayListbox.Items.AddRange(this.displayListBox.Items);
            print.Show();
        }

        private void RemoveOrderBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = displayListBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                displayListBox.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the list.");
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            //codes to uncheck all given checkboxes
            FoodBundleARadioBtn.Checked = false;
            FoodBundleBRadioBtn.Checked = false;
            //code for inserting default image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Pictures\\Activity 1 Pictures\\No Image.png");
            A_CokeCheckbox.Checked = false;
            A_FriedChickenCheckbox.Checked = false;
            A_FriesCheckbox.Checked = false;
            A_sideDishCheckbox.Checked = false;
            A_speciaPizzaCheckbox.Checked = false;
            B_CarbonaraCheckbox.Checked = false;
            B_ChickenCheckbox.Checked = false;
            B_FriesCheckbox.Checked = false;
            B_HaloHaloCheckbox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            priceTextbox.Clear();
            qtyTxtbox.Clear();
            cashGivenTxtbox.Clear();
            discountTxtbox.Clear();
            totalBillsTxtbox.Clear();
            totalQtyTxtbox.Clear();
            changeTxtbox.Clear();
            discountedAmountTxtbox.Clear();
            displayListBox.Items.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            total_amount = 0;
            total_qty = 0;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
            int qty;

            string cleanedPrice = priceTextbox.Text.Replace(",", "").Replace("₱", "").Trim();
            if (!double.TryParse(cleanedPrice, out price))
            {
                discountedAmountTxtbox.Text = "0.00";
                return;
            }

            if (!int.TryParse(qtyTxtbox.Text, out qty))
            {
                totalQtyTxtbox.Text = "0";
                return;
            }

            string cleanedDiscount = discountTxtbox.Text.Replace("P", "").Replace("(5% of the Price)", "").Trim();
            if (!double.TryParse(cleanedDiscount, out discount_amount))
            {
                discount_amount = 0;
            }

            discounted_amount = (price * qty) - discount_amount;

            totalQtyTxtbox.Text = qty.ToString();
            totalBillsTxtbox.Text = discounted_amount.ToString("N");
            discountedAmountTxtbox.Text = discounted_amount.ToString("N");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "500.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox1.Text + " " + priceTextbox.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "550.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox2.Text + " " + priceTextbox.Text);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "600.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox3.Text + " " + priceTextbox.Text);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "700.50";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox4.Text + " " + priceTextbox.Text);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "500.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox5.Text + " " + priceTextbox.Text);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "750.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox6.Text + " " + priceTextbox.Text);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "700.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox7.Text + " " + priceTextbox.Text);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "850.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox8.Text + " " + priceTextbox.Text);

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "450.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox9.Text + " " + priceTextbox.Text);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "650.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox10.Text + " " + priceTextbox.Text);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox11.Text + " " + priceTextbox.Text);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox12.Text + " " + priceTextbox.Text);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox13.Text + " " + priceTextbox.Text);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox14.Text + " " + priceTextbox.Text);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox15.Text + " " + priceTextbox.Text);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox16.Text + " " + priceTextbox.Text);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox17.Text + " " + priceTextbox.Text);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox19.Text + " " + priceTextbox.Text);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox19.Text + " " + priceTextbox.Text);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            priceTextbox.Text = "575.00";
            discountTxtbox.Text = "0.00";
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
            displayListBox.Items.Add(checkBox20.Text + " " + priceTextbox.Text);
        }
    }
}
