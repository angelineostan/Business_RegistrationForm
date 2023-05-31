using System.Windows.Forms.VisualStyles;

namespace Business_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please confirm your information. Is it Correct?" + Environment.NewLine +
                "Citizenship: " + citizenship.Text + Environment.NewLine + 
                "You are: " + givenName.Text + " " + middleName.Text + " " + surName.Text + " " + suffix.Text + Environment.NewLine +
                "Date of Birth: " + birthDate.Text + Environment.NewLine +
                "Civil Status: " + civilStatus.Text + Environment.NewLine +
                "Gender: " + gender.Text, "Business Registration", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
            MessageBox.Show("Again, is it correct?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}