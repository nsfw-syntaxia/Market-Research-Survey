using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketResearchSurvey
{
    public partial class Demographic : Form
    {
        public Demographic()
        {
            InitializeComponent();
            rbtnMale.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!filled(grbxGender))
            {
                MessageBox.Show("Please select your gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!filled(grbxAge))
            {
                MessageBox.Show("Please select your age group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!filled(grbxStatus))
            {
                MessageBox.Show("Please select your marital status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!filled(grbxIncome))
            {
                MessageBox.Show("Please select your income range.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!filled(grbxEmployment))
            {
                MessageBox.Show("Please select your employment status.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!filled(grbxEducation))
            {
                MessageBox.Show("Please select your education level.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbtnMale.Checked)
                SurveyData.Gender = rbtnMale.Text;
            else if (rbtnFemale.Checked)
                SurveyData.Gender = rbtnFemale.Text;
            else if (rbtnNonBinary.Checked)
                SurveyData.Gender = rbtnNonBinary.Text;
            else
                SurveyData.Gender = rbtnGPNTS.Text;

            if (rbtn017.Checked)
                SurveyData.Age = rbtn017.Text;
            else if (rbtn1824.Checked)
                SurveyData.Age = rbtn1824.Text;
            else if (rbtn2534.Checked)
                SurveyData.Age = rbtn2534.Text;
            else if (rbtn3544.Checked)
                SurveyData.Age = rbtn3544.Text;
            else if (rbtn4554.Checked)
                SurveyData.Age = rbtn4554.Text;
            else if (rbtn5564.Checked)
                SurveyData.Age = rbtn5564.Text;
            else
                SurveyData.Age = rbtn65.Text;

            if (rbtnSingle.Checked)
                SurveyData.MaritalStatus = rbtnSingle.Text;
            else if (rbtnMarried.Checked)
                SurveyData.MaritalStatus = rbtnMarried.Text;
            else if (rbtnDivorced.Checked)
                SurveyData.MaritalStatus = rbtnDivorced.Text;
            else if (rbtnWidowed.Checked)
                SurveyData.MaritalStatus = rbtnWidowed.Text;
            else
                SurveyData.MaritalStatus = rbtnPNTSMS.Text;

            if (rbtn9999.Checked)
                SurveyData.Income = rbtn9999.Text;
            else if (rbtn24999.Checked)
                SurveyData.Income = rbtn24999.Text;
            else if (rbtn49999.Checked)
                SurveyData.Income = rbtn49999.Text;
            else if (rbtn74999.Checked)
                SurveyData.Income = rbtn74999.Text;
            else if (rbtn99999.Checked)
                SurveyData.Income = rbtn99999.Text;
            else if (rbtn100000.Checked)
                SurveyData.Income = rbtn100000.Text;
            else
                SurveyData.Income = rbtnPNTSAIR.Text;

            if (rbtnEFT.Checked)
                SurveyData.Employment = rbtnEFT.Text;
            else if (rbtnEPT.Checked)
                SurveyData.Employment = rbtnEPT.Text;
            else if (rbtnSE.Checked)
                SurveyData.Employment = rbtnSE.Text;
            else if (rbtnUE.Checked)
                SurveyData.Employment = rbtnUE.Text;
            else if (rbtnNLFAJ.Checked)
                SurveyData.Employment = rbtnNLFAJ.Text;
            else if (rbtnHM.Checked)
                SurveyData.Employment = rbtnHM.Text;
            else if (rbtnS.Checked)
                SurveyData.Employment = rbtnS.Text;
            else
                SurveyData.Employment = rbtnPNTSES.Text;

            if (rbtnLTHS.Checked)
                SurveyData.Education = rbtnLTHS.Text;
            else if (rbtnHS.Checked)
                SurveyData.Education = rbtnHS.Text;
            else if (rbtnSCU.Checked)
                SurveyData.Education = rbtnSCU.Text;
            else if (rbtnCDC.Checked)
                SurveyData.Education = rbtnCDC.Text;
            else if (rbtnUGD.Checked)
                SurveyData.Education = rbtnUGD.Text;
            else if (rbtnMGD.Checked)
                SurveyData.Education = rbtnMGD.Text;
            else if (rbtnD.Checked)
                SurveyData.Education = rbtnD.Text;
            else if (rbtnOHEA.Checked)
                SurveyData.Education = rbtnOHEA.Text;
            else
                SurveyData.Education = rbtnPNTSHEA.Text;

            this.Hide();
            Questionnaire questionnaire = new Questionnaire();
            questionnaire.ShowDialog();
            this.Close();
        }

        private bool filled(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Any(r => r.Checked);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarketResearchSurvey surveyForm = new MarketResearchSurvey();
            surveyForm.ShowDialog();
            this.Close();
        }
    }
}
