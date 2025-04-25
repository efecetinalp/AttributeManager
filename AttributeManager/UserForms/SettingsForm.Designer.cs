namespace AttributeManager
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            imgClose = new PictureBox();
            buttonCabin = new Button();
            buttonIFE = new Button();
            buttonSeat = new Button();
            buttonApply = new Button();
            buttonCancel = new Button();
            buttonUser = new Button();
            cbDesignerName = new ComboBox();
            cbLeaderName = new ComboBox();
            cbApproverName = new ComboBox();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)imgClose).BeginInit();
            SuspendLayout();
            // 
            // imgClose
            // 
            imgClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgClose.Image = (Image)resources.GetObject("imgClose.Image");
            imgClose.Location = new Point(302, 3);
            imgClose.Name = "imgClose";
            imgClose.Size = new Size(12, 12);
            imgClose.SizeMode = PictureBoxSizeMode.AutoSize;
            imgClose.TabIndex = 1;
            imgClose.TabStop = false;
            imgClose.Click += imgClose_Click;
            // 
            // buttonCabin
            // 
            buttonCabin.Location = new Point(26, 25);
            buttonCabin.Name = "buttonCabin";
            buttonCabin.Size = new Size(76, 78);
            buttonCabin.TabIndex = 2;
            buttonCabin.Text = "Cabin";
            buttonCabin.UseVisualStyleBackColor = true;
            buttonCabin.Click += buttonCabin_Click;
            // 
            // buttonIFE
            // 
            buttonIFE.Location = new Point(112, 25);
            buttonIFE.Name = "buttonIFE";
            buttonIFE.Size = new Size(76, 78);
            buttonIFE.TabIndex = 3;
            buttonIFE.Text = "IFE";
            buttonIFE.UseVisualStyleBackColor = true;
            buttonIFE.Click += buttonIFE_Click;
            // 
            // buttonSeat
            // 
            buttonSeat.Location = new Point(198, 25);
            buttonSeat.Name = "buttonSeat";
            buttonSeat.Size = new Size(76, 78);
            buttonSeat.TabIndex = 4;
            buttonSeat.Text = "Seat";
            buttonSeat.UseVisualStyleBackColor = true;
            buttonSeat.Click += buttonSeat_Click;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(26, 240);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(113, 31);
            buttonApply.TabIndex = 8;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(157, 240);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(127, 32);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUser
            // 
            buttonUser.Location = new Point(192, 118);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(28, 23);
            buttonUser.TabIndex = 10;
            buttonUser.Text = "M";
            buttonUser.UseVisualStyleBackColor = true;
            buttonUser.Click += buttonUser_Click;
            // 
            // cbDesignerName
            // 
            cbDesignerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDesignerName.Font = new Font("Segoe UI", 8F);
            cbDesignerName.FormattingEnabled = true;
            cbDesignerName.Location = new Point(26, 119);
            cbDesignerName.Name = "cbDesignerName";
            cbDesignerName.Size = new Size(160, 21);
            cbDesignerName.TabIndex = 11;
            // 
            // cbLeaderName
            // 
            cbLeaderName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLeaderName.Font = new Font("Segoe UI", 8F);
            cbLeaderName.FormattingEnabled = true;
            cbLeaderName.Location = new Point(26, 146);
            cbLeaderName.Name = "cbLeaderName";
            cbLeaderName.Size = new Size(160, 21);
            cbLeaderName.TabIndex = 12;
            // 
            // cbApproverName
            // 
            cbApproverName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbApproverName.Font = new Font("Segoe UI", 8F);
            cbApproverName.FormattingEnabled = true;
            cbApproverName.Location = new Point(26, 173);
            cbApproverName.Name = "cbApproverName";
            cbApproverName.Size = new Size(160, 21);
            cbApproverName.TabIndex = 13;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(246, 119);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(28, 23);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "R";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 292);
            Controls.Add(buttonReset);
            Controls.Add(cbApproverName);
            Controls.Add(cbLeaderName);
            Controls.Add(cbDesignerName);
            Controls.Add(buttonUser);
            Controls.Add(buttonCancel);
            Controls.Add(buttonApply);
            Controls.Add(buttonSeat);
            Controls.Add(buttonIFE);
            Controls.Add(buttonCabin);
            Controls.Add(imgClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            MouseDown += SettingsForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)imgClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgClose;
        private Button buttonCabin;
        private Button buttonIFE;
        private Button buttonSeat;
        private Button buttonApply;
        private Button buttonCancel;
        private Button buttonUser;
        private ComboBox cbDesignerName;
        private ComboBox cbLeaderName;
        private ComboBox cbApproverName;
        private Button buttonReset;
    }
}