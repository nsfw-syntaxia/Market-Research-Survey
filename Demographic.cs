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

        private void btnNext_Click(object sender, EventArgs e)
        {
            string gender, ageRange, marital, incomeRange, employment, education;

            if (rbtnMale.Checked)
            {
                gender = rbtnMale.Text;
            }
            else if (rbtnFemale.Checked)
            {
                gender = rbtnFemale.Text;
            }
            else if (rbtnNonBinary.Checked)
            {
                gender = rbtnNonBinary.Text;
            }
            else
            {
                gender = rbtnGPNTS.Text;
            }

            if (rbtn017.Checked)
            {
                ageRange = rbtn017.Text;
            }
            else if (rbtn1824.Checked)
            {
                ageRange = rbtn1824.Text;
            }
            else if (rbtn2534.Checked)
            {
                ageRange = rbtn2534.Text;
            }
            else if (rbtn3544.Checked)
            {
                ageRange = rbtn3544.Text;
            }
            else if (rbtn4554.Checked)
            {
                ageRange = rbtn4554.Text;
            }
            else if (rbtn5564.Checked)
            {
                ageRange = rbtn5564.Text;
            }
            else
            {
                ageRange = rbtn65.Text;
            }

            if (rbtnSingle.Checked)
            {
                marital = rbtnSingle.Text;
            }
            else if (rbtnMarried.Checked)
            {
                marital = rbtnMarried.Text;
            }
            else if (rbtnDivorced.Checked)
            {
                marital = rbtnDivorced.Text;
            }
            else if (rbtnWidowed.Checked)
            {
                marital = rbtnWidowed.Text;
            }
            else
            {
                marital = rbtnPNTSMS.Text;
            }

            if (rbtn9999.Checked)
            {
                incomeRange = rbtn9999.Text;
            }
            else if (rbtn24999.Checked)
            {
                incomeRange = rbtn24999.Text;
            }
            else if (rbtn49999.Checked)
            {
                incomeRange = rbtn49999.Text;
            }
            else if (rbtn74999.Checked)
            {
                incomeRange = rbtn74999.Text;
            }
            else if (rbtn99999.Checked)
            {
                incomeRange = rbtn99999.Text;
            }
            else if (rbtn100000.Checked)
            {
                incomeRange = rbtn100000.Text;
            }
            else
            {
                incomeRange = rbtnPNTSAIR.Text;
            }

            if (rbtnEFT.Checked)
            {
                employment = rbtnEFT.Text;
            }
            else if (rbtnEPT.Checked)
            {
                employment = rbtnEPT.Text;
            }
            else if (rbtnSE.Checked)
            {
                employment = rbtnSE.Text;
            }
            else if (rbtnUE.Checked)
            {
                employment = rbtnUE.Text;
            }
            else if (rbtnNLFAJ.Checked)
            {
                employment = rbtnNLFAJ.Text;
            }
            else if (rbtnHM.Checked)
            {
                employment = rbtnHM.Text;
            }
            else if (rbtnS.Checked)
            {
                employment = rbtnS.Text;
            }
            else
            {
                employment = rbtnPNTSES.Text;
            }

            if (rbtnLTHS.Checked)
            {
                education = rbtnLTHS.Text;
            }
            else if (rbtnHS.Checked)
            {
                education = rbtnHS.Text;
            }
            else if (rbtnSCU.Checked)
            {
                education = rbtnSCU.Text;
            }
            else if (rbtnCDC.Checked)
            {
                education = rbtnCDC.Text;
            }
            else if (rbtnUGD.Checked)
            {
                education = rbtnUGD.Text;
            }
            else if (rbtnMGD.Checked)
            {
                education = rbtnMGD.Text;
            }
            else if (rbtnD.Checked)
            {
                education = rbtnD.Text;
            }
            else if (rbtnOHEA.Checked)
            {
                education = rbtnOHEA.Text;
            }
            else
            {
                education = rbtnPNTSHEA.Text;
            }

            Questionnaire questionnaire = new Questionnaire();
            questionnaire.ShowDialog();
        }
    }
}
