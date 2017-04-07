using System;
using System.Windows.Forms;
using DicesCustomControls.Componentes.Internos;
using DicesCustomControls.Enums;

namespace DicesCustomControls.Componentes
{
    public class DropDownProvider
    {
        private readonly DropDownControl _dropDownControl;
        private readonly Timer _timer;
        private readonly int _timeOut;
        private int _cronometro;

        public event EventHandler TimeOut;
        public event EventHandler DropDownAbriu;
        public event EventHandler DropDownFechou;

        public DropDownProvider(Control container, Control ancora, int segundosTimeOut = 0)
        {
            _dropDownControl = new DropDownControl() { Visible = false };
            _dropDownControl.Parent = ancora;
            _dropDownControl.InitializeDropDown(container);
            _cronometro = 0;
            _timeOut = segundosTimeOut;
            _timer = new Timer() { Interval = 1000 };
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_timeOut <= 0)
            {
                _timer.Stop();
                _cronometro = 0;
            }

            _cronometro++;

            if (_cronometro >= _timeOut)
            {
                FecharDropDown();
                _timer.Stop();
                _cronometro = 0;
                if (TimeOut != null) TimeOut.Invoke(this, new EventArgs());
            }
        }

        public bool ClickDropDown()
        {
            if (_dropDownControl.DropState == EDropState.Closing ||
                _dropDownControl.DropState == EDropState.Dropping)
                return false;

            if (_dropDownControl.DropState == EDropState.Closed)
            {
                _dropDownControl.OpenDropDown();
                if (DropDownAbriu != null) DropDownAbriu.Invoke(this, new EventArgs());
                return true;
            }

            if (_dropDownControl.DropState == EDropState.Dropped)
            {
                _dropDownControl.CloseDropDown();
                if (DropDownFechou != null) DropDownFechou.Invoke(this, new EventArgs());
                return true;
            }

            return true;
        }

        public void FecharDropDown()
        {
            if (_dropDownControl.DropState == EDropState.Closing ||
               _dropDownControl.DropState == EDropState.Dropping)
                return;

            _dropDownControl.CloseDropDown();
            if (DropDownFechou != null) DropDownFechou.Invoke(this, new EventArgs());
        }

        public void AbrirDropDown()
        {
            if (_dropDownControl.DropState == EDropState.Closing ||
               _dropDownControl.DropState == EDropState.Dropping)
                return;

            _dropDownControl.OpenDropDown();
            if (DropDownAbriu != null) DropDownAbriu.Invoke(this, new EventArgs());

            if (_timeOut > 0)
            {
                _timer.Start();
            }
        }
    }
}
