using System;

namespace W3LabActivity_Dolera
{
    public partial class MarketResearchSurvey : Form
    {
        public MarketResearchSurvey()
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
                freqExercise = rbtnEXFREQ1.Text;
            }
            else if (rbtnEXFREQ2.Checked)
            {
                freqExercise = rbtnEXFREQ2.Text;
            }
            else if (rbtnEXFREQ3.Checked)
            {
                freqExercise = rbtnEXFREQ3.Text;
            }
            else if (rbtnEXFREQ4.Checked)
            {
                freqExercise = rbtnEXFREQ4.Text;
            }
            else if (rbtnEXFREQ5.Checked)
            {
                freqExercise = rbtnEXFREQ5.Text;
            }
            else if (rbtnEXFREQ6.Checked)
            {
                freqExercise = rbtnEXFREQ6.Text;
            }
            else if (rbtnEXFREQ7.Checked)
            {
                freqExercise = rbtnEXFREQ7.Text;
            }
            else if (rbtnEXFREQ8.Checked)
            {
                freqExercise = rbtnEXFREQ8.Text;
            }
            else if (rbtnEXFREQ9.Checked)
            {
                freqExercise = rbtnEXFREQ9.Text;
            }
            else
            {
                freqExercise = rbtnEXFREQ10.Text;
            }

            if (rbtnUFREQ1.Checked)
            {
                freqUse = rbtnUFREQ1.Text;
            }
            else if (rbtnUFREQ2.Checked)
            {
                freqUse = rbtnUFREQ2.Text;
            }
            else if (rbtnUFREQ3.Checked)
            {
                freqUse = rbtnUFREQ3.Text;
            }
            else if (rbtnUFREQ4.Checked)
            {
                freqUse = rbtnUFREQ4.Text;
            }
            else if (rbtnUFREQ5.Checked)
            {
                freqUse = rbtnUFREQ5.Text;
            }
            else if (rbtnUFREQ6.Checked)
            {
                freqUse = rbtnUFREQ6.Text;
            }
            else if (rbtnUFREQ7.Checked)
            {
                freqUse = rbtnUFREQ7.Text;
            }
            else if (rbtnUFREQ8.Checked)
            {
                freqUse = rbtnUFREQ8.Text;
            }
            else if (rbtnUFREQ9.Checked)
            {
                freqUse = rbtnUFREQ9.Text;
            }
            else
            {
                freqUse = rbtnUFREQ10.Text;
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
                waterResistance = rbtnWR1.Text;
            }
            else if (rbtnWR2.Checked)
            {
                waterResistance = rbtnWR2.Text;
            }
            else if (rbtnWR3.Checked)
            {
                waterResistance = rbtnWR3.Text;
            }
            else if (rbtnWR4.Checked)
            {
                waterResistance = rbtnWR4.Text;
            }
            else
            {
                waterResistance = rbtnWR5.Text;
            }

            if (rbtnC1.Checked)
            {
                cooling = rbtnC1.Text;
            }
            else if (rbtnC2.Checked)
            {
                cooling = rbtnC2.Text;
            }
            else if (rbtnC3.Checked)
            {
                cooling = rbtnC3.Text;
            }
            else if (rbtnC4.Checked)
            {
                cooling = rbtnC4.Text;
            }
            else
            {
                cooling = rbtnC5.Text;
            }

            if (rbtnAB1.Checked)
            {
                antibac = rbtnAB1.Text;
            }
            else if (rbtnAB2.Checked)
            {
                antibac = rbtnAB2.Text;
            }
            else if (rbtnAB3.Checked)
            {
                antibac = rbtnAB3.Text;
            }
            else if (rbtnAB4.Checked)
            {
                antibac = rbtnAB4.Text;
            }
            else
            {
                antibac = rbtnAB5.Text;
            }

            if (rbtnAO1.Checked)
            {
                antiodor = rbtnAO1.Text;
            }
            else if (rbtnAO2.Checked)
            {
                antiodor = rbtnAO2.Text;
            }
            else if (rbtnAO3.Checked)
            {
                antiodor = rbtnAO3.Text;
            }
            else if (rbtnAO4.Checked)
            {
                antiodor = rbtnAO4.Text;
            }
            else
            {
                antiodor = rbtnAO5.Text;
            }

            if (rbtnSSM1.Checked)
            {
                material = rbtnSSM1.Text;
            }
            else if (rbtnSSM2.Checked)
            {
                material = rbtnSSM2.Text;
            }
            else if (rbtnSSM3.Checked)
            {
                material = rbtnSSM3.Text;
            }
            else if (rbtnSSM4.Checked)
            {
                material = rbtnSSM4.Text;
            }
            else
            {
                material = rbtnSSM5.Text;
            }

            if (rbtnE1.Checked)
            {
                elasticity = rbtnE1.Text;
            }
            else if (rbtnE2.Checked)
            {
                elasticity = rbtnE2.Text;
            }
            else if (rbtnE3.Checked)
            {
                elasticity = rbtnE3.Text;
            }
            else if (rbtnE4.Checked)
            {
                elasticity = rbtnE4.Text;
            }
            else
            {
                elasticity = rbtnE5.Text;
            }

            if (rbtnED1.Checked)
            {
                endurance = rbtnED1.Text;
            }
            else if (rbtnED2.Checked)
            {
                endurance = rbtnED2.Text;
            }
            else if (rbtnED3.Checked)
            {
                endurance = rbtnED3.Text;
            }
            else if (rbtnED4.Checked)
            {
                endurance = rbtnED4.Text;
            }
            else
            {
                endurance = rbtnED5.Text;
            }

            string summary = $"Gender: {gender}\n" +
                     $"Age Range: {ageRange}\n" +
                     $"Marital Status: {maritalStatus}\n" +
                     $"Income Range: {incomeRange}\n" +
                     $"Employment Status: {employmentStatus}\n" +
                     $"Education: {education}\n" +
                     $"Frequency of Exercise: {freqExercise}\n" +
                     $"Frequency of Product Use: {freqUse}\n" +
                     $"Last Purchase: {lastBuy}\n" +
                     $"Water Resistance: {waterResistance}\n" +
                     $"Cooling: {cooling}\n" +
                     $"Antibacterial: {antibac}\n" +
                     $"Anti-odor: {antiodor}\n" +
                     $"Material: {material}\n" +
                     $"Elasticity: {elasticity}\n" +
                     $"Endurance: {endurance}\n" +
                     $"Why Purchase: {whyBuy}\n" +
                     $"Where Purchase: {whereBuy}\n" +
                     $"Design: {design}\n" +
                     $"Influence: {influence}";

            MessageBox.Show($"Successfully submitted!\n\n{summary}", "Submission Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxfvp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fvp;

            fvp = cbxfvp.SelectedItem?.ToString() ?? "None";
        }

        private void survey_Enter(object sender, EventArgs e)
        {

        }
    }
}
