using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MarketResearchSurvey
{
    public partial class MarketResearchSurvey : Form
    {
        public MarketResearchSurvey()
        {
            InitializeComponent();
        }

        private void MarketResearchSurvey_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbxEmail;

            if (!string.IsNullOrEmpty(SurveyData.Email))
                tbxEmail.Text = SurveyData.Email;

            if (!string.IsNullOrEmpty(SurveyData.Name))
                tbxName.Text = SurveyData.Name;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text.Trim();
            string name = tbxName.Text.Trim();

            if (string.IsNullOrWhiteSpace(tbxEmail.Text) || string.IsNullOrWhiteSpace(tbxName.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!valid(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxEmail.Focus();
                return;
            }

            SurveyData.Email = email;
            SurveyData.Name = name;

            this.Hide();
            Demographic demographic = new Demographic();
            demographic.ShowDialog();
            this.Close();
        }

        private bool valid(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }
    }

    public static class SurveyData
    {
        public static string Email { get; set; }
        public static string Name { get; set; }
        public static string Gender { get; set; }
        public static string Age { get; set; }
        public static string MaritalStatus { get; set; }
        public static string Income { get; set; }
        public static string Employment { get; set; }
        public static string Education { get; set; }
        public static string FreqExercise { get; set; }
        public static string FreqUse { get; set; }
        public static string LastBuy { get; set; }
        public static string WhyBuy { get; set; }
        public static string WhereBuy { get; set; }
        public static string Design { get; set; }
        public static string Influence { get; set; }
    }
}
