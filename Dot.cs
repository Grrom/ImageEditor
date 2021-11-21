using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    class Dot : IGraphic
    {
        public static Label Draw(Point point)
        {
            Label dot = new Label
            {
                Font = new Font("Arial", 15),
                Text = ".",
                Location = point,
                Size = new Size(19, 19),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            return dot;
        }

        public void Move(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
