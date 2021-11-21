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

        public void RemoveChild(IGraphic toAdd)
        {
            children.Add(toAdd);
        }

        Label IGraphic.Draw(Point point)
        {
            throw new NotImplementedException();
        }

        void IGraphic.Move()
        {
            throw new NotImplementedException();
        }
    }
}
