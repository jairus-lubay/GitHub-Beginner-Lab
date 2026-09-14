namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label studentLabel = new Label();

            studentLabel.Text = "Student Profile — GitHub Beginner Lab";
            studentLabel.AutoSize = true;
            studentLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            studentLabel.Location = new Point(50, 50);

            this.Controls.Add(studentLabel);

            Label contactLabel = new Label();

            contactLabel.Text = "Contact Number: 09171234567";
            contactLabel.AutoSize = true;
            contactLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            contactLabel.Location = new Point(50, 100);

            this.Controls.Add(contactLabel);

            this.Text = "Student Profile";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 600;
            this.Height = 200;
        }
    }
}