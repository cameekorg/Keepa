using System;
using System.Drawing;
using System.Windows.Forms;

namespace org.cameek.Keepa
{
    public partial class KeepaForm : Form
    {
        private Point lastPosition;
        private long inactiveMillis;
        private Random random = new Random();
        private Color foreColoreBackup;


        public KeepaForm()
        {
            InitializeComponent();
            labelTime.Text = "";
            labelCursorX.Text = "";
            labelCursorY.Text = "";
            labelInactiveFor.Text = "";
            foreColoreBackup = labelInactiveFor.ForeColor;
        }

        private void keepaTimer_Tick(object sender, EventArgs e)
        {
            if (lastPosition.Equals(Cursor.Position))
            {
                inactiveMillis += keepaTimer.Interval;
            }
            else
            {
                inactiveMillis = 0;
            }

            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelCursorX.Text = "X = " + Cursor.Position.X;
            labelCursorY.Text = "Y = " + Cursor.Position.Y;
            labelInactiveFor.Text = "Inactive for " + inactiveMillis + " ms";

            if (inactiveMillis > numericTimeout.Value)
            {
                Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X + random.Next(0, 50) - random.Next(0, 50), Cursor.Position.Y + random.Next(0, 50) - random.Next(0, 50));
                labelInactiveFor.ForeColor = Color.Blue;
            }
            else
            {
                labelInactiveFor.ForeColor = foreColoreBackup;
            }

            lastPosition = Cursor.Position;
        }
    }
}
