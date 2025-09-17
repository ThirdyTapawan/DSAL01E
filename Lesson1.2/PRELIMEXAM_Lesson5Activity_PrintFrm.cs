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
    public partial class PRELIMEXAM_Lesson5Activity_PrintFrm : Form
    {
        public PRELIMEXAM_Lesson5Activity_PrintFrm(string employeeCode, string firstName, string middleName, string surname, string department, string payDate,
                                                  double basicHours, double basicIncome, double honorariumHours, double honorariumIncome, double otherHours, double otherIncome,
                                                  double sssContribution, double philhealthContribution, double pagibigContribution, double incomeTaxContribution,
                                                  double sssLoan, double pagibigLoan, double facultySavingsDeposit, double facultySavingsLoan,
                                                  double salaryLoan, double otherLoans, double totalDeductions, double grossIncome, double netIncome)
        {
            InitializeComponent();

            // SSS WISP contribution is a fixed value.
            double sssWisp = 750.00;

            // HDMF Contribution is the same as Pag-IBIG.
            double hdmf = pagibigContribution;

            // Define hardcoded values for the payslip
            double honorariumAdjustment = 0.00;
            double substitution = 0.00;
            double tardy = 0.00;

            // Populate Employee Information
            txtEmployeeCode.Text = employeeCode;
            txtEmployeeName.Text = $"{firstName} {middleName} {surname}";
            txtDepartment.Text = department;
            txtCutoff.Text = payDate;
            txtPayPeriod.Text = payDate;
            txtcompany.Text = "Lyceum of the Philippines University - Cavite";

            // Populate Earnings section
            // Day/Hrs
            txtBasicPayDayHrs.Text = basicHours.ToString("N2");
            txtOvertimeDayHrs.Text = otherHours.ToString("N2");
            txtHonorariumDayHrs.Text = honorariumHours.ToString("N2");
            txtHonorariumAdjDayHrs.Text = "0.00";
            txtSubstitutionDayHrs.Text = "0.00";
            txtTardyDayHrs.Text = "0.00";

            // Non-Taxable (Actual Earnings)
            txtBasicPayNonTaxable.Text = basicIncome.ToString("N2");
            txtOvertimeNonTaxable.Text = otherIncome.ToString("N2");
            txtHonorariumNonTaxable.Text = honorariumIncome.ToString("N2");
            txtHonorariumAdjNonTaxable.Text = honorariumAdjustment.ToString("N2");
            txtSubstitutionNonTaxable.Text = substitution.ToString("N2");
            txtTardyNonTaxable.Text = tardy.ToString("N2");

            // Taxable (Non-Taxable - Tax)
            double basicPayTaxable = basicIncome;
            double overtimeTaxable = otherIncome;
            double honorariumTaxable = honorariumIncome;

            txtBasicPayTaxable.Text = basicPayTaxable.ToString("N2");
            txtOvertimeTaxable.Text = overtimeTaxable.ToString("N2");
            txtHonorariumTaxable.Text = honorariumTaxable.ToString("N2");
            txtHonorariumAdjTaxable.Text = "0.00";
            txtSubstitutionTaxable.Text = "0.00";
            txtTardyTaxable.Text = "0.00";

            // Total Earnings
            txtEarnings.Text = grossIncome.ToString("N2");

            // Populate Deductions
            txtWithholdingTax.Text = incomeTaxContribution.ToString("N2");
            txtSSSContribution.Text = sssContribution.ToString("N2");
            txtHDMF.Text = hdmf.ToString("N2");
            txtPhilhealth.Text = philhealthContribution.ToString("N2");
            txtSSSWISP.Text = sssWisp.ToString("N2");

            // Populate the DEDUCTIONS textbox on the payslip
            txtDeductions.Text = totalDeductions.ToString("N2");

            // Populate Overtime, Gross Earnings, Deductions, and Net Pay in the Summary section
            txtOvertime.Text = otherIncome.ToString("N2");
            txtGrossEarnings.Text = grossIncome.ToString("N2");
            txtDeductionsSummary.Text = totalDeductions.ToString("N2"); // Assuming a different textbox name for the summary field
            txtNetPay.Text = netIncome.ToString("N2");
        }

        private void PRELIMEXAM_Lesson5Activity_PrintFrm_Load(object sender, EventArgs e)
        {
            // Disable editing of all textboxes to make them read-only
            txtEmployeeCode.Enabled = false;
            txtEmployeeName.Enabled = false;
            txtDepartment.Enabled = false;
            txtCutoff.Enabled = false;
            txtPayPeriod.Enabled = false;
            txtBasicPayDayHrs.Enabled = false;
            txtOvertimeDayHrs.Enabled = false;
            txtHonorariumDayHrs.Enabled = false;
            txtHonorariumAdjDayHrs.Enabled = false;
            txtSubstitutionDayHrs.Enabled = false;
            txtTardyDayHrs.Enabled = false;
            txtBasicPayNonTaxable.Enabled = false;
            txtOvertimeNonTaxable.Enabled = false;
            txtHonorariumNonTaxable.Enabled = false;
            txtHonorariumAdjNonTaxable.Enabled= false;
            txtSubstitutionNonTaxable.Enabled = false;
            txtTardyNonTaxable.Enabled = false;
            txtBasicPayTaxable.Enabled = false;
            txtOvertimeTaxable.Enabled = false;
            txtHonorariumTaxable.Enabled = false;
            txtHonorariumAdjTaxable.Enabled = false;
            txtSubstitutionTaxable.Enabled = false;
            txtTardyTaxable.Enabled = false;
            txtWithholdingTax.Enabled = false;
            txtSSSContribution.Enabled = false;
            txtHDMF.Enabled = false;
            txtPhilhealth.Enabled = false;
            txtSSSWISP.Enabled = false;
            txtOvertime.Enabled = false;
            txtGrossEarnings.Enabled = false;
            txtDeductionsSummary.Enabled = false;
            txtNetPay.Enabled = false;
            txtDeductions.Enabled = false;
            txtEarnings.Enabled = false;
            txtcompany.Enabled = false;
        }
    }
}
