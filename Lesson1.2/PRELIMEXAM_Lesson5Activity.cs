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
    public partial class PRELIMEXAM_Lesson5Activity : Form
    {
        public PRELIMEXAM_Lesson5Activity()
        {
            InitializeComponent();
        }

        private void grossincomeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Read Income Inputs from textboxes
                double basicRate = double.Parse(txtBasicRate.Text);
                double basicHours = double.Parse(txtBasicHours.Text);
                double honorariumRate = double.Parse(txtHonorariumRate.Text);
                double honorariumHours = double.Parse(txtHonorariumHours.Text);
                double otherRate = double.Parse(txtOtherRate.Text);
                double otherHours = double.Parse(txtOtherHours.Text);

                // 2. Perform Income Calculations
                double basicIncomeCutoff = basicRate * basicHours;
                double honorariumIncomeCutoff = honorariumRate * honorariumHours;
                double otherIncomeCutoff = otherRate * otherHours;

                // 3. Calculate Gross Income
                double grossIncome = basicIncomeCutoff + honorariumIncomeCutoff + otherIncomeCutoff;

                // 4. Display results in their respective textboxes
                txtBasicIncomeCutoff.Text = basicIncomeCutoff.ToString("N2");
                txtHonorariumIncomeCutoff.Text = honorariumIncomeCutoff.ToString("N2");
                txtOtherIncomeCutoff.Text = otherIncomeCutoff.ToString("N2");
                txtGrossIncome.Text = grossIncome.ToString("N2");

                // 5. AUTOMATICALLY COMPUTE REGULAR DEDUCTIONS based on Gross Income

                // PhilHealth contribution
                double philhealthContribution = 0;
                if (grossIncome <= 10000)
                {
                    philhealthContribution = 137.50;
                }
                else if (grossIncome > 10000 && grossIncome <= 11000)
                {
                    philhealthContribution = 151.25;
                }
                else if (grossIncome > 11000 && grossIncome <= 12000)
                {
                    philhealthContribution = 165.00;
                }
                else if (grossIncome > 12000 && grossIncome <= 13000)
                {
                    philhealthContribution = 178.75;
                }
                else if (grossIncome > 13000 && grossIncome <= 14000)
                {
                    philhealthContribution = 192.50;
                }
                else if (grossIncome > 14000 && grossIncome <= 15000)
                {
                    philhealthContribution = 206.25;
                }
                else if (grossIncome > 15000 && grossIncome <= 16000)
                {
                    philhealthContribution = 220.00;
                }
                else if (grossIncome > 16000 && grossIncome <= 17000)
                {
                    philhealthContribution = 233.75;
                }
                else if (grossIncome > 17000 && grossIncome <= 18000)
                {
                    philhealthContribution = 247.50;
                }
                else if (grossIncome > 18000 && grossIncome <= 19000)
                {
                    philhealthContribution = 261.25;
                }
                else if (grossIncome > 19000 && grossIncome <= 20000)
                {
                    philhealthContribution = 275.00;
                }
                else if (grossIncome > 20000 && grossIncome <= 21000)
                {
                    philhealthContribution = 288.75;
                }
                else if (grossIncome > 21000 && grossIncome <= 22000)
                {
                    philhealthContribution = 302.50;
                }
                else if (grossIncome > 22000 && grossIncome <= 23000)
                {
                    philhealthContribution = 316.25;
                }
                else if (grossIncome > 23000 && grossIncome <= 24000)
                {
                    philhealthContribution = 330.00;
                }
                else if (grossIncome > 24000 && grossIncome <= 25000)
                {
                    philhealthContribution = 343.75;
                }
                else if (grossIncome > 25000 && grossIncome <= 26000)
                {
                    philhealthContribution = 357.50;
                }
                else if (grossIncome > 26000 && grossIncome <= 27000)
                {
                    philhealthContribution = 371.25;
                }
                else if (grossIncome > 27000 && grossIncome <= 28000)
                {
                    philhealthContribution = 385.00;
                }
                else if (grossIncome > 28000 && grossIncome <= 29000)
                {
                    philhealthContribution = 398.75;
                }
                else if (grossIncome > 29000 && grossIncome <= 30000)
                {
                    philhealthContribution = 412.50;
                }
                else if (grossIncome > 30000 && grossIncome <= 31000)
                {
                    philhealthContribution = 426.25;
                }
                else if (grossIncome > 31000 && grossIncome <= 32000)
                {
                    philhealthContribution = 440.00;
                }
                else if (grossIncome > 32000 && grossIncome <= 33000)
                {
                    philhealthContribution = 453.75;
                }
                else if (grossIncome > 33000 && grossIncome <= 34000)
                {
                    philhealthContribution = 467.50;
                }
                else if (grossIncome > 34000 && grossIncome <= 35000)
                {
                    philhealthContribution = 481.25;
                }
                else if (grossIncome > 35000 && grossIncome <= 36000)
                {
                    philhealthContribution = 495.00;
                }
                else if (grossIncome > 36000 && grossIncome <= 37000)
                {
                    philhealthContribution = 508.75;
                }
                else if (grossIncome > 37000 && grossIncome <= 38000)
                {
                    philhealthContribution = 522.50;
                }
                else if (grossIncome > 38000 && grossIncome <= 39000)
                {
                    philhealthContribution = 536.25;
                }
                else if (grossIncome > 39000 && grossIncome <= 39999.99)
                {
                    philhealthContribution = 543.13;
                }
                else // grossIncome >= 40000
                {
                    philhealthContribution = 550.00;
                }

                // SSS contribution
                double sssContribution = 0;
                if (grossIncome < 1000)
                {
                    sssContribution = 0.00;
                }
                else if (grossIncome >= 1000 && grossIncome <= 1249.99)
                {
                    sssContribution = 36.30;
                }
                else if (grossIncome >= 1250 && grossIncome <= 1749.99)
                {
                    sssContribution = 54.50;
                }
                else if (grossIncome >= 1750 && grossIncome <= 2249.99)
                {
                    sssContribution = 72.70;
                }
                else if (grossIncome >= 2250 && grossIncome <= 2749.99)
                {
                    sssContribution = 90.80;
                }
                else if (grossIncome >= 2750 && grossIncome <= 3249.99)
                {
                    sssContribution = 109.00;
                }
                else if (grossIncome >= 3250 && grossIncome <= 3749.99)
                {
                    sssContribution = 127.20;
                }
                else if (grossIncome >= 3750 && grossIncome <= 4249.99)
                {
                    sssContribution = 145.30;
                }
                else if (grossIncome >= 4250 && grossIncome <= 4749.99)
                {
                    sssContribution = 163.50;
                }
                else if (grossIncome >= 4750 && grossIncome <= 5249.99)
                {
                    sssContribution = 181.70;
                }
                else if (grossIncome >= 5250 && grossIncome <= 5749.99)
                {
                    sssContribution = 199.80;
                }
                else if (grossIncome >= 5750 && grossIncome <= 6249.99)
                {
                    sssContribution = 218.00;
                }
                else if (grossIncome >= 6250 && grossIncome <= 6749.99)
                {
                    sssContribution = 236.29;
                }
                else if (grossIncome >= 6750 && grossIncome <= 7249.99)
                {
                    sssContribution = 254.30;
                }
                else if (grossIncome >= 7250 && grossIncome <= 7749.99)
                {
                    sssContribution = 272.50;
                }
                else if (grossIncome >= 7750 && grossIncome <= 8249.99)
                {
                    sssContribution = 290.70;
                }
                else if (grossIncome >= 8250 && grossIncome <= 8749.99)
                {
                    sssContribution = 308.80;
                }
                else if (grossIncome >= 8750 && grossIncome <= 9249.99)
                {
                    sssContribution = 327.00;
                }
                else if (grossIncome >= 9250 && grossIncome <= 9749.99)
                {
                    sssContribution = 345.20;
                }
                else if (grossIncome >= 9750 && grossIncome <= 10249.99)
                {
                    sssContribution = 363.30;
                }
                else if (grossIncome >= 10250 && grossIncome <= 10749.99)
                {
                    sssContribution = 381.50;
                }
                else if (grossIncome >= 10750 && grossIncome <= 11249.99)
                {
                    sssContribution = 399.70;
                }
                else if (grossIncome >= 11250 && grossIncome <= 11749.99)
                {
                    sssContribution = 417.80;
                }
                else if (grossIncome >= 11750 && grossIncome <= 12249.99)
                {
                    sssContribution = 436.00;
                }
                else if (grossIncome >= 12250 && grossIncome <= 12749.99)
                {
                    sssContribution = 454.20;
                }
                else if (grossIncome >= 12750 && grossIncome <= 13249.99)
                {
                    sssContribution = 472.30;
                }
                else if (grossIncome >= 13250 && grossIncome <= 13749.99)
                {
                    sssContribution = 490.50;
                }
                else if (grossIncome >= 13750 && grossIncome <= 14249.99)
                {
                    sssContribution = 508.70;
                }
                else if (grossIncome >= 14250 && grossIncome <= 14749.99)
                {
                    sssContribution = 526.80;
                }
                else if (grossIncome >= 14750 && grossIncome <= 15249.99)
                {
                    sssContribution = 545.00;
                }
                else if (grossIncome >= 15250 && grossIncome <= 15749.99)
                {
                    sssContribution = 563.20;
                }
                else // grossIncome > 15749.99
                {
                    sssContribution = 581.30;
                }

                // Income Tax Contribution (TAX 2019)
                double taxContribution = 0;
                if (grossIncome <= 10416.67) // 250,000 / 24 months
                {
                    taxContribution = 0.00;
                }
                else if (grossIncome > 10416.67 && grossIncome <= 16666.67)
                {
                    taxContribution = ((((grossIncome * 24) - 250000) * 0.20) / 24);
                }
                else if (grossIncome > 16666.67 && grossIncome <= 33333.33)
                {
                    taxContribution = ((((grossIncome * 24) - 400000) * 0.25) + 30000) / 24;
                }
                else if (grossIncome > 33333.33 && grossIncome <= 83333.33)
                {
                    taxContribution = ((((grossIncome * 24) - 800000) * 0.30) + 130000) / 24;
                }
                else if (grossIncome > 83333.33 && grossIncome <= 333333.33)
                {
                    taxContribution = ((((grossIncome * 24) - 2000000) * 0.32) + 490000) / 24;
                }
                else // grossIncome > 333,333.33
                {
                    taxContribution = ((((grossIncome * 24) - 8000000) * 0.35) + 2410000) / 24;
                }

                // Pag-IBIG contribution is fixed at 100 pesos
                double pagibigContribution = 100.00;

                // Display the calculated contributions
                txtPhilhealthContribution.Text = philhealthContribution.ToString("N2");
                txtSSSContribution.Text = sssContribution.ToString("N2");
                txtPagibigContribution.Text = pagibigContribution.ToString("N2"); // Display Pag-IBIG
                txtIncomeTaxContribution.Text = taxContribution.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for all income fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void netincomeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Read all Deduction Inputs from textboxes
                double sssContribution = double.Parse(txtSSSContribution.Text);
                double philhealthContribution = double.Parse(txtPhilhealthContribution.Text);
                double incomeTaxContribution = double.Parse(txtIncomeTaxContribution.Text);
                double pagibigContribution = double.Parse(txtPagibigContribution.Text); // Read Pag-IBIG from textbox

                // Other Deductions
                double sssLoan = double.Parse(txtSSSLoan.Text);
                double pagibigLoan = double.Parse(txtPagibigLoan.Text);
                double facultySavingsDeposit = double.Parse(txtFacultySavingsDeposit.Text);
                double facultySavingsLoan = double.Parse(txtFacultySavingsLoan.Text);
                double salaryLoan = double.Parse(txtSalaryLoan.Text);
                double otherLoans = double.Parse(txtOtherLoans.Text);

                // 2. Calculate Total Deductions
                double totalDeductions = sssContribution + philhealthContribution + incomeTaxContribution + pagibigContribution +
                                         sssLoan + pagibigLoan + facultySavingsDeposit + facultySavingsLoan + salaryLoan + otherLoans;

                // 3. Retrieve Gross Income and calculate Net Income
                double grossIncome = double.Parse(txtGrossIncome.Text);
                double netIncome = grossIncome - totalDeductions;

                // 4. Display results
                txtTotalDeductions.Text = totalDeductions.ToString("N2");
                txtNetIncome.Text = netIncome.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all deduction and gross income fields contain valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Clear all textboxes on the form
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void PRELIMEXAM_Lesson5Activity_Load(object sender, EventArgs e)
        {
            // Disabling Textboxes for the following:
            txtSSSContribution.Enabled = false;
            txtPhilhealthContribution.Enabled = false;
            txtPagibigContribution.Enabled = false;
            txtIncomeTaxContribution.Enabled = false;
            txtGrossIncome.Enabled = false;
            txtNetIncome.Enabled = false;
            txtTotalDeductions.Enabled = false;
            txtBasicIncomeCutoff.Enabled = false;
            txtHonorariumIncomeCutoff.Enabled = false;
            txtOtherIncomeCutoff.Enabled = false;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get all the computed and user-input values from the form
                string employeeCode = txtEmployeeNumber.Text;
                string firstName = txtFirstname.Text;
                string middleName = txtMiddleName.Text;
                string surname = txtSurname.Text;
                string department = txtDepartment.Text;
                string payDate = txtPaydate.Text;

                // Get hours/rates for earnings
                int basicHours = int.Parse(txtBasicHours.Text);
                int honorariumHours = int.Parse(txtHonorariumHours.Text);
                int otherHours = int.Parse(txtOtherHours.Text);

                // Get computed income and deduction values
                double basicIncome = double.Parse(txtBasicIncomeCutoff.Text);
                double honorariumIncome = double.Parse(txtHonorariumIncomeCutoff.Text);
                double otherIncome = double.Parse(txtOtherIncomeCutoff.Text);
                double grossIncome = double.Parse(txtGrossIncome.Text);

                double sssContribution = double.Parse(txtSSSContribution.Text);
                double philhealthContribution = double.Parse(txtPhilhealthContribution.Text);
                double pagibigContribution = double.Parse(txtPagibigContribution.Text);
                double incomeTaxContribution = double.Parse(txtIncomeTaxContribution.Text);

                double sssLoan = double.Parse(txtSSSLoan.Text);
                double pagibigLoan = double.Parse(txtPagibigLoan.Text);
                double facultySavingsDeposit = double.Parse(txtFacultySavingsDeposit.Text);
                double facultySavingsLoan = double.Parse(txtFacultySavingsLoan.Text);
                double salaryLoan = double.Parse(txtSalaryLoan.Text);
                double otherLoans = double.Parse(txtOtherLoans.Text);

                double totalDeductions = double.Parse(txtTotalDeductions.Text);
                double netIncome = double.Parse(txtNetIncome.Text);

                // Create an instance of the payslip form and pass the data
                PRELIMEXAM_Lesson5Activity_PrintFrm payslipForm = new PRELIMEXAM_Lesson5Activity_PrintFrm(
                    employeeCode, firstName, middleName, surname, department, payDate,
                    basicHours, basicIncome, honorariumHours, honorariumIncome, otherHours, otherIncome,
                    sssContribution, philhealthContribution, pagibigContribution, incomeTaxContribution,
                    sssLoan, pagibigLoan, facultySavingsDeposit, facultySavingsLoan,
                    salaryLoan, otherLoans, totalDeductions, grossIncome, netIncome);

                // Show the payslip form
                payslipForm.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all required fields are filled with valid numeric values before generating the payslip.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

/*
 * This line focus on the rates regarding on the deduction for SSS, PhilHealth and Tax Contribution 

            //philhealth contribution based from the current table
            if (grossincome <= 10000)
            {
                philhealth_contribTxtbox.Text = "137.50";
            }
            else if (grossincome > 10000 && grossincome <= 11000)
            {
                philhealth_contribTxtbox.Text = "151.25";
            }
            else if (grossincome > 11000 && grossincome <= 12000)
            {
                philhealth_contribTxtbox.Text = "165.00";
            }
            else if (grossincome > 12000 && grossincome <= 13000)
            {
                philhealth_contribTxtbox.Text = "178.75";
            }
            else if (grossincome > 13000 && grossincome <= 14000)
            {
                philhealth_contribTxtbox.Text = "192.50";
            }
            else if (grossincome > 14000 && grossincome <= 15000)
            {
                philhealth_contribTxtbox.Text = "206.25";
            }
            else if (grossincome > 15000 && grossincome <= 16000)
            {
                philhealth_contribTxtbox.Text = "220.00";
            }
            else if (grossincome > 16000 && grossincome <= 17000)
            {
                philhealth_contribTxtbox.Text = "233.75";
            }
            else if (grossincome > 17000 && grossincome <= 18000)
            {
                philhealth_contribTxtbox.Text = "247.50";
            }
            else if (grossincome > 18000 && grossincome <= 19000)
            {
                philhealth_contribTxtbox.Text = "261.25";
            }
            else if (grossincome > 19000 && grossincome <= 20000)
            {
                philhealth_contribTxtbox.Text = "275.00";
            }
            else if (grossincome > 20000 && grossincome <= 21000)
            {
                philhealth_contribTxtbox.Text = "288.75";
            }
            else if (grossincome > 21000 && grossincome <= 22000)
            {
                philhealth_contribTxtbox.Text = "302.50";
            }
            else if (grossincome > 22000 && grossincome <= 23000)
            {
                philhealth_contribTxtbox.Text = "316.25";
            }
            else if (grossincome > 23000 && grossincome <= 24000)
            {
                philhealth_contribTxtbox.Text = "330.00";
            }
            else if (grossincome > 24000 && grossincome <= 25000)
            {
                philhealth_contribTxtbox.Text = "343.75";
            }
            else if (grossincome > 25000 && grossincome <= 26000)
            {
                philhealth_contribTxtbox.Text = "357.50";
            }
            else if (grossincome > 26000 && grossincome <= 27000)
            {
                philhealth_contribTxtbox.Text = "371.25";
            }
            else if (grossincome > 27000 && grossincome <= 28000)
            {
                philhealth_contribTxtbox.Text = "385.00";
            }
            else if (grossincome > 28000 && grossincome <= 29000)
            {
                philhealth_contribTxtbox.Text = "398.75";
            }
            else if (grossincome > 29000 && grossincome <= 30000)
            {
                philhealth_contribTxtbox.Text = "412.50";
            }
            else if (grossincome > 30000 && grossincome <= 31000)
            {
                philhealth_contribTxtbox.Text = "426.25";
            }
            else if (grossincome > 31000 && grossincome <= 32000)
            {
                philhealth_contribTxtbox.Text = "440.00";
            }
            else if (grossincome > 32000 && grossincome <= 33000)
            {
                philhealth_contribTxtbox.Text = "453.75";
            }
            else if (grossincome > 33000 && grossincome <= 34000)
            {
                philhealth_contribTxtbox.Text = "467.50";
            }
            else if (grossincome > 34000 && grossincome <= 35000)
            {
                philhealth_contribTxtbox.Text = "481.25";
            }
            else if (grossincome > 35000 && grossincome <= 36000)
            {
                philhealth_contribTxtbox.Text = "495.00";
            }
            else if (grossincome > 36000 && grossincome <= 37000)
            {
                philhealth_contribTxtbox.Text = "508.75";
            }
            else if (grossincome > 37000 && grossincome <= 38000)
            {
                philhealth_contribTxtbox.Text = "522.50";
            }
            else if (grossincome > 38000 && grossincome <= 39000)
            {
                philhealth_contribTxtbox.Text = "536.25";
            }
            else if (grossincome > 39000 && grossincome <= 39999.99)
            {
                philhealth_contribTxtbox.Text = "543.13";
            }
            else
            {
                philhealth_contribTxtbox.Text = "550.00";
            }

            //SSS contribution based on the current table from SSS
            if (grossincome < 1000)
            {
                sss_contribTxtbox.Text = "0.00";
            }
            else if (grossincome > 1000 && grossincome <= 1249.99)
            {
                sss_contribTxtbox.Text = "36.30";
            }
            else if (grossincome > 1250 && grossincome <= 1749.99)
            {
                sss_contribTxtbox.Text = "54.50";
            }
            else if (grossincome > 1750 && grossincome <= 2249.99)
            {
                sss_contribTxtbox.Text = "72.70";
            }
            else if (grossincome > 2250 && grossincome <= 2749.99)
            {
                sss_contribTxtbox.Text = "90.80";
            }
            else if (grossincome > 2750 && grossincome <= 3249.99)
            {
                sss_contribTxtbox.Text = "109.00";
            }
            else if (grossincome > 3250 && grossincome <= 3749.99)
            {
                sss_contribTxtbox.Text = "127.20";
            }
            else if (grossincome > 3750 && grossincome <= 4249.99)
            {
                sss_contribTxtbox.Text = "145.30";
            }
            else if (grossincome > 4250 && grossincome <= 4749.99)
            {
                sss_contribTxtbox.Text = "163.50";
            }
            else if (grossincome > 4750 && grossincome <= 5249.99)
            {
                sss_contribTxtbox.Text = "181.70";
            }
            else if (grossincome > 5250 && grossincome <= 5749.99)
            {
                sss_contribTxtbox.Text = "199.80";
            }
            else if (grossincome > 5750 && grossincome <= 6249.99)
            {
                sss_contribTxtbox.Text = "218.00";
            }
            else if (grossincome > 6250 && grossincome <= 6749.99)
            {
                sss_contribTxtbox.Text = "236.29";
            }
            else if (grossincome > 6750 && grossincome <= 7249.99)
            {
                sss_contribTxtbox.Text = "254.30";
            }
            else if (grossincome > 7250 && grossincome <= 7749.99)
            {
                sss_contribTxtbox.Text = "272.50";
            }
            else if (grossincome > 7750 && grossincome <= 8249.99)
            {
                sss_contribTxtbox.Text = "290.70";
            }
            else if (grossincome > 8250 && grossincome <= 8749.99)
            {
                sss_contribTxtbox.Text = "308.80";
            }
            else if (grossincome > 8750 && grossincome <= 9249.99)
            {
                sss_contribTxtbox.Text = "327.00";
            }
            else if (grossincome > 9250 && grossincome <= 9749.99)
            {
                sss_contribTxtbox.Text = "345.20";
            }
            else if (grossincome > 9750 && grossincome <= 10249.99)
            {
                sss_contribTxtbox.Text = "363.30";
            }
            else if (grossincome > 10250 && grossincome <= 10749.99)
            {
                sss_contribTxtbox.Text = "381.50";
            }
            else if (grossincome > 10750 && grossincome <= 11249.99)
            {
                sss_contribTxtbox.Text = "399.70";
            }
            else if (grossincome > 11250 && grossincome <= 11749.99)
            {
                sss_contribTxtbox.Text = "417.80";
            }
            else if (grossincome > 11750 && grossincome <= 12249.99)
            {
                sss_contribTxtbox.Text = "436.00";
            }
            else if (grossincome > 12250 && grossincome <= 12749.99)
            {
                sss_contribTxtbox.Text = "454.20";
            }
            else if (grossincome > 12750 && grossincome <= 13249.99)
            {
                sss_contribTxtbox.Text = "472.30";
            }
            else if (grossincome > 13250 && grossincome <= 13749.99)
            {
                sss_contribTxtbox.Text = "490.50";
            }
            else if (grossincome > 13750 && grossincome <= 14249.99)
            {
                sss_contribTxtbox.Text = "508.70";
            }
            else if (grossincome > 14250 && grossincome <= 14749.99)
            {
                sss_contribTxtbox.Text = "526.80";
            }
            else if (grossincome > 14750 && grossincome <= 15249.99)
            {
                sss_contribTxtbox.Text = "545.00";
            }
            else if (grossincome > 15250 && grossincome <= 15749.99)
            {
                sss_contribTxtbox.Text = "563.20";
            }
            else
            {
                sss_contribTxtbox.Text = "581.30";
            }

            //tax contribution per month based on new table of TAX 2019
            if (grossincome < (250000 / 24))
            {
                tax_contribTxtbox.Text = "0.00";
            }
            else if (grossincome > 10416.67 && grossincome <= 16666.67)
            {
                tax = ((((grossincome * 24) - 250000) * 0.20) / 24);
                tax_contribTxtbox.Text = tax.ToString("n");
            }
            else if (grossincome > 16666.67 && grossincome <= 33333.33)
            {
                tax = ((((grossincome * 24) - 400000) * 0.25) + 30000) / 24;
                tax_contribTxtbox.Text = tax.ToString("n");
            }
            else if (grossincome > 33333.33 && grossincome <= 83333.33)
            {
                tax = ((((grossincome * 24) - 800000) * 0.30) + 130000) / 24;
                tax_contribTxtbox.Text = tax.ToString("n");
            }
            else if (grossincome > 83333.33 && grossincome <= 333333.33)
            {
                tax = ((((grossincome * 24) - 2000000) * 0.32) + 490000) / 24;
                tax_contribTxtbox.Text = tax.ToString("n");
            }
            else
            {
                tax = ((((grossincome * 24) - 8000000) * 0.35) + 2410000) / 24;
                tax_contribTxtbox.Text = tax.ToString("n");
            }
                catch (Exception)
            {
                MessageBox.Show("Invalid data entry");
                other_numhrsTxtbox.Clear();
                other_numhrsTxtbox.Focus();

                Other Loans combobox:
                if (others_loanCombo.Text == "Other 1")
                {
                    others_loanTxtbox.Text = "500.00";
                }
                else if (others_loanCombo.Text == "Other 2")
                {
                    others_loanTxtbox.Text = "550.00";
                }
                else if (others_loanCombo.Text == "Other 3")
                {
                    others_loanTxtbox.Text = "1550.00";
                }
                else if (others_loanCombo.Text == "Other 4")
                {
                    others_loanTxtbox.Text = "1250.00";
                }
                else
                {
                    MessageBox.Show("No other loan option selected!");
                }
                */


