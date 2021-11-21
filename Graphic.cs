using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageEditor
{
    interface IGraphic
    {
        public void Move();
        public Label Draw(Point point) { return new Label(); }
    }
}
