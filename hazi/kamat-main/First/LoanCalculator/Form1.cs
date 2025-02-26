namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbLoanAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal loanamount = decimal.Parse(tbLoanAmount.Text);
            decimal monthlyIntrest = decimal.Parse(tbMonthlyIntrest.Text);
            decimal monthlyPayment = decimal.Parse(tbMonthlyPayment.Text);

            decimal balance = loanamount;
            decimal totalPaid = 0;
            int month = 0;

            List<Class1> rows = new List<Class1>();

            if (((monthlyIntrest / 100m) * balance) > monthlyPayment)
            {
                tbMonthCount.Text = "hiba";
            }
            else
            {
                while (balance > 0)
                {
                    balance += (monthlyIntrest / 100m) * balance;

                    //annyit fizet amennyi marad
                    if (balance < monthlyPayment)
                    {
                        monthlyPayment = balance;
                    }


                    balance -= monthlyPayment;
                    totalPaid += monthlyPayment;
                    month++;
                    Class1 r = new Class1();
                    r.balance = balance;
                    r.month = month;
                    r.CummulatedPayment = totalPaid;
                    rows.Add(r);

                }
                tbMonthCount.Text = month.ToString();
                dataGridView1.DataSource = rows;
            }
            
        }

    }
}