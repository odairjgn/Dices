using System.Collections.Generic;
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

            _edit.AddFontSelector(DicesCore.Global.FontesValidas);
            _edit.AddFontSizeSelector(new List<int>() {1, 2, 3, 4, 5, 6, 7});
            Controls.Add(_edit);
        }
    }
}
