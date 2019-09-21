using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangladeshArmyApp
{
    public partial class FireRangeAutomationSystem : Form
    {
        public FireRangeAutomationSystem()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //soldiersListView.Items.Clear();
            //foreach (Employee employee in employees)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.Text = employee.firstName;
            //    item.SubItems.Add(employee.middleName);
            //    item.SubItems.Add(employee.lastName);
            //    item.SubItems.Add(employee.GetFullName());
            //    soldiersListView.Items.Add(item);
            //}
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void scoreOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void scoreTwoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char) Keys.Back)))
                e.Handled = true;
        }

        private void scoreThreeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void scoreFourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
