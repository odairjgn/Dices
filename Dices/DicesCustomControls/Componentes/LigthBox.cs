using System.Windows.Forms;
using DicesCustomControls.Enums;

namespace DicesCustomControls.Componentes
{
    public partial class LigthBox<T> : Form where T : Form
    {
        public T Formulario { get; private set; }

        private IntesidadeLigthBox _intesidade;
        public IntesidadeLigthBox Intesidade
        {
            get { return _intesidade; }
            set
            {
                _intesidade = value;
                Opacity = ((float)(int)_intesidade) / 100;
            }
        }

        public LigthBox(T formulario)
        {
            InitializeComponent();
            TopMost = HabilitarTopMost;

            Formulario = formulario;
            Text = formulario.Text;
            Intesidade = IntesidadeLigthBox.Default;
        }

        public bool HabilitarTopMost { get; set; } = true;

        private void LigthBox_Load(object sender, System.EventArgs e)
        {
            DialogResult = Formulario.ShowDialog();
            Close();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
    }
}
