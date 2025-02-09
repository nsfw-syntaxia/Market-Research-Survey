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
