using Gestin.LocalFiles;
using Gestin.Model;
using Gestin.Properties;
using Gestin.UI.Custom;
using Microsoft.Data.SqlClient;

namespace Gestin.Validators
{
    public static class generalValidator
    {
        public static bool testContextConnection()
        {
            bool success = false;

            try
            {
                if (LocalConnection.ConnectionString.Equals("")) { throw new Exception(); }

                using (var db = new Context())
                {
                    success = db.Database.CanConnect();
                }
                if (!success) { throw new Exception(); }

            }
            catch (Exception) { new MessageBoxDarkMode("No se pudo conectar con la base de datos!", "Error de Conexión", "Ok", Resources.CloudError, true); }

            return success;

        }

        public static bool attemptConnectionToDatabase(string connectionString)
        {
            bool status = false;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    status = true;
                }
            }
            catch (SqlException) { throw; }
            return status;
        }

        public static void validateNumbers(KeyPressEventArgs e, string nameLabel)
        {
            if (!char.IsNumber(e.KeyChar) && ((e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Enter))
            {
                new MessageBoxDarkMode("En el campo '' " + nameLabel + " '' debe ingresar sólo NÚMEROS!!", "Error", "Ok", Resources.BigErrorIcon, true);
                e.Handled = true;
            }
        }

        public static bool checkIfThereAreRecordsInDataGrid(string label, DataGridView dgv)
        {
            bool result = dgv.SelectedRows.Count > 0;

            if (!result)
            {
                new MessageBoxDarkMode("No se ha seleccionado ningun " + label + "!!", "Error", "Ok", Resources.BigErrorIcon, true);
            }
            return result;
        }


        public static bool confirmOnDelete(string label)
        {
            MessageBoxDarkMode messageBox = new MessageBoxDarkMode("Está seguro de que desea eliminar esta " + label + " ??", "Confirme la eliminación", "OkCancel", Resources.advertencia, true);
            return messageBoxDialogResult(messageBox);
        }

        public static bool checkIfNumeric(string year)
        {
            bool isNumeric = int.TryParse(year, out _);
            return isNumeric;
        }

        public static bool messageBoxDialogResult(MessageBoxDarkMode messageBoxDarkMode)
        {
            //use this method if you want to have my messageboxes with Ok/Cancel
            bool messageBoxResponse = false;
            messageBoxDarkMode.ResponseEvent += (sender, e) =>
            {
                messageBoxResponse = e.status;
            };
            messageBoxDarkMode.ShowDialog(); //force user input to make this event work
            return messageBoxResponse;
        }

        public static bool areDatesValid(DateTime datesince, DateTime dateuntil)
        {
            return dateuntil <= datesince;
        }
    }
}
