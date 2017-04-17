using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using YARTE.UI.Buttons;

namespace DicesCustomControls.Componentes
{
    public partial class HtmlEditor : UserControl
    {
        private YARTE.UI.HtmlEditor _edit;

        public HtmlEditor()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            _edit = new YARTE.UI.HtmlEditor();
            _edit.Dock = DockStyle.Fill;
            _edit.ShowToolbar = true;
            _edit.AddToolbarItems(new List<IHTMLEditorButton>()
            {
                new BoldButton(),
                new ItalicButton(),
                new UnderlineButton(),
                new JustifyLeftButton(),
                new JustifyCenterButton(),
                new JustifyRightButton(),
                new ForecolorButton(),
                new InsertLinkedImageButton(),
                new LinkButton(),
                new UnlinkButton(),
                new OrderedListButton(),
                new UnorderedListButton(),
            });

            var fon = new InstalledFontCollection().Families.Where(f => f.IsStyleAvailable(FontStyle.Regular)).Select(f => f.Name);

            _edit.AddFontSelector(fon);
            _edit.AddFontSizeSelector(new List<int>() {1, 2, 3, 4, 5, 6, 7});
            Controls.Add(_edit);
        }
    }
}
