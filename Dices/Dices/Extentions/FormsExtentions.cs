using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dices.Extentions
{
    public static class FormsExtentions
    {
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
        
    }
}
