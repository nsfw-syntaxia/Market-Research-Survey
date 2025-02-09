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
        private string fvp = "";

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

            abnf1.Tag = ab1.Tag = "1";
            abf2.Tag = ab2.Tag = "2";
            abf3.Tag = ab3.Tag = "3";
            abf4.Tag = ab4.Tag = "4";
            abf5.Tag = ab5.Tag = "5";

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
            fvp = cbxfvp.SelectedItem?.ToString() ?? "Other";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

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
