namespace Gestin.UI.Commons
{
    internal static class Helpers
    {
        public static void OpenChildForm(Form formHijo, object parent)
        {
            Panel panel = (Panel)parent;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
