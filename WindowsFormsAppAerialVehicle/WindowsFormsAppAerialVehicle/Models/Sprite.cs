using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace OOPFlyingVehicle
{
    public class Sprite
    {
        public Point Location;

        public string picture;
        public PictureBox Pb;

        public static int SpriteCount;

        public Sprite()
        {

            this.picture = "Bitmap1.bmp";
            this.Location = new Point(10, 0 + (50 * SpriteCount));
            LoadPicture();
            SpriteCount++;
        }

        public void LoadPicture()
        {
            this.Pb = new PictureBox();
            this.Pb.Location = this.Location;
            this.Pb.Image = Bitmap.FromFile(this.picture);
        }

        public void Move(Point p)
        {
            this.Location = p;
            this.Pb.Location = this.Location;
        }
    }
}
