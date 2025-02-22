﻿using System;
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
        List<string> whyBuy = new List<string>();
        List<string> whereBuy = new List<string>();
        List<string> design = new List<string>();
        List<string> influence = new List<string>();

        public Questionnaire()
        {
            InitializeComponent();
        }

        private void Questionnaire_Load(object sender, EventArgs e)
        {
            this.ActiveControl = grbxHODYE;

            if (SurveyData.FreqExercise == lblHODYE1.Text) rbtnEXFREQ1.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE2.Text) rbtnEXFREQ2.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE3.Text) rbtnEXFREQ3.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE4.Text) rbtnEXFREQ4.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE5.Text) rbtnEXFREQ5.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE6.Text) rbtnEXFREQ6.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE7.Text) rbtnEXFREQ7.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE8.Text) rbtnEXFREQ8.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE9.Text) rbtnEXFREQ9.Checked = true;
            else if (SurveyData.FreqExercise == lblHODYE10.Text) rbtnEXFREQ10.Checked = true;

            if (SurveyData.FreqUse == lblHODYUSP1.Text) rbtnUFREQ1.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP2.Text) rbtnUFREQ2.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP3.Text) rbtnUFREQ3.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP4.Text) rbtnUFREQ4.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP5.Text) rbtnUFREQ5.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP6.Text) rbtnUFREQ6.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP7.Text) rbtnUFREQ7.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP8.Text) rbtnUFREQ8.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP9.Text) rbtnUFREQ9.Checked = true;
            else if (SurveyData.FreqUse == lblHODYUSP10.Text) rbtnUFREQ10.Checked = true;

            if (SurveyData.LastBuy == rbtnLTAM.Text) rbtnLTAM.Checked = true;
            else if (SurveyData.LastBuy == rbtnB16M.Text) rbtnB16M.Checked = true;
            else if (SurveyData.LastBuy == rbtnB6M1Y.Text) rbtnB6M1Y.Checked = true;
            else if (SurveyData.LastBuy == rbtnMT1Y.Text) rbtnMT1Y.Checked = true;
            else if (SurveyData.LastBuy == rbtnIDNR.Text) rbtnIDNR.Checked = true;

            var whyBuySelected = (SurveyData.WhyBuy ?? "").Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var whereBuySelected = (SurveyData.WhereBuy ?? "").Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var designSelected = (SurveyData.Design ?? "").Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var influenceSelected = (SurveyData.Influence ?? "").Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            chbxGF.Checked = whyBuySelected.Contains(chbxGF.Text);
            chbxR.Checked = whyBuySelected.Contains(chbxR.Text);
            chbxH.Checked = whyBuySelected.Contains(chbxH.Text);
            chbxOF.Checked = whyBuySelected.Contains(chbxOF.Text);
            chbxS.Checked = whyBuySelected.Contains(chbxS.Text);
            chbxOWB.Checked = whyBuySelected.Contains(chbxOWB.Text);

            chbxRS.Checked = whereBuySelected.Contains(chbxRS.Text);
            chbxDS.Checked = whereBuySelected.Contains(chbxDS.Text);
            chbxMBR.Checked = whereBuySelected.Contains(chbxMBR.Text);
            chbxOnline.Checked = whereBuySelected.Contains(chbxOnline.Text);
            chbxOWBF.Checked = whereBuySelected.Contains(chbxOWBF.Text);

            chbxMinimalist.Checked = designSelected.Contains(chbxMinimalist.Text);
            chbxBCAD.Checked = designSelected.Contains(chbxBCAD.Text);
            chbxWSAPO.Checked = designSelected.Contains(chbxWSAPO.Text);
            chbxOPDS.Checked = designSelected.Contains(chbxOPDS.Text);

            chbxPrice.Checked = influenceSelected.Contains(chbxPrice.Text);
            chbxQuality.Checked = influenceSelected.Contains(chbxQuality.Text);
            chbxValue.Checked = influenceSelected.Contains(chbxValue.Text);
            chbxBrand.Checked = influenceSelected.Contains(chbxBrand.Text);
            chbxOICB.Checked = influenceSelected.Contains(chbxOICB.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!filled(grbxHODYE) || !filled(grbxHODYUSP) || !filled(grbxWDYLBAS))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!check(grbxPurpose) || !check(grbxWhere) || !check(grbxDesign) || !check(grbxInfluence))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbtnEXFREQ1.Checked)
                SurveyData.FreqExercise = lblHODYE1.Text;
            else if (rbtnEXFREQ2.Checked)
                SurveyData.FreqExercise = lblHODYE2.Text;
            else if (rbtnEXFREQ3.Checked)
                SurveyData.FreqExercise = lblHODYE3.Text;
            else if (rbtnEXFREQ4.Checked)
                SurveyData.FreqExercise = lblHODYE4.Text;
            else if (rbtnEXFREQ5.Checked)
                SurveyData.FreqExercise = lblHODYE5.Text;
            else if (rbtnEXFREQ6.Checked)
                SurveyData.FreqExercise = lblHODYE6.Text;
            else if (rbtnEXFREQ7.Checked)
                SurveyData.FreqExercise = lblHODYE7.Text;
            else if (rbtnEXFREQ8.Checked)
                SurveyData.FreqExercise = lblHODYE8.Text;
            else if (rbtnEXFREQ9.Checked)
                SurveyData.FreqExercise = lblHODYE9.Text;
            else
                SurveyData.FreqExercise = lblHODYE10.Text;

            if (rbtnUFREQ1.Checked)
                SurveyData.FreqUse = lblHODYUSP1.Text;
            else if (rbtnUFREQ2.Checked)
                SurveyData.FreqUse = lblHODYUSP2.Text;
            else if (rbtnUFREQ3.Checked)
                SurveyData.FreqUse = lblHODYUSP3.Text;
            else if (rbtnUFREQ4.Checked)
                SurveyData.FreqUse = lblHODYUSP4.Text;
            else if (rbtnUFREQ5.Checked)
                SurveyData.FreqUse = lblHODYUSP5.Text;
            else if (rbtnUFREQ6.Checked)
                SurveyData.FreqUse = lblHODYUSP6.Text;
            else if (rbtnUFREQ7.Checked)
                SurveyData.FreqUse = lblHODYUSP7.Text;
            else if (rbtnUFREQ8.Checked)
                SurveyData.FreqUse = lblHODYUSP8.Text;
            else if (rbtnUFREQ9.Checked)
                SurveyData.FreqUse = lblHODYUSP9.Text;
            else
                SurveyData.FreqUse = lblHODYUSP10.Text;

            if (rbtnLTAM.Checked)
                SurveyData.LastBuy = rbtnLTAM.Text;
            else if (rbtnB16M.Checked)
                SurveyData.LastBuy = rbtnB16M.Text;
            else if (rbtnB6M1Y.Checked)
                SurveyData.LastBuy = rbtnB6M1Y.Text;
            else if (rbtnMT1Y.Checked)
                SurveyData.LastBuy = rbtnMT1Y.Text;
            else
                SurveyData.LastBuy = rbtnIDNR.Text;

            if (chbxGF.Checked)
                whyBuy.Add(chbxGF.Text);
            if (chbxR.Checked)
                whyBuy.Add(chbxR.Text);
            if (chbxH.Checked)
                whyBuy.Add(chbxH.Text);
            if (chbxOF.Checked)
                whyBuy.Add(chbxOF.Text);
            if (chbxS.Checked)
                whyBuy.Add(chbxS.Text);
            if (chbxOWB.Checked)
                whyBuy.Add(chbxOWB.Text);

            if (chbxRS.Checked)
                whereBuy.Add(chbxRS.Text);
            if (chbxDS.Checked)
                whereBuy.Add(chbxDS.Text);
            if (chbxMBR.Checked)
                whereBuy.Add(chbxMBR.Text);
            if (chbxOnline.Checked)
                whereBuy.Add(chbxOnline.Text);
            if (chbxOWBF.Checked)
                whereBuy.Add(chbxOWBF.Text);

            if (chbxMinimalist.Checked)
                design.Add(chbxMinimalist.Text);
            if (chbxBCAD.Checked)
                design.Add(chbxBCAD.Text);
            if (chbxWSAPO.Checked)
                design.Add(chbxWSAPO.Text);
            if (chbxOPDS.Checked)
                design.Add(chbxOPDS.Text);

            if (chbxPrice.Checked)
                influence.Add(chbxPrice.Text);
            if (chbxQuality.Checked)
                influence.Add(chbxQuality.Text);
            if (chbxValue.Checked)
                influence.Add(chbxValue.Text);
            if (chbxBrand.Checked)
                influence.Add(chbxBrand.Text);
            if (chbxOICB.Checked)
                influence.Add(chbxOICB.Text);

            SurveyData.WhyBuy = string.Join(", ", whyBuy);
            SurveyData.WhereBuy = string.Join(", ", whereBuy);
            SurveyData.Design = string.Join(", ", design);
            SurveyData.Influence = string.Join(", ", influence);

            this.Hide();
            Rating rating = new Rating();
            rating.ShowDialog();
            this.Close();
        }

        private bool filled(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Any(r => r.Checked);
        }

        private bool check(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<CheckBox>().Any(ch => ch.Checked);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demographic demographic = new Demographic();
            demographic.ShowDialog();
            this.Close();
        }
    }
}
