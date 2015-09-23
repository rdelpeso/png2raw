namespace display
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourcePb = new System.Windows.Forms.PictureBox();
            this.rawPb = new System.Windows.Forms.PictureBox();
            this.loadSourceBtn = new System.Windows.Forms.Button();
            this.saveRawBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.convertSourceBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawPb)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePb
            // 
            this.sourcePb.Image = global::display.Properties.Resources.sample;
            this.sourcePb.Location = new System.Drawing.Point(0, 0);
            this.sourcePb.Name = "sourcePb";
            this.sourcePb.Size = new System.Drawing.Size(256, 256);
            this.sourcePb.TabIndex = 0;
            this.sourcePb.TabStop = false;
            // 
            // rawPb
            // 
            this.rawPb.Image = global::display.Properties.Resources.sample;
            this.rawPb.InitialImage = global::display.Properties.Resources.sample;
            this.rawPb.Location = new System.Drawing.Point(256, 0);
            this.rawPb.Name = "rawPb";
            this.rawPb.Size = new System.Drawing.Size(256, 256);
            this.rawPb.TabIndex = 1;
            this.rawPb.TabStop = false;
            // 
            // loadSourceBtn
            // 
            this.loadSourceBtn.Location = new System.Drawing.Point(0, 262);
            this.loadSourceBtn.Name = "loadSourceBtn";
            this.loadSourceBtn.Size = new System.Drawing.Size(256, 23);
            this.loadSourceBtn.TabIndex = 2;
            this.loadSourceBtn.Text = "Load Source";
            this.loadSourceBtn.UseVisualStyleBackColor = true;
            this.loadSourceBtn.Click += new System.EventHandler(this.loadSourceBtn_Click);
            // 
            // saveRawBtn
            // 
            this.saveRawBtn.Location = new System.Drawing.Point(382, 262);
            this.saveRawBtn.Name = "saveRawBtn";
            this.saveRawBtn.Size = new System.Drawing.Size(130, 23);
            this.saveRawBtn.TabIndex = 3;
            this.saveRawBtn.Text = "Save Raw";
            this.saveRawBtn.UseVisualStyleBackColor = true;
            this.saveRawBtn.Click += new System.EventHandler(this.saveRawBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = ".png|*.png|All Files|*.*";
            // 
            // convertSourceBtn
            // 
            this.convertSourceBtn.Location = new System.Drawing.Point(256, 262);
            this.convertSourceBtn.Name = "convertSourceBtn";
            this.convertSourceBtn.Size = new System.Drawing.Size(130, 23);
            this.convertSourceBtn.TabIndex = 4;
            this.convertSourceBtn.Text = "Convert Source";
            this.convertSourceBtn.UseVisualStyleBackColor = true;
            this.convertSourceBtn.Click += new System.EventHandler(this.convertSourceBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RAW|*.raw";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(55, 293);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.comboBox1.Location = new System.Drawing.Point(133, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Multiplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Invert:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.convertSourceBtn);
            this.Controls.Add(this.saveRawBtn);
            this.Controls.Add(this.loadSourceBtn);
            this.Controls.Add(this.rawPb);
            this.Controls.Add(this.sourcePb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Convert Image to RAW";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePb;
        private System.Windows.Forms.PictureBox rawPb;
        private System.Windows.Forms.Button loadSourceBtn;
        private System.Windows.Forms.Button saveRawBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button convertSourceBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

