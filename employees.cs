using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class employees : Form
    {
        Functions Con;

        public object JDateTb { get; private set; }
        public object key { get; private set; }

        public employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            try
            {
                string Query = "Select * From EmployeeTb1";
                EmployeeList.DataSource = Con.GetData(Query);
            }
            catch (Exception){

                throw;
            }
        }
        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTb1";
            DepCb.DisplayMember= Con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = Con.GetData(Query);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Genger = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(GenCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "insert into DepartmentTb1 values('{0}','{1}',{2},'{3}','{4}','{5}')";
                    Query = string.Format(Query, Name,Genger,Dep,DOB,JDate,Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Depatment Added!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key==0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                   

                    string Query = "Delete from EmployeeTb1 where EmpId={0}";
                    Query = string.Format(Query,Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Depatment Deleted!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Genger = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(GenCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Update EmployeeTb1 set EmpName = '{0}',EmpGen='{1}',EmpDep={2},EmpDOB='{3}',EmpJDate='{4}',EmpSal='{5}'where EmpId={6)";
                    Query = string.Format(Query, Name, Genger, Dep, DOB, JDate, Salary,Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Depatment Added!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
