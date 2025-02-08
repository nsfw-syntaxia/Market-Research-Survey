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
    public partial class Questionnaire : Form
    {
        public Questionnaire()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string freqExercise, freqUse, lastBuy;
            string whyBuy = "", whereBuy = "", design = "", influence = "";

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

            this.Hide();
            Rating rating = new Rating();
            rating.ShowDialog();
            this.Close();
        }
    }
}
