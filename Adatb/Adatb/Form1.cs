using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatb
{

    public partial class Form1 : Form
    {
        BindingList<countries_data> countryList = new BindingList<countries_data>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("countries.csv");
            //GetCultureInfo("HU-hu")
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<countries_data>();
            foreach (var record in tomb)
            {
                countryList.Add(record);
            }
            countriesdataBindingSource.DataSource = countryList;
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //f2.Show();
           
            if (countriesdataBindingSource.Current == null)
            {
                return;
            }
            f2.My_countries_Data = countriesdataBindingSource.Current as countries_data;
            f2.ShowDialog();
        }
    }
}