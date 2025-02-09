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

            wrnf1.Tag = wrf1.Tag = "1";
            wrnf2.Tag = wrf2.Tag = "2";
            wrnf3.Tag = wrf3.Tag = "3";
            wrnf4.Tag = wrf4.Tag = "4";
            wrnf5.Tag = wrf5.Tag = "5";
        }

        private void WaterResistance_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int rating = int.Parse(clickedStar.Tag.ToString());
            SurveyData.WaterResistance = rating.ToString();

            stars("wr", rating);
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
