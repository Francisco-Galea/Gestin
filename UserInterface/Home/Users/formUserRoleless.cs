using Gestin.Controllers;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;
using System.Data;

namespace Gestin.UI.Home.Users
{
    public partial class formUserRoleless : Form
    {
        userController userController = userController.getInstance();
        studentController studentController = studentController.getInstance();
        bool directionColumn;
        List<dynamic> listUsers;

        public formUserRoleless()
        {
            InitializeComponent();
        }

        private void formUserRoleless_Load(object sender, EventArgs e)
        {
            listUsers = new(combinedController.listRolelessUsers());

            if (listUsers.Count > 0)
                refreshTableRolelessUsers();
        }

        private void formUserRoleless_FormClosing(object sender, FormClosingEventArgs e)
        {
            //receivedform.Show();
        }

        private void refreshTableRolelessUsers()
        {
            try
            {
                userBindingSource.DataSource = listUsers;
                userBindingSource.ResetBindings(false);
                dataGridViewRoleless.DataSource = userBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewRoleless_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoleless.Rows.Count > 0)
            {
                if (dataGridViewRoleless.CurrentRow.Cells[4].Value != null)
                    btnReactivateUser.Visible = true;
                else
                    btnReactivateUser.Visible = false;
            }
        }

        private void dataGridViewRoleless_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string headerText = dataGridViewRoleless.Columns[e.ColumnIndex].DataPropertyName; //cualquier columna
            if (directionColumn)
            {
                userBindingSource.DataSource = listUsers.OrderBy(o => o.GetType().GetProperty(headerText).GetValue(o)); //ASC
                directionColumn = false;
            }
            else
            {
                userBindingSource.DataSource = listUsers.OrderByDescending(o => o.GetType().GetProperty(headerText).GetValue(o)); //DSC
                directionColumn = true;
            }
        }

        private void btnReactivateUser_Click(object sender, EventArgs e)
        {
            if (listUsers.Count > 0)
            {
                int dni = Convert.ToInt32(dataGridViewRoleless.CurrentRow.Cells[1].Value);
                if (userController.reactivateUser(dni))
                {
                    new MessageBoxDarkMode("Usuario reactivado!", "Reactivado", "Ok", Resources.TickIcon);
                    btnReactivateUser.Visible = false;
                    refreshTableRolelessUsers();
                }
            }
        }
    }
}
