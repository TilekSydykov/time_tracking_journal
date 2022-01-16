using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    public partial class Journal : Form
    {
        List<Employee> employeeList = new List<Employee>();

        public Journal()
        {
            InitializeComponent();
            employeeList.AddRange(Util.employeesExample);
            TableEmpleyee.ClearSelection();
            UpdateTable();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = AddName.Text;
            string surename = AddSurname.Text;
            int age = Convert.ToInt32(AddAge.Value);
            int position = AddPosition.SelectedIndex;
            string teleNick = AddTeleNick.Text;
            Employee employee = new Employee(name, surename, age, position, teleNick);
            employeeList.Add(employee);
            UpdateTable();
        }

        private void UpdateTable()
        {
            TableEmpleyee.Rows.Clear();
            foreach(Employee employee in employeeList)
            {
                TableEmpleyee.Rows.Add(employee.toGrid());
            }
        }

        private Employee choosenEmp = null;

        private void TableEmpleyee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedInd = TableEmpleyee.CurrentCell.RowIndex;
            choosenEmp = employeeList[selectedInd];
            UpdateSelectedEmp();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateSelectedEmp();
        }

        private void UpdateSelectedEmp()
        {
            NameLbl.Text = choosenEmp.name + " " + choosenEmp.surename;
            DateTime choosenDay = DateTimePicker.Value.Date;
            List<TimeSpan> times = (choosenEmp.history.ContainsKey(choosenDay)) 
                ? choosenEmp.history[choosenDay] : new List<TimeSpan>();
            TableHistory.Rows.Clear();
            for(int i=0; i<times.Count; i++)
            {
                TableHistory.Rows.Add(new object[]{ times[i].ToString(@"hh\:mm"), 
                    (i % 2 == 0) ? "Came" : "Left"});
            }
            if(times.Count % 2 == 0)
            {
                CameBtn.Enabled = true;
                CameBtn.BackColor = Color.Green;
                LeftBtn.Enabled = false;
                LeftBtn.BackColor = Color.Gray;
            }
            else
            {
                CameBtn.Enabled = false;
                CameBtn.BackColor = Color.Gray;
                LeftBtn.Enabled = true;
                LeftBtn.BackColor = Color.Red;
            }
            double total = 0.0;
            for(int i=0; i<times.Count; i++)
            {
                if (i % 2 == 0) total -= times[i].TotalMinutes;
                else total += times[i].TotalMinutes;
                Console.WriteLine("HERE: "+total);
            }
            if (times.Count % 2 != 0) total += DateTime.Now.TimeOfDay.TotalMinutes; 
            TotalLbl.Text = "Total: " + Math.Floor(total/60).ToString() + ":" 
                + Convert.ToInt32(total%60).ToString();
        }
        
        private void CameBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (choosenEmp.history.ContainsKey(now.Date)) {
                choosenEmp.history[now.Date].Add(now.TimeOfDay);
            }
            else
            {
                choosenEmp.history.Add(now.Date, new List<TimeSpan>());
                choosenEmp.history[now.Date].Add(now.TimeOfDay);
            }
            UpdateSelectedEmp();
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (choosenEmp.history.ContainsKey(now.Date))
            {
                choosenEmp.history[now.Date].Add(now.TimeOfDay);
            }
            else
            {
                choosenEmp.history.Add(now.Date, new List<TimeSpan>());
                choosenEmp.history[now.Date].Add(now.TimeOfDay);
            }
            UpdateSelectedEmp();
        }

        private void TableHistory_SelectionChanged(object sender, EventArgs e)
        {
            TableHistory.ClearSelection();
        }
    }
}
