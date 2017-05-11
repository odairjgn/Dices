using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dices.Extentions
{
    public static class FormsExtentions
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);

        private const uint SW_RESTORE = 0x09;

        public static void SetUserControl(this UserControl uc, Panel container)
        {
            if(container.Controls.Contains(uc)) return;

            foreach (Control ctrl in container.Controls)
            {
                container.Controls.Remove(ctrl);
            }

            uc.Dock = DockStyle.Fill;
            container.Controls.Add(uc);
        }

        public static void Restore(this Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
            {
                ShowWindow(form.Handle, SW_RESTORE);
            }
        }
    }
}
