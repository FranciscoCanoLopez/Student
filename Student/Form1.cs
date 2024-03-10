namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = TBName.Text;
            student.FatherLastName = TBFatherLastName.Text;
            student.MotherLastName = TBMotherLastName.Text;
            student.BirthDate = DTPBirthDate.Text;
            student.Enrollment = TBEnrollment.Text;
            student.Race = CBEngineering.Text;
            student.Average = NUDAverage.Text;

            MessageBox.Show(student.StudentInfo(""));
        }
    }
}
