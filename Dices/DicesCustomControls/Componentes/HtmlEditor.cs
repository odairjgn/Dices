using System.Windows.Forms;
using LiveSwitch.TextControl;

namespace DicesCustomControls.Componentes
{
    public partial class HtmlEditor : UserControl
    {
        private Editor _editor;

        public HtmlEditor()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            _editor = new Editor();
            _editor.Dock = DockStyle.Fill;
            Controls.Add(_editor);
        }
    }
}
