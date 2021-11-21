using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageEditor
{
    class Circle
    {

        public static Label Draw(Point point)
        {
            Label circle = new Label
            {
                Font = new System.Drawing.Font("Arial", 30),
                Text = "o",
                Location = point,
                Size = new Size(50, 50)
            };
            return circle;
        }


    }
}
