using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace quan_ly_kho.Controller
{
    internal class Rounded_Conners
    {
        public static GraphicsPath RoundedConners(Rectangle bounds, int radius, bool topLeft, bool topRight, bool bottomRight, bool bottomLeft)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            // Top-left corner
            if (topLeft)
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            else
                path.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y);

            // Top edge
            path.AddLine(topLeft ? bounds.X + radius : bounds.X, bounds.Y,
                         topRight ? bounds.Right - radius : bounds.Right, bounds.Y);

            // Top-right corner
            if (topRight)
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            else
                path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y);

            // Right edge
            path.AddLine(bounds.Right, topRight ? bounds.Y + radius : bounds.Y,
                         bounds.Right, bottomRight ? bounds.Bottom - radius : bounds.Bottom);

            // Bottom-right corner
            if (bottomRight)
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            else
                path.AddLine(bounds.Right, bounds.Bottom, bounds.Right, bounds.Bottom);

            // Bottom edge
            path.AddLine(bottomRight ? bounds.Right - radius : bounds.Right, bounds.Bottom,
                         bottomLeft ? bounds.X + radius : bounds.X, bounds.Bottom);

            // Bottom-left corner
            if (bottomLeft)
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            else
                path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Bottom);

            // Left edge
            path.AddLine(bounds.X, bottomLeft ? bounds.Bottom - radius : bounds.Bottom,
                         bounds.X, topLeft ? bounds.Y + radius : bounds.Y);

            path.CloseFigure();
            return path;
        }


    }
}
