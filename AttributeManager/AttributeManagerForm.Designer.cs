namespace AttributeManager
{
    partial class AttributeManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeManagerForm));
            imgClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgClose).BeginInit();
            SuspendLayout();
            // 
            // imgClose
            // 
            imgClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgClose.Image = (Image)resources.GetObject("imgClose.Image");
            imgClose.Location = new Point(358, 6);
            imgClose.Name = "imgClose";
            imgClose.Size = new Size(12, 12);
            imgClose.SizeMode = PictureBoxSizeMode.AutoSize;
            imgClose.TabIndex = 0;
            imgClose.TabStop = false;
            imgClose.Click += imgClose_Click;
            // 
            // AttributeManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 477);
            Controls.Add(imgClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttributeManagerForm";
            Text = "Form1";
            Load += AttributeManagerForm_Load;
            MouseDown += AttributeManagerForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)imgClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgClose;
    }
}
