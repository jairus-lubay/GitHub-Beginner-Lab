namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label studentLabel = new Label();

            studentLabel.Text = "Student Profile — Jairus Ira Levi M. Lubay";
            studentLabel.AutoSize = true;
            studentLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            studentLabel.Location = new Point(50, 50);

            this.Controls.Add(studentLabel);
            this.Text = "Student Profile";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 600;
            this.Height = 200;
        }
    }
}