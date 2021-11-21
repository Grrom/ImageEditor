using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageEditor
{
    class Dot
    {
        public static Label Draw(Point point)
        {
            Label dot = new Label
            {
                Font = new System.Drawing.Font("Arial", 15),
                Text = ".",
                Location = point,
                Size = new Size(50, 50)
            };
            return dot;
        }
    }
}
