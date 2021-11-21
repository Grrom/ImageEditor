using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageEditor
{
    class CompountGraphic : IGraphic
    {
        public List<IGraphic> children = new List<IGraphic>();

        public void AddChild(IGraphic toAdd)
        {
            children.Add(toAdd);
        }

        public void Move(Point point)
        {
            throw new NotImplementedException();
        }

        public void RemoveChild(IGraphic toAdd)
        {
            children.Add(toAdd);
        }

        public Label Draw(Point point)
        {
            throw new NotImplementedException();
        }

    }
}
