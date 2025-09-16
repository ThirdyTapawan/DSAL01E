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
    public partial class Activity2_PrintFrm : Form
    {
        public Activity2_PrintFrm()
        {
            InitializeComponent();
            
        }

        // Public properties to receive data from Activity2.cs
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string DiscountAmount { get; set; }
        public string DiscountedAmount { get; set; }
        public string TotalQuantity { get; set; }
        public string TotalDiscountGiven { get; set; }
        public string TotalDiscountedAmount { get; set; }
        public string Change { get; set; }

        private void Activity2_PrintFrm_Load(object sender, EventArgs e)
        {
            // Set the textbox values using the public properties
            // Make sure these textbox names match the ones in your form designer
            itemnametxtbox.Text = ItemName;
            quantitytxtbox.Text = Quantity;
            pricetxtbox.Text = Price;
            discounttxtbox.Text = DiscountAmount;
            discountedtxtbox.Text = DiscountedAmount;
            qty_totaltxtbox.Text = TotalQuantity;
            discount_totalgiventxtbox.Text = TotalDiscountGiven;
            discounted_totaltxtbox.Text = TotalDiscountedAmount;
            changetxtbox.Text = Change;

            // Optional: Disable all textboxes on this form so they are read-only
            itemnametxtbox.Enabled = false;
            quantitytxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totalgiventxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
        }
    }
}
