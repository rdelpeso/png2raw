using System.Drawing;

namespace png2raw
{
    public class Raw2Bitmap
    {
        static public Bitmap Convert(byte[] data)
        {
            return Convert(data, 256);
        }

        static public Bitmap Convert(byte[] data, int size)
        {
            var img = new Bitmap(size, size);

            int x = 0;
            int y = 0;
            int v = 0;
            int m = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (x > 255)
                {
                    x = 0;
                    y++;
                }

                v = data[i++];
                m = data[i++];
                v = v * m / 128;
                if (v > 255)
                {
                    v = 255;
                }
                img.SetPixel(x, y, Color.FromArgb(v,v,v));

                for (int j = 0; j < 10; j++)
                {
                    i++;
                }
                x++;
            }

            return img;
        }
    }
}
