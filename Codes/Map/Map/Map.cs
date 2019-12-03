using System.Drawing;

namespace map
{
    public class Map
    {
        public Rectangle desrect= new Rectangle(0, 0, 1680, 1050);
        public Rectangle srcrect;
        public Bitmap map;

        public Map(string filepath)
        {
            map = new Bitmap(filepath);
        }

        public void Draw(int moveX, int moveY, Graphics g)
        {
            srcrect = new Rectangle(moveX, moveY, 1680, 1050);
            g.DrawImage(map, desrect, srcrect, GraphicsUnit.Pixel);
        }
    }
}
