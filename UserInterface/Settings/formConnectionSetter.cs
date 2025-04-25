using Gestin.Controllers;
using Gestin.LocalFiles;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;
using System.Data.SqlClient;
using System.Net;

namespace Gestin.UI.Settings
{
    public partial class formConnectionSetter : Form
    {
        string? activeconnection = LocalConnection.ConnectionString;
        public formConnectionSetter()
        {
            InitializeComponent();
        }

        private void formConnectionSetter_Load(object sender, EventArgs e)
        {
            refreshActiveConnection();
            refreshDefaultConnections();
        }

        private void formConnectionSetter_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        public void refreshDefaultConnections()
        {
            cbbConnections.DataSource = LocalConnection.defaultConnections();
            cbbConnections.ValueMember = "Data Source";
        }

        public void refreshActiveConnection()
        {
            if (!string.IsNullOrEmpty(activeconnection))
            {
                lblExistingConnection.Text = Convert.ToString(new SqlConnectionStringBuilder(activeconnection).DataSource);
            }
        }

        private void btnSelectedConnection_Click(object sender, EventArgs e)
        {
            if (verifyFields())
            {
                string serverName = txtServer.Text;

                string? instance = Convert.ToString(cbbInstance.SelectedItem);

                if (!string.IsNullOrEmpty(instance)) { serverName += instance; }

                if (!string.IsNullOrEmpty(txtPort.Text)) { serverName += "," + txtPort.Text; }

                SqlConnectionStringBuilder sqlConnectionString = new()
                {
                    DataSource = serverName,
                    InitialCatalog = txtDatabase.Text,
                    IntegratedSecurity = chkTrustedSource.Checked,
                    Encrypt = chkEncrypt.Checked,
                    UserID = txtUserId.Text,
                    Password = txtPassword.Text,
                    ConnectTimeout = Convert.ToInt32(cbbTimeout.SelectedItem)
                };

                string? connectionString = Convert.ToString(sqlConnectionString);

                if (!string.IsNullOrEmpty(connectionString))
                {
                    if (generalValidator.attemptConnectionToDatabase(connectionString)
                    && LocalGestinSettings.Instance.editFileSection("ConnectionString", [connectionString] ))
                    {
                        new MessageBoxDarkMode("Conexión exitosa!", "Exito de Conexión", "Ok", Resources.Done, true);
                        Application.Restart();
                    }
                    else
                        new MessageBoxDarkMode("Conexión fallida!", "Error de Conexión", "Ok", Resources.BigErrorIcon, true);
                }
                else
                    new MessageBoxDarkMode("Conexión es nula!", "Conexión nula", "Ok", Resources.BigErrorIcon, true);
            }
        }

        private void cbbConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbConnections.SelectedIndex != -1 && cbbConnections.SelectedItem != null)
            {
                inputTextFields(new SqlConnectionStringBuilder(Convert.ToString(cbbConnections.SelectedItem)));
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(activeconnection))
            {
                inputTextFields(new SqlConnectionStringBuilder(activeconnection));
            }
        }

        private void inputTextFields(SqlConnectionStringBuilder builder)
        {
            string server = builder.DataSource;

            if (possibleIPAddress(server))
            {
                cbbInstance.Enabled = false;
            }
            else
                cbbInstance.Enabled = true;

            if (server.Contains("\\"))
            {
                cbbInstance.SelectedText = server.Substring(server.IndexOf("\\"));
                server = server.Split('\\')[0].Trim();
            }
            else
                cbbInstance.SelectedIndex = 0;

            if (server.Contains(","))
            {
                txtPort.Text = server.Substring(server.IndexOf(",") + 1);
                server = server.Split(',')[0].Trim();
            }
            else
                txtPort.Clear();

            txtServer.Text = server;
            txtDatabase.Text = builder.InitialCatalog;
            txtUserId.Text = builder.UserID;
            txtPassword.Text = builder.Password;
            chkTrustedSource.Checked = builder.IntegratedSecurity;
            chkEncrypt.Checked = builder.Encrypt;
            cbbTimeout.Text = Convert.ToString(builder.ConnectTimeout);
        }

        private bool possibleIPAddress(string server)
        {
            return server.Contains('.') || server.Contains(':');
        }

        private bool parseIPAddress(string address)
        {
            try
            {
                return IPAddress.TryParse(address, out IPAddress? ip);
            }
            catch (ArgumentNullException) { new MessageBoxDarkMode("Hubo un error parseando la direccion IP", "IP Parsing Error", "Ok", Resources.BigErrorIcon, true); }
            return false;
        }

        private bool verifyFields()
        {
            string server = txtServer.Text;
            string port = txtPort.Text;
            string? instance = Convert.ToString(cbbInstance.SelectedItem);
            bool ipParse = false;

            if (possibleIPAddress(server))
            {
                ipParse = parseIPAddress(server);

                if (!ipParse) { return false; }
            }

            if (ipParse)
            {
                if (!string.IsNullOrEmpty(instance))
                {
                    new MessageBoxDarkMode("Si el servidor es una dirección IP, la instancia debe ser nula", "Instancia Error", "Ok", Resources.BigErrorIcon, true);
                    return false;
                }
            }

            if (!port.All(char.IsDigit))
            {
                new MessageBoxDarkMode("El puerto debe tener solamente digitos y no ser negativo!", "Puerto Error", "Ok", Resources.BigErrorIcon, true);
                return false;
            }
            if (port.Length > 5 && port != "0")
            {
                new MessageBoxDarkMode("El numero de puerto debe ser entre 1 y 65535!", "Puerto Error", "Ok", Resources.BigErrorIcon, true);
                return false;
            }
            if (server.Contains(',') && port.Length > 0)
            {
                new MessageBoxDarkMode("Si incluye el puerto en el campo Servidor (aa.bb.cc.dd,eeee) no lo repita en el campo Puerto", "Puerto Error", "Ok", Resources.BigErrorIcon, true);
                return false;
            }
            return true;
        }
    }
}
