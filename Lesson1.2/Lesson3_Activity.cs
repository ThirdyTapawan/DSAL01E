using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1._2
{
    public partial class Lesson3_Activity : Form
    {
        // Define fixed fees as constants
        private const decimal LECTURE_FEE = 1500.00m;
        private const decimal LABORATORY_FEE = 2500.00m;
        private const decimal CISCO_LAB_FEE = 4500.00m;
        private const decimal EXAM_BOOKLET_FEE = 450.00m;
        private const decimal SAP_FEE = 2000.00m;
        private const decimal DOWNPAYMENT_AMOUNT = 8000.00m;

        // Arrays to hold all TextBox controls for easier clearing and calculation
        private TextBox[] lecUnitsTextBoxes;
        private TextBox[] labUnitsTextBoxes;
        private TextBox[] credUnitsTextBoxes;
        private TextBox[] allStudentInfoTextBoxes;
        private TextBox[] allScheduleTextBoxes;
        private CultureInfo culture = new CultureInfo("en-PH");

        public Lesson3_Activity()
        {
            InitializeComponent();
            // Initialize arrays with the controls
            lecUnitsTextBoxes = new TextBox[] { LecUnitsTextBox1, LecUnitsTextBox2, LecUnitsTextBox3, LecUnitsTextBox4, LecUnitsTextBox5, LecUnitsTextBox6, LecUnitsTextBox7 };
            labUnitsTextBoxes = new TextBox[] { LabUnitsTextBox1, LabUnitsTextBox2, LabUnitsTextBox3, LabUnitsTextBox4, LabUnitsTextBox5, LabUnitsTextBox6, LabUnitsTextBox7 };
            credUnitsTextBoxes = new TextBox[] { CredUnitsTextBox1, CredUnitsTextBox2, CredUnitsTextBox3, CredUnitsTextBox4, CredUnitsTextBox5, CredUnitsTextBox6, CredUnitsTextBox7 };

            // Assuming your Student Information text boxes are named:
            // StudentNameTextBox, StudentNoTextBox
            allStudentInfoTextBoxes = new TextBox[] { StudentNameTextBox, StudentNoTextBox };

            // Assuming your Schedule of Courses text boxes are named:
            // CourseCodeTextBox1 to 7, SectionTextBox1 to 7, DescriptionTextBox1 to 7, 
            // LecUnitsTextBox1 to 7, LabUnitsTextBox1 to 7, CredUnitsTextBox1 to 7,
            // TimeTextBox1 to 7, DayTextBox1 to 7, RoomTextBox1 to 7
            allScheduleTextBoxes = new TextBox[]
            {
                    CourseCodeTextBox1, CourseCodeTextBox2, CourseCodeTextBox3, CourseCodeTextBox4, CourseCodeTextBox5, CourseCodeTextBox6, CourseCodeTextBox7,
                    SectionTextBox1, SectionTextBox2, SectionTextBox3, SectionTextBox4, SectionTextBox5, SectionTextBox6, SectionTextBox7,
                    DescriptionTextBox1, DescriptionTextBox2, DescriptionTextBox3, DescriptionTextBox4, DescriptionTextBox5, DescriptionTextBox6, DescriptionTextBox7,
                    LecUnitsTextBox1, LecUnitsTextBox2, LecUnitsTextBox3, LecUnitsTextBox4, LecUnitsTextBox5, LecUnitsTextBox6, LecUnitsTextBox7,
                    LabUnitsTextBox1, LabUnitsTextBox2, LabUnitsTextBox3, LabUnitsTextBox4, LabUnitsTextBox5, LabUnitsTextBox6, LabUnitsTextBox7,
                    CredUnitsTextBox1, CredUnitsTextBox2, CredUnitsTextBox3, CredUnitsTextBox4, CredUnitsTextBox5, CredUnitsTextBox6, CredUnitsTextBox7,
                    TimeTextBox1, TimeTextBox2, TimeTextBox3, TimeTextBox4, TimeTextBox5, TimeTextBox6, TimeTextBox7,
                    DayTextBox1, DayTextBox2, DayTextBox3, DayTextBox4, DayTextBox5, DayTextBox6, DayTextBox7,
                    RoomTextBox1, RoomTextBox2, RoomTextBox3, RoomTextBox4, RoomTextBox5, RoomTextBox6, RoomTextBox7,
            };

            // Dedicated space for codes that disable textboxes
            // Disable all credit unit text boxes on form load to prevent user input
            foreach (var textBox in credUnitsTextBoxes)
            {
                textBox.ReadOnly = true;
            }

            // a. Assign items to the Program ComboBox
            ProgramComboBox.Items.Add("BS Information Technology");
            ProgramComboBox.Items.Add("BS Computer Engineering");
            ProgramComboBox.Items.Add("BS Electrical Engineering");
            ProgramComboBox.Items.Add("BS Computer Science");
            ProgramComboBox.Items.Add("BS Mechanical Engineering");
            ProgramComboBox.Items.Add("BS Industrial Engineering");

            // Assign items to the Year Level ComboBox
            YearLevelComboBox.Items.Add("1st Year");
            YearLevelComboBox.Items.Add("2nd Year");
            YearLevelComboBox.Items.Add("3rd Year");
            YearLevelComboBox.Items.Add("4th Year");

            // Assign items to the Mode ComboBox
            ModeComboBox.Items.Add("Regular");
            ModeComboBox.Items.Add("Irregular");

            // Assign items to the Scholar ComboBox
            ScholarComboBox.Items.Add("Yes");
            ScholarComboBox.Items.Add("No");
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // b. & c. Calculate Credit Units and Total Credit Units
                decimal totalCredUnits = 0.00m;
                decimal totalLecUnits = 0.00m;
                decimal totalLabUnits = 0.00m;

                for (int i = 0; i < 7; i++)
                {
                    // Calculate individual credit units (Lec + Lab)
                    if (decimal.TryParse(lecUnitsTextBoxes[i].Text, out decimal lecUnits) &&
                        decimal.TryParse(labUnitsTextBoxes[i].Text, out decimal labUnits))
                    {
                        decimal credUnits = lecUnits + labUnits;
                        credUnitsTextBoxes[i].Text = credUnits.ToString("N2");
                        totalCredUnits += credUnits;
                        totalLecUnits += lecUnits;
                        totalLabUnits += labUnits;
                    }
                    else
                    {
                        credUnitsTextBoxes[i].Text = "0.00";
                    }
                }
                TotalCredUnitsTextBox.Text = totalCredUnits.ToString("N2");

                // Calculate all fees and installments

                // Total Tuition Fee
                decimal totalTuitionFee = totalLecUnits * LECTURE_FEE;
                TotalTuitionFeeTextBox.Text = totalTuitionFee.ToString("C", culture);

                // Computer Laboratory Fee
                decimal comLabFee = totalLabUnits * LABORATORY_FEE;
                ComLabFeeTextBox.Text = comLabFee.ToString("C", culture);

                // Other fixed fees (for display)
                CISCOLabFeeTextBox.Text = CISCO_LAB_FEE.ToString("C", culture);
                SAPFeeTextBox.Text = SAP_FEE.ToString("C", culture);
                ExamBookletFeeTextBox.Text = EXAM_BOOKLET_FEE.ToString("C", culture);

                // Total Other Fees
                decimal totalOtherFees = comLabFee + CISCO_LAB_FEE + SAP_FEE + EXAM_BOOKLET_FEE;
                TotalOthFeeTextBox.Text = totalOtherFees.ToString("C", culture);
                MiscellaneousFeesTextBox.Text = totalOtherFees.ToString("C", culture);

                // Total Tuition and Fees
                decimal totalTuitionAndFees = totalTuitionFee + totalOtherFees;

                // Apply 20% discount if the student is a scholar
                decimal discount = 0.00m;
                if (ScholarComboBox.SelectedItem != null && ScholarComboBox.SelectedItem.ToString() == "Yes")
                {
                    discount = totalTuitionAndFees * 0.20m;
                    totalTuitionAndFees -= discount;
                }
                // Display the calculated discount
                DiscountTextBox.Text = discount.ToString("C", culture);
                // Display the final total tuition and fees after discount
                TotalTuitionAndFeesTextBox.Text = totalTuitionAndFees.ToString("C", culture);

                // Installment calculations
                DownpaymentTextBox.Text = DOWNPAYMENT_AMOUNT.ToString("C", culture);
                decimal remainingBalance = totalTuitionAndFees - DOWNPAYMENT_AMOUNT;
                decimal installmentAmount = remainingBalance / 3;
                FirstInstallmentTextBox.Text = installmentAmount.ToString("C", culture);
                SecondInstallmentTextBox.Text = installmentAmount.ToString("C", culture);
                ThirdInstallmentTextBox.Text = installmentAmount.ToString("C", culture);

                // Amount Due and Grand Total
                // Set the amount due to the 1st installment
                AmountDueTextBox.Text = installmentAmount.ToString("C", culture);
                // Grand total is the sum of all three installments
                GrandTotalTextBox.Text = (installmentAmount * 3).ToString("C", culture);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearstudentinfoBtn_Click(object sender, EventArgs e)
        {
            foreach (var textBox in allStudentInfoTextBoxes)
            {
                textBox.Clear();
            }
            // Clear other related controls
            ProgramComboBox.SelectedIndex = -1;
            YearLevelComboBox.SelectedIndex = -1;
            ModeComboBox.SelectedIndex = -1;
            ScholarComboBox.SelectedIndex = -1;
            // Clear all schedule of courses text boxes
            foreach (var textBox in allScheduleTextBoxes)
            {
                textBox.Clear();
            }
            TotalCredUnitsTextBox.Clear();
        }

        private void clearscheduleBtn_Click(object sender, EventArgs e)
        {
            // Clear only the schedule text boxes
            foreach (var textBox in allScheduleTextBoxes)
            {
                textBox.Clear();
            }
            TotalCredUnitsTextBox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Lesson3_ActivityPrintFrm printForm = new Lesson3_ActivityPrintFrm();
            printForm.Enrollment_Reciept.Items.AddRange(this.Enrollment_Reciept.Items);
            printForm.Show();
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            Enrollment_Reciept.Items.Clear();

            // Student Info
            Enrollment_Reciept.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Enrollment_Reciept.Items.Add("STUDENT INFORMATION");
            Enrollment_Reciept.Items.Add("");
            Enrollment_Reciept.Items.Add("Name: " + StudentNameTextBox.Text);
            Enrollment_Reciept.Items.Add("Student No.: " + StudentNoTextBox.Text);
            Enrollment_Reciept.Items.Add("Program: " + ProgramComboBox.SelectedItem?.ToString());
            Enrollment_Reciept.Items.Add("Year Level: " + YearLevelComboBox.SelectedItem?.ToString());
            Enrollment_Reciept.Items.Add("Date Enrolled: " + DateEnrolledPicker.Value.ToShortDateString());
            Enrollment_Reciept.Items.Add("Scholar: " + ScholarComboBox.SelectedItem?.ToString());
            Enrollment_Reciept.Items.Add("Mode: " + ModeComboBox.SelectedItem?.ToString());
            Enrollment_Reciept.Items.Add("");

            // Course Schedule
            Enrollment_Reciept.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Enrollment_Reciept.Items.Add("COURSE SCHEDULE");
            Enrollment_Reciept.Items.Add("");
            Enrollment_Reciept.Items.Add(CourseCodeTextBox1.Text + " - " + DescriptionTextBox1.Text + " - " + TimeTextBox1.Text + " - " + DayTextBox1.Text + " - " + RoomTextBox1);
            Enrollment_Reciept.Items.Add(CourseCodeTextBox2.Text + " - " + DescriptionTextBox2.Text + " - " + TimeTextBox2.Text + " - " + DayTextBox2.Text + " - " + RoomTextBox2);
            Enrollment_Reciept.Items.Add(CourseCodeTextBox3.Text + " - " + DescriptionTextBox3.Text + " - " + TimeTextBox3.Text + " - " + DayTextBox3.Text + " - " + RoomTextBox3);
            Enrollment_Reciept.Items.Add(CourseCodeTextBox4.Text + " - " + DescriptionTextBox4.Text + " - " + TimeTextBox4.Text + " - " + DayTextBox4.Text + " - " + RoomTextBox4);
            Enrollment_Reciept.Items.Add(CourseCodeTextBox5.Text + " - " + DescriptionTextBox5.Text + " - " + TimeTextBox5.Text + " - " + DayTextBox5.Text + " - " + RoomTextBox5);
            Enrollment_Reciept.Items.Add(CourseCodeTextBox6.Text + " - " + DescriptionTextBox6.Text + " - " + TimeTextBox6.Text + " - " + DayTextBox6.Text + " - " + RoomTextBox6);
            Enrollment_Reciept.Items.Add(CourseCodeTextBox7.Text + " - " + DescriptionTextBox7.Text + " - " + TimeTextBox7.Text + " - " + DayTextBox7.Text + " - " + RoomTextBox7);
            Enrollment_Reciept.Items.Add("");

            // Fees
            Enrollment_Reciept.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Enrollment_Reciept.Items.Add("TUITION & FEES");
            Enrollment_Reciept.Items.Add("");
            Enrollment_Reciept.Items.Add("Total Cred. Units: " + TotalCredUnitsTextBox.Text);
            Enrollment_Reciept.Items.Add("Tuition Fee: " + TotalTuitionFeeTextBox.Text);
            Enrollment_Reciept.Items.Add("Miscellaneous Fees: " + MiscellaneousFeesTextBox.Text);
            Enrollment_Reciept.Items.Add("Com. Lab. Fee: " + ComLabFeeTextBox.Text);
            Enrollment_Reciept.Items.Add("SAP Fee: " + SAPFeeTextBox.Text);
            Enrollment_Reciept.Items.Add("CISCO Lab Fee: " + CISCOLabFeeTextBox.Text);
            Enrollment_Reciept.Items.Add("Exam Booklet Fee: " + ExamBookletFeeTextBox.Text);
            Enrollment_Reciept.Items.Add("Other Fees: " + TotalOthFeeTextBox.Text);
            Enrollment_Reciept.Items.Add("");


            Enrollment_Reciept.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Enrollment_Reciept.Items.Add("TOTAL TUITION AND FEES");
            Enrollment_Reciept.Items.Add("");
            Enrollment_Reciept.Items.Add("Discount: " + DiscountTextBox.Text);
            Enrollment_Reciept.Items.Add("Amount Due: " + AmountDueTextBox.Text);
            Enrollment_Reciept.Items.Add("GRAND TOTAL: " + GrandTotalTextBox.Text);
            Enrollment_Reciept.Items.Add("");

            // Payment Schedule
            Enrollment_Reciept.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Enrollment_Reciept.Items.Add("PAYMENT SCHEDULE");
            Enrollment_Reciept.Items.Add("");
            Enrollment_Reciept.Items.Add("Downpayment: " + DownpaymentTextBox.Text);
            Enrollment_Reciept.Items.Add("1st Installment: " + FirstInstallmentTextBox.Text);
            Enrollment_Reciept.Items.Add("2nd Installment: " + SecondInstallmentTextBox.Text);
            Enrollment_Reciept.Items.Add("3rd Installment: " + ThirdInstallmentTextBox.Text);
            Enrollment_Reciept.Items.Add("");

            Enrollment_Reciept.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            // Footer
            Enrollment_Reciept.Items.Add("Thank you for enrolling!");
            Enrollment_Reciept.Items.Add("Please keep this receipt for your records.");
        }

        private void Lesson3_Activity_Load(object sender, EventArgs e)
        {
            TotalCredUnitsTextBox.Enabled = false;
            TotalTuitionFeeTextBox.Enabled = false;
            ComLabFeeTextBox.Enabled = false;
            CISCOLabFeeTextBox.Enabled = false;
            SAPFeeTextBox.Enabled = false;
            ExamBookletFeeTextBox.Enabled = false;
            TotalOthFeeTextBox.Enabled = false;
            TotalTuitionAndFeesTextBox.Enabled = false;
            DiscountTextBox.Enabled = false;
            DownpaymentTextBox.Enabled = false;
            FirstInstallmentTextBox.Enabled = false;
            SecondInstallmentTextBox.Enabled = false;
            ThirdInstallmentTextBox.Enabled = false;
            AmountDueTextBox.Enabled = false;
            GrandTotalTextBox.Enabled = false;
            Enrollment_Reciept.Enabled = false;
            CredUnitsTextBox1.Enabled = false;
            CredUnitsTextBox2.Enabled = false;
            CredUnitsTextBox3.Enabled = false;
            CredUnitsTextBox4.Enabled = false;
            CredUnitsTextBox5.Enabled = false;
            CredUnitsTextBox6.Enabled = false;
            CredUnitsTextBox7.Enabled = false;
            MiscellaneousFeesTextBox.Enabled = false;
        }
    }
}
