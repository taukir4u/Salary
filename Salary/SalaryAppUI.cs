using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class SalaryAppUI : Form
    {
        public SalaryAppUI()
        {
            InitializeComponent();
        }

        private int salary;
        private double totalsalary;

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            salary = Convert.ToInt32(employeeTextBox.Text);
            {
               if (salary > 10000)
                    totalSalaryTextBox.Text = ((salary*100/5).ToString());

                else if (salary >= 8000 && salary <= 10000)
                    totalSalaryTextBox.Text = ((salary*100/6).ToString());

                else
                    totalSalaryTextBox.Text = ((salary*100/7).ToString());
            }
        }
    }
}