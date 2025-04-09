using Adatbkulso.Models;

namespace Adatbkulso
{
    public partial class Form1 : Form
    {
        Models.StudentContext context = new Models.StudentContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Models.StudentContext context = new();
            //dataGridView1.DataSource = context.Students.ToList();
            studentBindingSource.DataSource = context.Students.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var studentsFiltered = (from x in context.Students
                                    where x.Name.Contains(textBox4.Text)
                                    select x
                                    );
            //kviri?
            var stundentsOrdered = (from x in studentsFiltered
                                    orderby x.Name descending
                                    select x
                                    );
            //studentBindingSource.DataSource = studentsFiltered.ToList();
            studentBindingSource.DataSource = stundentsOrdered.ToList();

        }
    }
}