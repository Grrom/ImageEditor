using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public bool willDrawCircle = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            willDrawCircle = true;
        }
        private void dotButton_Click(object sender, EventArgs e)
        {
            willDrawCircle = false;
        }

        private void LocateCoordinates(object sender, EventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            if (willDrawCircle)
            {
                panel1.Controls.Add(Circle.Draw(point));
            }
            else
            {
                panel1.Controls.Add(Dot.Draw(point));
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
