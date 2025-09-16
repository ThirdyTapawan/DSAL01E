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
    public partial class Activity4 : Form
    {
        //declaration of global variables
        private string picpath;
        private Double basic_netincome = 0.00,
                       basic_numhrs = 0.00,
                       basic_rate = 0.00,
                       hono_netincome = 0.00,
                       hono_numhrs = 0.00,
                       hono_rate = 0.00,
                       other_netincome = 0.00,
                       other_numhrs = 0.00,
                       other_rate = 0.00;
        private Double netincome = 0.00,
                       grossincome = 0.00,
                       sss_contrib = 0.00,
                       pagibig_contrib = 0.00,
                       philhealth_contrib = 0.00,
                       tax_contrib = 0.00;
        private Double sss_loan = 0.00,
                       pagibig_loan = 0.00,
                       salary_loan = 0.00,
                       salary_savings = 0.00,
                       faculty_sav_loan = 0.00,
                       other_deduction = 0.00,
                       total_deduction = 0.00,
                       total_contrib = 0.00,
                       total_loan = 0.00;

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
            other_rate = Convert.ToDouble(other_rateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincomeTxtbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome + other_netincome;
            gross_incomeTxtbox.Text = grossincome.ToString("n");

        }

        private void Honorarium_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(Honorarium_numhrsTxtbox.Text);
            hono_rate = Convert.ToDouble(Honorarium_rateTxtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Double.Parse(basic_numhrsTxtbox.Text);
            basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_netincomeTxtbox.Text = basic_netincome.ToString("n");
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image file|*.gif;*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //codes for clearing the textboxes
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numberofdependentsTxtbox.Clear();
            empstatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            Honorarium_numhrsTxtbox.Clear();
            Honorarium_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            //codes for clearing the textboxes
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numberofdependentsTxtbox.Clear();
            empstatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            Honorarium_numhrsTxtbox.Clear();
            Honorarium_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        

        private void printpayslipBtn_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form
            Activity4_PrintFrm print1 = new Activity4_PrintFrm();
            //codes for displaying the contents of the listbox from other form to the
            //current form
            print1.priDisplayListBox.Items.AddRange(this.payslip_viewlistbox
                .Items);
            //code for displaying the other form
            print1.Show();
        }

        private void previewpayslipBtn_Click(object sender, EventArgs e)
        {
            //payslip_viewlistbox.Items.Add("");
            payslip_viewlistbox.Items.Add("Employee Number: " +
            " " + emp_nuTxtbox.Text);
            payslip_viewlistbox.Items.Add("Firstname: " + 
            " " + firstnameTxtbox.Text);
            payslip_viewlistbox.Items.Add("Middlename: " + 
            " " + MNameTxtbox.Text);
            payslip_viewlistbox.Items.Add("Surname: " + 
            " " + surTxtbox.Text);
            payslip_viewlistbox.Items.Add("Designation: " + 
            " " + desigTxtbox.Text);
            payslip_viewlistbox.Items.Add("Employee Status: " + 
            " " + empstatusTxtbox.Text);
            payslip_viewlistbox.Items.Add("Department: " + 
            " " + DeptNameTxtbox.Text);
            payslip_viewlistbox.Items.Add("Pay Date: " + 
            " " + paydateTxtpicker.Text);
            payslip_viewlistbox.Items.Add("--------------------------------------------------------------");

            payslip_viewlistbox.Items.Add("BP Num. of Hrs.: " + 
            " " + basic_numhrsTxtbox.Text);
            payslip_viewlistbox.Items.Add("BP Rate / Hr.: " + 
            " " + basic_rateTxtbox.Text);
            payslip_viewlistbox.Items.Add("Baisc Pay Income: " + 
            " " + basic_netincomeTxtbox.Text);
            payslip_viewlistbox.Items.Add("");
            payslip_viewlistbox.Items.Add("HI Num. of Hrs.: " + 
            " " + Honorarium_numhrsTxtbox.Text);
            payslip_viewlistbox.Items.Add("HI Rate / Hr.: " + 
            " " + Honorarium_rateTxtbox.Text);
            payslip_viewlistbox.Items.Add("Honorarium Income: " + 
            " " + hono_netincomeTxtbox.Text);
            payslip_viewlistbox.Items.Add("");
            payslip_viewlistbox.Items.Add("OTI Num. of Hrs.: " + 
            " " + other_numhrsTxtbox.Text);
            payslip_viewlistbox.Items.Add("OTI Rate / Hr.: " + 
            " " + other_rateTxtbox.Text);
            payslip_viewlistbox.Items.Add("Other Income: " + 
            " " + other_netincomeTxtbox.Text);
            payslip_viewlistbox.Items.Add("--------------------------------------------------------------");
            payslip_viewlistbox.Items.Add("SSS Contribution: " + 
            " " + sss_contribTxtbox.Text);
            payslip_viewlistbox.Items.Add("PhilHealth Contribution: " + 
            " " + philhealth_contribTxtbox.Text);
            payslip_viewlistbox.Items.Add("Pagibig Contribution: " + 
            " " + pagibig_contribTxtbox.Text);
            payslip_viewlistbox.Items.Add("Tax Contribution: " + 
            " " + tax_contribTxtbox.Text);
            payslip_viewlistbox.Items.Add("SSS Loan: " + 
            " " + sss_loanTxtbox.Text);
            payslip_viewlistbox.Items.Add("Pagibig Loan: " + 
            " " + pagibig_loanTxtbox.Text);
            payslip_viewlistbox.Items.Add("Faculty Savings Deposit: " + 
            " " + FSD_depositTxtbox.Text);
            payslip_viewlistbox.Items.Add("Faculty Savings Loan: " + 
            " " + FS_loanTxtbox.Text);
            payslip_viewlistbox.Items.Add("Salary Loan: " + 
            " " + sal_loanTxtbox.Text);
            payslip_viewlistbox.Items.Add("Other Loan: " + 
            " " + otherloanTxtbox.Text);
            payslip_viewlistbox.Items.Add("--------------------------------------------------------------");
            payslip_viewlistbox.Items.Add("Total Deduction: " + 
            " " + total_deducTxtbox.Text);
            payslip_viewlistbox.Items.Add("Gross Income: " + 
            " " + gross_incomeTxtbox.Text);
            payslip_viewlistbox.Items.Add("Net Income: " + 
            " " + net_incomeTxtbox.Text);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //codes for converting input data from textboxes as string to numeric
            //codes for putting data from textboxes to variables
            sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
            sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
            salary_loan = Convert.ToDouble(sal_loanTxtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loanTxtbox.Text);
            salary_savings = Convert.ToDouble(FSD_depositTxtbox.Text);
            other_deduction = Convert.ToDouble(otherloanTxtbox.Text);
            //formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib +
                            tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan +
                         salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;
            //codes for converting numeric data to string and displayed it inside the
            //textboxes
            total_deducTxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            net_incomeTxtbox.Text = netincome.ToString("n");
        }
         
        public Activity4()
        {
            InitializeComponent();
        }

        private void Activity4_Load(object sender, EventArgs e)
        {
            //codes for disabling
            basic_netincomeTxtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
            sss_contribTxtbox.Text = "0.00";
            pagibig_contribTxtbox.Text = "0.00";
            philhealth_contribTxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";
            sss_loanTxtbox.Text = "0.00";
            pagibig_loanTxtbox.Text = "0.00";
            FSD_depositTxtbox.Text = "0.00";
            FS_loanTxtbox.Text = "0.00";
            sal_loanTxtbox.Text = "0.00";
            otherloanTxtbox.Text = "0.00";
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            picpathTxtbox.Hide();
        }



    }
}
