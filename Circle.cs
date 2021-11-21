using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageEditor
{
    class Circle : IGraphic
    {

        public static Label Draw(Point point)
        {
            Label circle = new Label
            {
                Font = new System.Drawing.Font("Arial", 30),
                Text = "o",
                Location = point,
                Size = new Size(35, 36),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            return circle;
        }

        public void Move(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
