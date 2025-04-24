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
            cbItemType = new ComboBox();
            cbCategory = new ComboBox();
            cbUnitOfMeasure = new ComboBox();
            cbCurrentStatus = new ComboBox();
            cbCoatingColorProcess = new ComboBox();
            cbHeatTreatment = new ComboBox();
            cbManufacturingProcess = new ComboBox();
            cbMaterialSpec = new ComboBox();
            cbEquipmentPN = new ComboBox();
            cbColor = new ComboBox();
            cbMakeOrBuy = new ComboBox();
            cbStatusOfDataAuth = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imgClose).BeginInit();
            SuspendLayout();
            // 
            // imgClose
            // 
            imgClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgClose.Image = (Image)resources.GetObject("imgClose.Image");
            imgClose.Location = new Point(400, 6);
            imgClose.Name = "imgClose";
            imgClose.Size = new Size(12, 12);
            imgClose.SizeMode = PictureBoxSizeMode.AutoSize;
            imgClose.TabIndex = 0;
            imgClose.TabStop = false;
            imgClose.Click += imgClose_Click;
            // 
            // cbItemType
            // 
            cbItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItemType.Font = new Font("Segoe UI", 8F);
            cbItemType.FormattingEnabled = true;
            cbItemType.Location = new Point(24, 99);
            cbItemType.Name = "cbItemType";
            cbItemType.Size = new Size(172, 21);
            cbItemType.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 8F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(24, 135);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(172, 21);
            cbCategory.TabIndex = 2;
            // 
            // cbUnitOfMeasure
            // 
            cbUnitOfMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnitOfMeasure.Font = new Font("Segoe UI", 8F);
            cbUnitOfMeasure.FormattingEnabled = true;
            cbUnitOfMeasure.Location = new Point(24, 207);
            cbUnitOfMeasure.Name = "cbUnitOfMeasure";
            cbUnitOfMeasure.Size = new Size(172, 21);
            cbUnitOfMeasure.TabIndex = 4;
            // 
            // cbCurrentStatus
            // 
            cbCurrentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrentStatus.Font = new Font("Segoe UI", 8F);
            cbCurrentStatus.FormattingEnabled = true;
            cbCurrentStatus.Location = new Point(24, 171);
            cbCurrentStatus.Name = "cbCurrentStatus";
            cbCurrentStatus.Size = new Size(172, 21);
            cbCurrentStatus.TabIndex = 3;
            // 
            // cbCoatingColorProcess
            // 
            cbCoatingColorProcess.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCoatingColorProcess.Font = new Font("Segoe UI", 8F);
            cbCoatingColorProcess.FormattingEnabled = true;
            cbCoatingColorProcess.Location = new Point(24, 351);
            cbCoatingColorProcess.Name = "cbCoatingColorProcess";
            cbCoatingColorProcess.Size = new Size(172, 21);
            cbCoatingColorProcess.TabIndex = 8;
            // 
            // cbHeatTreatment
            // 
            cbHeatTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHeatTreatment.Font = new Font("Segoe UI", 8F);
            cbHeatTreatment.FormattingEnabled = true;
            cbHeatTreatment.Location = new Point(24, 315);
            cbHeatTreatment.Name = "cbHeatTreatment";
            cbHeatTreatment.Size = new Size(172, 21);
            cbHeatTreatment.TabIndex = 7;
            // 
            // cbManufacturingProcess
            // 
            cbManufacturingProcess.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManufacturingProcess.Font = new Font("Segoe UI", 8F);
            cbManufacturingProcess.FormattingEnabled = true;
            cbManufacturingProcess.Location = new Point(24, 279);
            cbManufacturingProcess.Name = "cbManufacturingProcess";
            cbManufacturingProcess.Size = new Size(172, 21);
            cbManufacturingProcess.TabIndex = 6;
            // 
            // cbMaterialSpec
            // 
            cbMaterialSpec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterialSpec.Font = new Font("Segoe UI", 8F);
            cbMaterialSpec.FormattingEnabled = true;
            cbMaterialSpec.Location = new Point(24, 243);
            cbMaterialSpec.Name = "cbMaterialSpec";
            cbMaterialSpec.Size = new Size(172, 21);
            cbMaterialSpec.TabIndex = 5;
            // 
            // cbEquipmentPN
            // 
            cbEquipmentPN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipmentPN.Font = new Font("Segoe UI", 8F);
            cbEquipmentPN.FormattingEnabled = true;
            cbEquipmentPN.Location = new Point(24, 495);
            cbEquipmentPN.Name = "cbEquipmentPN";
            cbEquipmentPN.Size = new Size(172, 21);
            cbEquipmentPN.TabIndex = 12;
            // 
            // cbColor
            // 
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.Font = new Font("Segoe UI", 8F);
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(24, 459);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(172, 21);
            cbColor.TabIndex = 11;
            // 
            // cbMakeOrBuy
            // 
            cbMakeOrBuy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMakeOrBuy.Font = new Font("Segoe UI", 8F);
            cbMakeOrBuy.FormattingEnabled = true;
            cbMakeOrBuy.Location = new Point(24, 423);
            cbMakeOrBuy.Name = "cbMakeOrBuy";
            cbMakeOrBuy.Size = new Size(172, 21);
            cbMakeOrBuy.TabIndex = 10;
            // 
            // cbStatusOfDataAuth
            // 
            cbStatusOfDataAuth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatusOfDataAuth.Font = new Font("Segoe UI", 8F);
            cbStatusOfDataAuth.FormattingEnabled = true;
            cbStatusOfDataAuth.Location = new Point(24, 387);
            cbStatusOfDataAuth.Name = "cbStatusOfDataAuth";
            cbStatusOfDataAuth.Size = new Size(172, 21);
            cbStatusOfDataAuth.TabIndex = 9;
            // 
            // AttributeManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(418, 570);
            Controls.Add(cbEquipmentPN);
            Controls.Add(cbColor);
            Controls.Add(cbMakeOrBuy);
            Controls.Add(cbStatusOfDataAuth);
            Controls.Add(cbCoatingColorProcess);
            Controls.Add(cbHeatTreatment);
            Controls.Add(cbManufacturingProcess);
            Controls.Add(cbMaterialSpec);
            Controls.Add(cbUnitOfMeasure);
            Controls.Add(cbCurrentStatus);
            Controls.Add(cbCategory);
            Controls.Add(cbItemType);
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
        private ComboBox cbItemType;
        private ComboBox cbCategory;
        private ComboBox cbUnitOfMeasure;
        private ComboBox cbCurrentStatus;
        private ComboBox cbCoatingColorProcess;
        private ComboBox cbHeatTreatment;
        private ComboBox cbManufacturingProcess;
        private ComboBox cbMaterialSpec;
        private ComboBox cbEquipmentPN;
        private ComboBox cbColor;
        private ComboBox cbMakeOrBuy;
        private ComboBox cbStatusOfDataAuth;
    }
}
