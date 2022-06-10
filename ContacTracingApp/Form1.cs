namespace ContacTracingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submitbuttonclick(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Erika Zoe Sedilla\source\repos\ContacTracingApp\ContacTracingApp\test.text", true);
            file.WriteLine("Given Name: " + txtBoxGivenName.Text);
            file.WriteLine("Last Name: " + txtBoxLastName.Text);
            file.WriteLine("Phone Number: " + txtBoxPhoneNumber.Text);
            file.WriteLine("Email Address: " + txtBoxEmailAddress.Text);
            file.WriteLine("Current Address: " + txtBoxCurrentAddress.Text);
            file.WriteLine("Time of Visit: " + txtBoxCurrentAddress1.Text);
            file.WriteLine("Date: " + txtBoxTimeofVisit.Text);
            file.WriteLine("Signature: " + txtBoxDate.Text);
            file.WriteLine("Signature: " + txtBoxSignatureFPN.Text);
            file.Close();

            MessageBox.Show("Information Submitted, Thank you for your response!");

        }

        private void Cancelbuttonclick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}