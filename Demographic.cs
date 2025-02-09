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
        }

        private void Demographic_Load(object sender, EventArgs e)
        {
            this.ActiveControl = grbxGender;

            if (SurveyData.Gender == rbtnMale.Text) rbtnMale.Checked = true;
            else if (SurveyData.Gender == rbtnFemale.Text) rbtnFemale.Checked = true;
            else if (SurveyData.Gender == rbtnNonBinary.Text) rbtnNonBinary.Checked = true;
            else if (SurveyData.Gender == rbtnGPNTS.Text) rbtnGPNTS.Checked = true;

            if (SurveyData.Age == rbtn017.Text) rbtn017.Checked = true;
            else if (SurveyData.Age == rbtn1824.Text) rbtn1824.Checked = true;
            else if (SurveyData.Age == rbtn2534.Text) rbtn2534.Checked = true;
            else if (SurveyData.Age == rbtn3544.Text) rbtn3544.Checked = true;
            else if (SurveyData.Age == rbtn4554.Text) rbtn4554.Checked = true;
            else if (SurveyData.Age == rbtn5564.Text) rbtn5564.Checked = true;
            else if (SurveyData.Age == rbtn65.Text) rbtn65.Checked = true;


            if (SurveyData.MaritalStatus == rbtnSingle.Text) rbtnSingle.Checked = true;
            else if (SurveyData.MaritalStatus == rbtnMarried.Text) rbtnMarried.Checked = true;
            else if (SurveyData.MaritalStatus == rbtnDivorced.Text) rbtnDivorced.Checked = true;
            else if (SurveyData.MaritalStatus == rbtnWidowed.Text) rbtnWidowed.Checked = true;
            else if (SurveyData.MaritalStatus == rbtnPNTSMS.Text) rbtnPNTSMS.Checked = true;

            if (SurveyData.Income == rbtn9999.Text) rbtn9999.Checked = true;
            else if (SurveyData.Income == rbtn24999.Text) rbtn24999.Checked = true;
            else if (SurveyData.Income == rbtn49999.Text) rbtn49999.Checked = true;
            else if (SurveyData.Income == rbtn74999.Text) rbtn74999.Checked = true;
            else if (SurveyData.Income == rbtn99999.Text) rbtn99999.Checked = true;
            else if (SurveyData.Income == rbtn100000.Text) rbtn100000.Checked = true;
            else if (SurveyData.Income == rbtnPNTSAIR.Text) rbtnPNTSAIR.Checked = true;

            if (SurveyData.Employment == rbtnEFT.Text) rbtnEFT.Checked = true;
            else if (SurveyData.Employment == rbtnEPT.Text) rbtnEPT.Checked = true;
            else if (SurveyData.Employment == rbtnSE.Text) rbtnSE.Checked = true;
            else if (SurveyData.Employment == rbtnUE.Text) rbtnUE.Checked = true;
            else if (SurveyData.Employment == rbtnNLFAJ.Text) rbtnNLFAJ.Checked = true;
            else if (SurveyData.Employment == rbtnHM.Text) rbtnHM.Checked = true;
            else if (SurveyData.Employment == rbtnS.Text) rbtnS.Checked = true;
            else if (SurveyData.Employment == rbtnPNTSES.Text) rbtnPNTSES.Checked = true;

            if (SurveyData.Education == rbtnLTHS.Text) rbtnLTHS.Checked = true;
            else if (SurveyData.Education == rbtnHS.Text) rbtnHS.Checked = true;
            else if (SurveyData.Education == rbtnSCU.Text) rbtnSCU.Checked = true;
            else if (SurveyData.Education == rbtnCDC.Text) rbtnCDC.Checked = true;
            else if (SurveyData.Education == rbtnUGD.Text) rbtnUGD.Checked = true;
            else if (SurveyData.Education == rbtnMGD.Text) rbtnMGD.Checked = true;
            else if (SurveyData.Education == rbtnD.Text) rbtnD.Checked = true;
            else if (SurveyData.Education == rbtnOHEA.Text) rbtnOHEA.Checked = true;
            else if (SurveyData.Education == rbtnPNTSHEA.Text) rbtnPNTSHEA.Checked = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!filled(grbxGender) || !filled(grbxAge) || !filled(grbxStatus) || !filled(grbxIncome) || !filled(grbxEmployment) || !filled(grbxEducation))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
