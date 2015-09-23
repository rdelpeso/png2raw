using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using png2raw;

namespace display
{
    public partial class Form1 : Form
    {
        private Bitmap water;
        private Bitmap blank;

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(loadSourceBtn, "Imports an image to be used as source.");
            toolTip1.SetToolTip(convertSourceBtn, "Converts the imported image to grayscale.");
            toolTip1.SetToolTip(saveRawBtn, "Saves the grayscaled image as RAW.");
            toolTip1.SetToolTip(checkBox1, "Inverts the colors in the source image when converted.");
            toolTip1.SetToolTip(comboBox1, "Defines how stretched the resulting RAW image will be. If you want soft curves and small elevations use a lower number.");
            water = new Bitmap(256,256);
            blank = new Bitmap(256,256);
        }

        private void convertSourceBtn_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(sourcePb.Image);
            var tbm = new Bitmap(sourcePb.Image);

            for (int y = 0; y < 256; y++)
            {
                for (int x = 0; x < 256; x++)
                {
                    var color = bm.GetPixel(x, y);
                    int c = (color.R + color.G + color.B) / 3;
                    if (checkBox1.Checked)
                    {
                        c = 255 - c;
                    }
                    tbm.SetPixel(x, y, Color.FromArgb(c, c, c));
                    water.SetPixel(x, y, (c > 20) ? Color.Transparent : Color.FromArgb(0, 33, 66));
                }
            }
            rawPb.Image = tbm;
            rawPb.BackgroundImage = tbm;
            changeWaterState();
        }

        private void loadSourceBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            if (Path.GetExtension(openFileDialog1.FileName) == ".raw")
            {
                byte[] data = new byte[0];
                using (var memoryStream = new MemoryStream())
                {
                    openFileDialog1.OpenFile().CopyTo(memoryStream);
                    data = memoryStream.ToArray();
                }
                sourcePb.Image = Raw2Bitmap.Convert(data);
                return;
            }

            sourcePb.ImageLocation = openFileDialog1.FileName;
        }

        private void saveRawBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var cases = new byte[] { 1, 3, 7, 15, 31, 63, 127, 255 };
            var destination = saveFileDialog1.FileName;
            var stream = new FileStream(destination, FileMode.Create);
            byte multiplier = cases[comboBox1.SelectedIndex];
            byte water = 20;

            var data = Bitmap2Raw.Convert(new Bitmap(rawPb.BackgroundImage), multiplier, water);
            for (int i = 0; i < data.Length; i++)
            {
                stream.WriteByte(data[i]);
            }

            stream.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changeWaterState();
        }

        private void changeWaterState()
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                rawPb.Image = water;
                return;
            }
            rawPb.Image = blank;
        }
    }
}
