using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    public interface IGraphic
    {
        void Move(Point point);
        Label Draw(Point point) { return new Label(); }
    }
}
