using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class salaries : Form
    {
        Functions Con;
        public salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "Select * from EmployeeTb1";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);

        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "Select  * EmployeeTb1 where EmdId= {0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(Con.GetData(Query).Columns["EmpSal"].ToString());
            }
           // MessageBox.Show("" + DSal);
        

        }
        private void ShowSalaries()
        {
            throw new NotImplementedException();
        }

        private void ShowSalaies()
        {
            try
            {
                string Query = "Select * From SalaryTb1";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void salaries_Load(object sender, EventArgs e)
        {

        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);
                    string Query = "insert into SalaryTb1 values({0},{1},{2},'{3}',{4},'{5}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Depatment Added!!!");
                    DaysTb.Text = "";
                }
            }
            catch(Exception     Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void EmpCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
