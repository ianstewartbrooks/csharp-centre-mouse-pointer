using System.Drawing;
using System.Windows.Forms;

namespace CsharpCentreMousePointer
{
    class CentreMouse
    {
        public void MoveMouseToCentre()
        {
            // Main monitor
            // Screen ps = Screen.PrimaryScreen;

            // Current Screen that contains the mouse pointer
            Screen cs = Screen.FromPoint(Cursor.Position);

            // Raw bounds of the monitor (i.e. actual pixel resolution)
            Rectangle b = cs.Bounds;

            // On multi monitor systems the top left will not necessarily be 0,0
            Cursor.Position = new Point(b.Left + b.Width / 2,
                                        b.Top + b.Height / 2);
        }
    }
}
