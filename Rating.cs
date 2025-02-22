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
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            this.ActiveControl = grbxWaterR;

            wrnf1.Tag = wrf1.Tag = "1";
            wrnf2.Tag = wrf2.Tag = "2";
            wrnf3.Tag = wrf3.Tag = "3";
            wrnf4.Tag = wrf4.Tag = "4";
            wrnf5.Tag = wrf5.Tag = "5";

            wrnf1.Click += WaterResistance_Click;
            wrnf2.Click += WaterResistance_Click;
            wrnf3.Click += WaterResistance_Click;
            wrnf4.Click += WaterResistance_Click;
            wrnf5.Click += WaterResistance_Click;

            wrf1.Click += WaterResistance_Click;
            wrf2.Click += WaterResistance_Click;
            wrf3.Click += WaterResistance_Click;
            wrf4.Click += WaterResistance_Click;
            wrf5.Click += WaterResistance_Click;

            cnf1.Tag = cf1.Tag = "1";
            cnf2.Tag = cf2.Tag = "2";
            cnf3.Tag = cf3.Tag = "3";
            cnf4.Tag = cf4.Tag = "4";
            cnf5.Tag = cf5.Tag = "5";

            cnf1.Click += Cooling_Click;
            cnf2.Click += Cooling_Click;
            cnf3.Click += Cooling_Click;
            cnf4.Click += Cooling_Click;
            cnf5.Click += Cooling_Click;

            cf1.Click += Cooling_Click;
            cf2.Click += Cooling_Click;
            cf3.Click += Cooling_Click;
            cf4.Click += Cooling_Click;
            cf5.Click += Cooling_Click;

            abnf1.Tag = abf1.Tag = "1";
            abnf2.Tag = abf2.Tag = "2";
            abnf3.Tag = abf3.Tag = "3";
            abnf4.Tag = abf4.Tag = "4";
            abnf5.Tag = abf5.Tag = "5";

            abnf1.Click += AntiBacteria_Click;
            abnf2.Click += AntiBacteria_Click;
            abnf3.Click += AntiBacteria_Click;
            abnf4.Click += AntiBacteria_Click;
            abnf5.Click += AntiBacteria_Click;

            abf1.Click += AntiBacteria_Click;
            abf2.Click += AntiBacteria_Click;
            abf3.Click += AntiBacteria_Click;
            abf4.Click += AntiBacteria_Click;
            abf5.Click += AntiBacteria_Click;

            aonf1.Tag = aof1.Tag = "1";
            aonf2.Tag = aof2.Tag = "2";
            aonf3.Tag = aof3.Tag = "3";
            aonf4.Tag = aof4.Tag = "4";
            aonf5.Tag = aof5.Tag = "5";

            aonf1.Click += AntiOdour_Click;
            aonf2.Click += AntiOdour_Click;
            aonf3.Click += AntiOdour_Click;
            aonf4.Click += AntiOdour_Click;
            aonf5.Click += AntiOdour_Click;

            aof1.Click += AntiOdour_Click;
            aof2.Click += AntiOdour_Click;
            aof3.Click += AntiOdour_Click;
            aof4.Click += AntiOdour_Click;
            aof5.Click += AntiOdour_Click;

            ssmnf1.Tag = ssmf1.Tag = "1";
            ssmnf2.Tag = ssmf2.Tag = "2";
            ssmnf3.Tag = ssmf3.Tag = "3";
            ssmnf4.Tag = ssmf4.Tag = "4";
            ssmnf5.Tag = ssmf5.Tag = "5";

            ssmnf1.Click += SSM_Click;
            ssmnf2.Click += SSM_Click;
            ssmnf3.Click += SSM_Click;
            ssmnf4.Click += SSM_Click;
            ssmnf5.Click += SSM_Click;

            ssmf1.Click += SSM_Click;
            ssmf2.Click += SSM_Click;
            ssmf3.Click += SSM_Click;
            ssmf4.Click += SSM_Click;
            ssmf5.Click += SSM_Click;

            enf1.Tag = ef1.Tag = "1";
            enf2.Tag = ef2.Tag = "2";
            enf3.Tag = ef3.Tag = "3";
            enf4.Tag = ef4.Tag = "4";
            enf5.Tag = ef5.Tag = "5";

            enf1.Click += Elasticity_Click;
            enf2.Click += Elasticity_Click;
            enf3.Click += Elasticity_Click;
            enf4.Click += Elasticity_Click;
            enf5.Click += Elasticity_Click;

            ef1.Click += Elasticity_Click;
            ef2.Click += Elasticity_Click;
            ef3.Click += Elasticity_Click;
            ef4.Click += Elasticity_Click;
            ef5.Click += Elasticity_Click;

            endnf1.Tag = endf1.Tag = "1";
            endnf2.Tag = endf2.Tag = "2";
            endnf3.Tag = endf3.Tag = "3";
            endnf4.Tag = endf4.Tag = "4";
            endnf5.Tag = endf5.Tag = "5";

            endnf1.Click += Endurance_Click;
            endnf2.Click += Endurance_Click;
            endnf3.Click += Endurance_Click;
            endnf4.Click += Endurance_Click;
            endnf5.Click += Endurance_Click;

            endf1.Click += Endurance_Click;
            endf2.Click += Endurance_Click;
            endf3.Click += Endurance_Click;
            endf4.Click += Endurance_Click;
            endf5.Click += Endurance_Click;
        }

        private void WaterResistance_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.WaterResistance = rating.ToString();

            stars("wr", rating);
        }

        private void Cooling_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.Cooling = rating.ToString();

            stars("c", rating);
        }

        private void AntiBacteria_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.AntiBacteria = rating.ToString();

            stars("ab", rating);
        }

        private void AntiOdour_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.AntiOdour = rating.ToString();

            stars("ao", rating);
        }

        private void SSM_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.SSM = rating.ToString();

            stars("ssm", rating);
        }

        private void Elasticity_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.Elasticity = rating.ToString();

            stars("e", rating);
        }

        private void Endurance_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.Endurance = rating.ToString();

            stars("end", rating);
        }

        private void stars(string prefix, int rating)
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox filledStar = this.Controls.Find($"{prefix}f{i}", true).FirstOrDefault() as PictureBox;
                PictureBox notFilledStar = this.Controls.Find($"{prefix}nf{i}", true).FirstOrDefault() as PictureBox;

                if (filledStar != null && notFilledStar != null)
                {
                    filledStar.Visible = (i <= rating);
                    notFilledStar.Visible = (i > rating);

                    notFilledStar.BringToFront();
                }
            }
        }

        private void cbxfvp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SurveyData.Personification = cbxfvp.SelectedItem?.ToString();
        }

        private void chlbxintrs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                SurveyData.Interest = string.Join(", ", chlbxintrs.CheckedItems.Cast<string>());
            }));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SurveyData.WaterResistance) || string.IsNullOrEmpty(SurveyData.Cooling) || 
                string.IsNullOrEmpty(SurveyData.AntiBacteria) || string.IsNullOrEmpty(SurveyData.AntiOdour) || 
                string.IsNullOrEmpty(SurveyData.SSM) || string.IsNullOrEmpty(SurveyData.Elasticity) || 
                string.IsNullOrEmpty(SurveyData.Endurance) || string.IsNullOrEmpty(SurveyData.Personification) || 
                string.IsNullOrEmpty(SurveyData.Interest))
            {
                MessageBox.Show("Please complete all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string summary = "[ SUMMARY ]\n\n" +
                             $"Name: {SurveyData.Name}\n" +
                             $"Gender: {SurveyData.Gender}\n" +
                             $"Age Range: {SurveyData.Age}\n" +
                             $"Marital Status: {SurveyData.MaritalStatus}\n" +
                             $"Annual Income Range: {SurveyData.Income}\n" +
                             $"Employment Status: {SurveyData.Employment}\n" +
                             $"Highest Education Attained: {SurveyData.Education}\n\n" +
                             $"Frequency of Exercise: {SurveyData.FreqExercise}\n" +
                             $"Frequency of Product Use: {SurveyData.FreqUse}\n" +
                             $"Last Purchase: {SurveyData.LastBuy}\n" +
                             $"Purpose of Purchase: {SurveyData.WhyBuy}\n" +
                             $"Shops to Purchase: {SurveyData.WhereBuy}\n" +
                             $"Preferred Design: {SurveyData.Design}\n" +
                             $"Purchase Influence: {SurveyData.Influence}\n\n" +
                             $"Water Resistance: {SurveyData.WaterResistance}/5\n" +
                             $"Cooling: {SurveyData.Cooling}/5\n" +
                             $"Anti-Bacteria: {SurveyData.AntiBacteria}/5\n" +
                             $"Anti-Odour: {SurveyData.AntiOdour}/5\n" +
                             $"Soft and Smooth Material: {SurveyData.SSM}/5\n" +
                             $"Elasticity: {SurveyData.Elasticity}/5\n" +
                             $"Endurance: {SurveyData.Endurance}/5\n\n" +
                             $"Personification of Favorite Brand: {SurveyData.Personification}\n" +
                             $"Interests: {SurveyData.Interest}\n" +
                             $"Email: {SurveyData.Email}\n\n" +
                             "Thank you for participating!";

            MessageBox.Show($"Successfully submitted!\n\n{summary}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questionnaire questionnaire = new Questionnaire();
            questionnaire.ShowDialog();
            this.Close();
        }
    }
}
