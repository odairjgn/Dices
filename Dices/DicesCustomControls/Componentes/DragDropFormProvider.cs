using System;
using System.Drawing;
using System.Windows.Forms;

namespace DicesCustomControls.Componentes
{

    public class DragDropFormProvider
    {
        private bool mouseDown;
        private Point lastLocation;

        private Form _form;
        private Control _dragableControl;

        public bool Enabled { get; set; } = false;

        public DragDropFormProvider(Form form, Control dragableControl)
        {
            _form = form;
            _dragableControl = dragableControl;

            _dragableControl.MouseDown += MouseDown;
            _dragableControl.MouseMove += MouseMove;
            _dragableControl.MouseUp += MouseUp;
            _dragableControl.MouseHover += MouseHover;
            _dragableControl.MouseLeave += MouseLeave;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            if (!Enabled) return;

            _form.Cursor = Cursors.Default;
        }
        
        private void MouseHover(object sender, EventArgs e)
        {
            if (!Enabled) return;

            _form.Cursor = Cursors.SizeAll;
        }
        
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (!Enabled) return;

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if(!Enabled) return;

            if (mouseDown)
            {
                _form.Location = new Point(
                    (_form.Location.X - lastLocation.X) + e.X, (_form.Location.Y - lastLocation.Y) + e.Y);

                _form.Update();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (!Enabled) return;

            mouseDown = false;
        }
    }
}
