namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<FibonacciRow> rows = new List<FibonacciRow>();

            for (int i = 0; i < 20; i++)
            {
                //FibonacciRow r = new FibonacciRow();
                FibonacciRow r = new FibonacciRow(i, Fibonacci(i));
                r.Index = i;
                r.Value = Fibonacci(i);
                rows.Add(r);
            }
            dataGridView1.DataSource = rows;
        }
        //methodus = függvény
        int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

    }
}