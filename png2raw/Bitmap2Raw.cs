using System.Drawing;

namespace png2raw
{
    public class Bitmap2Raw
    {
        static public byte[] Convert(Bitmap img, byte mul, byte water)
        {
            return Convert(img, mul, water, 256);
        }

        static public byte[] Convert(Bitmap img, byte mul, byte water, int size)
        {
            var data = new byte[size * size * 13];

            var i = 0;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    var color = img.GetPixel(x, y);
                    int c = (color.R + color.G + color.B) / 3;
                    img.GetPixel(x, y);

                    data[i++] = System.Convert.ToByte(c);
                    data[i++] = mul;
                    data[i++] = water;
                    for (int j = 0; j < 10; j++)
                    {
                        data[i++] = 0;
                    }
                }
            }

            return data;
        }
    }
}
