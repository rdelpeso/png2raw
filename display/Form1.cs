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
        public Form1()
        {
            InitializeComponent();
        }

        private void convertSourceBtn_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(sourcePb.Image);
            var tbm = new Bitmap(sourcePb.Image);
            var water = new Bitmap(sourcePb.Image);

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
            rawPb.Image = water;
        }

        private void loadSourceBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
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
    }
}
