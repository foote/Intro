using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodPractice
{
    public partial class frmMethodPractice : Form
    {
        public frmMethodPractice()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmMethodPractice_Load(object sender, EventArgs e)
        {

        }
        // #1
        public int Add(int number1, int number2, int number3)
        {
            return number1 +number2 + number3;
        }
        // #2
        public string CreateFullName(string firstname, string lastname)
        {
            return firstname + " " +lastname;
        }

        //#4
        public double CalculateCircleArea(double radius)
        {
            return Math.PI* Math.Pow(radius, 2);
        }

        // #6
        public void DoStuff(string message)
        {
            // Do Stuff
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            string strSalesAmt = "34.99";
            double salesAmount;
            double.TryParse(strSalesAmt, out salesAmount);
            //double tx = CalculateTax(salesAmount);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal decBalance;
            //bool IsSaved = SaveNumber(decBalance);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String a = "Happy";
            String b = "Holidays";
            int c = 5;
            DateTime d = new DateTime(2018, 12, 25);
            String result;
            //result = CreateMessage(a, b, c, d);

        }
    }
}
