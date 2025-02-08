using System;
using System.Windows.Forms;

namespace MarketResearchSurvey
{
    public partial class MarketResearchSurvey : Form
    {
        public MarketResearchSurvey()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string name = tbxName.Text;

            Demographic demographic = new Demographic();
            demographic.ShowDialog();
        }
    }
}
