using System;

namespace MRS_Dolera
{
    public partial class MRS_Dolera : Form
    {
        private string fvp = "None";

        public MRS_Dolera()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender, ageRange, maritalStatus, incomeRange, employmentStatus;
            string education, freqExercise, freqUse, lastBuy, waterResistance, cooling;
            string antibac, antiodor, material, elasticity, endurance;
            string whyBuy = "", whereBuy = "", design = "", influence = "";

            string email = tbxEmail.Text;

            if (rbtnMale.Checked)
            {
                gender = rbtnMale.Text;
            }
            else if (rbtnFemale.Checked)
            {
                gender = rbtnFemale.Text;
            }
            else
            {
                gender = rbtnNonBinary.Text;
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
                maritalStatus = rbtnSingle.Text;
            }
            else if (rbtnMarried.Checked)
            {
                maritalStatus = rbtnMarried.Text;
            }
            else if (rbtnDivorced.Checked)
            {
                maritalStatus = rbtnDivorced.Text;
            }
            else if (rbtnWidowed.Checked)
            {
                maritalStatus = rbtnWidowed.Text;
            }
            else
            {
                maritalStatus = rbtnPNTSMS.Text;
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
                employmentStatus = rbtnEFT.Text;
            }
            else if (rbtnEPT.Checked)
            {
                employmentStatus = rbtnEPT.Text;
            }
            else if (rbtnSE.Checked)
            {
                employmentStatus = rbtnSE.Text;
            }
            else if (rbtnUE.Checked)
            {
                employmentStatus = rbtnUE.Text;
            }
            else if (rbtnNLFAJ.Checked)
            {
                employmentStatus = rbtnNLFAJ.Text;
            }
            else if (rbtnHM.Checked)
            {
                employmentStatus = rbtnHM.Text;
            }
            else if (rbtnS.Checked)
            {
                employmentStatus = rbtnS.Text;
            }
            else
            {
                employmentStatus = rbtnPNTSES.Text;
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

            if (rbtnEXFREQ1.Checked)
            {
                freqExercise = "1";
            }
            else if (rbtnEXFREQ2.Checked)
            {
                freqExercise = "2";
            }
            else if (rbtnEXFREQ3.Checked)
            {
                freqExercise = "3";
            }
            else if (rbtnEXFREQ4.Checked)
            {
                freqExercise = "4";
            }
            else if (rbtnEXFREQ5.Checked)
            {
                freqExercise = "5";
            }
            else if (rbtnEXFREQ6.Checked)
            {
                freqExercise = "6";
            }
            else if (rbtnEXFREQ7.Checked)
            {
                freqExercise = "7";
            }
            else if (rbtnEXFREQ8.Checked)
            {
                freqExercise = "8";
            }
            else if (rbtnEXFREQ9.Checked)
            {
                freqExercise = "9";
            }
            else
            {
                freqExercise = "10";
            }

            if (rbtnUFREQ1.Checked)
            {
                freqUse = "1";
            }
            else if (rbtnUFREQ2.Checked)
            {
                freqUse = "2";
            }
            else if (rbtnUFREQ3.Checked)
            {
                freqUse = "3";
            }
            else if (rbtnUFREQ4.Checked)
            {
                freqUse = "4";
            }
            else if (rbtnUFREQ5.Checked)
            {
                freqUse = "5";
            }
            else if (rbtnUFREQ6.Checked)
            {
                freqUse = "6";
            }
            else if (rbtnUFREQ7.Checked)
            {
                freqUse = "7";
            }
            else if (rbtnUFREQ8.Checked)
            {
                freqUse = "8";
            }
            else if (rbtnUFREQ9.Checked)
            {
                freqUse = "9";
            }
            else
            {
                freqUse = "10";
            }

            if (rbtnLTAM.Checked)
            {
                lastBuy = rbtnLTAM.Text;
            }
            else if (rbtnB16M.Checked)
            {
                lastBuy = rbtnB16M.Text;
            }
            else if (rbtnB6M1Y.Checked)
            {
                lastBuy = rbtnB6M1Y.Text;
            }
            else if (rbtnMT1Y.Checked)
            {
                lastBuy = rbtnMT1Y.Text;
            }
            else
            {
                lastBuy = rbtnIDNR.Text;
            }

            if (chbxGF.Checked == true)
            {
                whyBuy = whyBuy + " " + chbxGF.Text;
            }
            if (chbxR.Checked == true)
            {
                whyBuy = whyBuy + " " + chbxR.Text;
            }
            if (chbxH.Checked == true)
            {
                whyBuy = whyBuy + " " + chbxH.Text;
            }
            if (chbxOF.Checked == true)
            {
                whyBuy = whyBuy + " " + chbxOF.Text;
            }
            if (chbxS.Checked == true)
            {
                whyBuy = whyBuy + " " + chbxS.Text;
            }
            if (chbxOWB.Checked == true)
            {
                whyBuy = whyBuy + " " + chbxOWB.Text;
            }

            if (chbxRS.Checked == true)
            {
                whereBuy = whereBuy + " " + chbxRS.Text;
            }
            if (chbxDS.Checked == true)
            {
                whereBuy = whereBuy + " " + chbxDS.Text;
            }
            if (chbxMBR.Checked == true)
            {
                whereBuy = whereBuy + " " + chbxMBR.Text;
            }
            if (chbxOnline.Checked == true)
            {
                whereBuy = whereBuy + " " + chbxOnline.Text;
            }
            if (chbxOWBF.Checked == true)
            {
                whereBuy = whereBuy + " " + chbxOWBF.Text;
            }

            if (chbxMinimalist.Checked == true)
            {
                design = design + " " + chbxMinimalist.Text;
            }
            if (chbxBCAD.Checked == true)
            {
                design = design + " " + chbxBCAD.Text;
            }
            if (chbxWSAPO.Checked == true)
            {
                design = design + " " + chbxWSAPO.Text;
            }
            if (chbxOPDS.Checked == true)
            {
                design = design + " " + chbxOPDS.Text;
            }

            if (chbxPrice.Checked == true)
            {
                influence = influence + " " + chbxPrice.Text;
            }
            if (chbxQuality.Checked == true)
            {
                influence = influence + " " + chbxQuality.Text;
            }
            if (chbxValue.Checked == true)
            {
                influence = influence + " " + chbxValue.Text;
            }
            if (chbxBrand.Checked == true)
            {
                influence = influence + " " + chbxBrand.Text;
            }
            if (chbxOICB.Checked == true)
            {
                influence = influence + " " + chbxOICB.Text;
            }

            if (rbtnWR1.Checked)
            {
                waterResistance = "1";
            }
            else if (rbtnWR2.Checked)
            {
                waterResistance = "2";
            }
            else if (rbtnWR3.Checked)
            {
                waterResistance = "3";
            }
            else if (rbtnWR4.Checked)
            {
                waterResistance = "4";
            }
            else
            {
                waterResistance = "5";
            }

            if (rbtnC1.Checked)
            {
                cooling = "1";
            }
            else if (rbtnC2.Checked)
            {
                cooling = "2";
            }
            else if (rbtnC3.Checked)
            {
                cooling = "3";
            }
            else if (rbtnC4.Checked)
            {
                cooling = "4";
            }
            else
            {
                cooling = "5";
            }

            if (rbtnAB1.Checked)
            {
                antibac = "1";
            }
            else if (rbtnAB2.Checked)
            {
                antibac = "2";
            }
            else if (rbtnAB3.Checked)
            {
                antibac = "3";
            }
            else if (rbtnAB4.Checked)
            {
                antibac = "4";
            }
            else
            {
                antibac = "5";
            }

            if (rbtnAO1.Checked)
            {
                antiodor = "1";
            }
            else if (rbtnAO2.Checked)
            {
                antiodor = "2";
            }
            else if (rbtnAO3.Checked)
            {
                antiodor = "3";
            }
            else if (rbtnAO4.Checked)
            {
                antiodor = "4";
            }
            else
            {
                antiodor = "5";
            }

            if (rbtnSSM1.Checked)
            {
                material = "1";
            }
            else if (rbtnSSM2.Checked)
            {
                material = "2";
            }
            else if (rbtnSSM3.Checked)
            {
                material = "3";
            }
            else if (rbtnSSM4.Checked)
            {
                material = "4";
            }
            else
            {
                material = "5";
            }

            if (rbtnE1.Checked)
            {
                elasticity = "1";
            }
            else if (rbtnE2.Checked)
            {
                elasticity = "2";
            }
            else if (rbtnE3.Checked)
            {
                elasticity = "3";
            }
            else if (rbtnE4.Checked)
            {
                elasticity = "4";
            }
            else
            {
                elasticity = "5";
            }

            if (rbtnED1.Checked)
            {
                endurance = "1";
            }
            else if (rbtnED2.Checked)
            {
                endurance = "2";
            }
            else if (rbtnED3.Checked)
            {
                endurance = "3";
            }
            else if (rbtnED4.Checked)
            {
                endurance = "4";
            }
            else
            {
                endurance = "5";
            }

            string summary = $"Gender: {gender}\n" +
                             $"Age Range: {ageRange}\n" +
                             $"Marital Status: {maritalStatus}\n" +
                             $"Income Range: {incomeRange}\n" +
                             $"Employment Status: {employmentStatus}\n" +
                             $"Education: {education}\n\n" +
                             $"Frequency of Exercise: {freqExercise}\n" +
                             $"Frequency of Product Use: {freqUse}\n\n" +
                             $"Last Purchase: {lastBuy}\n" +
                             $"Purpose/s of Purchase: {whyBuy}\n" +
                             $"Place/s to Purchase: {whereBuy}\n" +
                             $"Preferred Design/s: {design}\n" +
                             $"Influence/s: {influence}\n\n" +
                             $"Water Resistance: {waterResistance}\n" +
                             $"Cooling: {cooling}\n" +
                             $"Antibacterial: {antibac}\n" +
                             $"Anti-odor: {antiodor}\n" +
                             $"Material: {material}\n" +
                             $"Elasticity: {elasticity}\n" +
                             $"Endurance: {endurance}\n\n" +
                             $"Sports Brand Personification: {fvp}\n" +
                             $"Email Address: {email}";

            MessageBox.Show($"Successfully submitted!\n\n{summary}", "Submission Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxfvp_SelectedIndexChanged(object sender, EventArgs e)
        {
            fvp = cbxfvp.SelectedItem?.ToString() ?? "None";
        }

        private void survey_Enter(object sender, EventArgs e)
        {

        }
    }
}
