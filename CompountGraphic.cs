using System;
using System.Collections.Generic;
using System.Text;

namespace ImageEditor
{
    class CompountGraphic : Graphic
    {
        public List<Graphic> children = new List<Graphic>();

        public void AddChild(Graphic toAdd)
        {
            children.Add(toAdd);
        }

        public void RemoveChild(Graphic toAdd)
        {
            children.Add(toAdd);
        }

        void Graphic.Draw()
        {
            throw new NotImplementedException();
        }

        void Graphic.Move()
        {
            throw new NotImplementedException();
        }
    }
}
