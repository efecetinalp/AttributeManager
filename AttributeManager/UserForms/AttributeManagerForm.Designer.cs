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
            cbProductName = new ComboBox();
            txtDescription = new TextBox();
            cbApproverName = new ComboBox();
            cbLeaderName = new ComboBox();
            cbDesignerName = new ComboBox();
            buttonUser = new Button();
            buttonSettings = new Button();
            buttonReset = new Button();
            buttonAddAttributes = new Button();
            buttonRefresh = new Button();
            txtMaterial = new TextBox();
            buttonAddMaterial = new Button();
            cbPreset = new ComboBox();
            cbPresetCategory = new ComboBox();
            cbCopyMaterial = new ComboBox();
            cbCopyDescription = new ComboBox();
            cbCopyProductNumber = new ComboBox();
            buttonApply = new Button();
            ((System.ComponentModel.ISupportInitialize)imgClose).BeginInit();
            SuspendLayout();
            // 
            // imgClose
            // 
            imgClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgClose.Image = (Image)resources.GetObject("imgClose.Image");
            imgClose.Location = new Point(436, 6);
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
            cbItemType.Location = new Point(24, 117);
            cbItemType.Name = "cbItemType";
            cbItemType.Size = new Size(172, 21);
            cbItemType.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 8F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(24, 153);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(172, 21);
            cbCategory.TabIndex = 2;
            // 
            // cbUnitOfMeasure
            // 
            cbUnitOfMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnitOfMeasure.Font = new Font("Segoe UI", 8F);
            cbUnitOfMeasure.FormattingEnabled = true;
            cbUnitOfMeasure.Location = new Point(24, 225);
            cbUnitOfMeasure.Name = "cbUnitOfMeasure";
            cbUnitOfMeasure.Size = new Size(172, 21);
            cbUnitOfMeasure.TabIndex = 4;
            // 
            // cbCurrentStatus
            // 
            cbCurrentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrentStatus.Font = new Font("Segoe UI", 8F);
            cbCurrentStatus.FormattingEnabled = true;
            cbCurrentStatus.Location = new Point(24, 189);
            cbCurrentStatus.Name = "cbCurrentStatus";
            cbCurrentStatus.Size = new Size(172, 21);
            cbCurrentStatus.TabIndex = 3;
            // 
            // cbCoatingColorProcess
            // 
            cbCoatingColorProcess.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCoatingColorProcess.Font = new Font("Segoe UI", 8F);
            cbCoatingColorProcess.FormattingEnabled = true;
            cbCoatingColorProcess.Location = new Point(24, 369);
            cbCoatingColorProcess.Name = "cbCoatingColorProcess";
            cbCoatingColorProcess.Size = new Size(172, 21);
            cbCoatingColorProcess.TabIndex = 8;
            // 
            // cbHeatTreatment
            // 
            cbHeatTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHeatTreatment.Font = new Font("Segoe UI", 8F);
            cbHeatTreatment.FormattingEnabled = true;
            cbHeatTreatment.Location = new Point(24, 333);
            cbHeatTreatment.Name = "cbHeatTreatment";
            cbHeatTreatment.Size = new Size(172, 21);
            cbHeatTreatment.TabIndex = 7;
            // 
            // cbManufacturingProcess
            // 
            cbManufacturingProcess.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManufacturingProcess.Font = new Font("Segoe UI", 8F);
            cbManufacturingProcess.FormattingEnabled = true;
            cbManufacturingProcess.Location = new Point(24, 297);
            cbManufacturingProcess.Name = "cbManufacturingProcess";
            cbManufacturingProcess.Size = new Size(172, 21);
            cbManufacturingProcess.TabIndex = 6;
            // 
            // cbMaterialSpec
            // 
            cbMaterialSpec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterialSpec.Font = new Font("Segoe UI", 8F);
            cbMaterialSpec.FormattingEnabled = true;
            cbMaterialSpec.Location = new Point(24, 261);
            cbMaterialSpec.Name = "cbMaterialSpec";
            cbMaterialSpec.Size = new Size(172, 21);
            cbMaterialSpec.TabIndex = 5;
            // 
            // cbEquipmentPN
            // 
            cbEquipmentPN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipmentPN.Font = new Font("Segoe UI", 8F);
            cbEquipmentPN.FormattingEnabled = true;
            cbEquipmentPN.Location = new Point(24, 513);
            cbEquipmentPN.Name = "cbEquipmentPN";
            cbEquipmentPN.Size = new Size(172, 21);
            cbEquipmentPN.TabIndex = 12;
            // 
            // cbColor
            // 
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.Font = new Font("Segoe UI", 8F);
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(24, 477);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(172, 21);
            cbColor.TabIndex = 11;
            // 
            // cbMakeOrBuy
            // 
            cbMakeOrBuy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMakeOrBuy.Font = new Font("Segoe UI", 8F);
            cbMakeOrBuy.FormattingEnabled = true;
            cbMakeOrBuy.Location = new Point(24, 441);
            cbMakeOrBuy.Name = "cbMakeOrBuy";
            cbMakeOrBuy.Size = new Size(172, 21);
            cbMakeOrBuy.TabIndex = 10;
            // 
            // cbStatusOfDataAuth
            // 
            cbStatusOfDataAuth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatusOfDataAuth.Font = new Font("Segoe UI", 8F);
            cbStatusOfDataAuth.FormattingEnabled = true;
            cbStatusOfDataAuth.Location = new Point(24, 405);
            cbStatusOfDataAuth.Name = "cbStatusOfDataAuth";
            cbStatusOfDataAuth.Size = new Size(172, 21);
            cbStatusOfDataAuth.TabIndex = 9;
            // 
            // cbProductName
            // 
            cbProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductName.Font = new Font("Segoe UI", 8F);
            cbProductName.FormattingEnabled = true;
            cbProductName.Location = new Point(24, 37);
            cbProductName.Name = "cbProductName";
            cbProductName.Size = new Size(172, 21);
            cbProductName.TabIndex = 13;
            cbProductName.SelectedIndexChanged += cbProductName_SelectedIndexChanged;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 8F);
            txtDescription.Location = new Point(24, 64);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(172, 22);
            txtDescription.TabIndex = 14;
            // 
            // cbApproverName
            // 
            cbApproverName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbApproverName.Font = new Font("Segoe UI", 8F);
            cbApproverName.FormattingEnabled = true;
            cbApproverName.Location = new Point(228, 189);
            cbApproverName.Name = "cbApproverName";
            cbApproverName.Size = new Size(172, 21);
            cbApproverName.TabIndex = 21;
            // 
            // cbLeaderName
            // 
            cbLeaderName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLeaderName.Font = new Font("Segoe UI", 8F);
            cbLeaderName.FormattingEnabled = true;
            cbLeaderName.Location = new Point(228, 153);
            cbLeaderName.Name = "cbLeaderName";
            cbLeaderName.Size = new Size(172, 21);
            cbLeaderName.TabIndex = 20;
            // 
            // cbDesignerName
            // 
            cbDesignerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDesignerName.Font = new Font("Segoe UI", 8F);
            cbDesignerName.FormattingEnabled = true;
            cbDesignerName.Location = new Point(228, 117);
            cbDesignerName.Name = "cbDesignerName";
            cbDesignerName.Size = new Size(172, 21);
            cbDesignerName.TabIndex = 19;
            // 
            // buttonUser
            // 
            buttonUser.Location = new Point(406, 115);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(28, 23);
            buttonUser.TabIndex = 18;
            buttonUser.Text = "M";
            buttonUser.UseVisualStyleBackColor = true;
            buttonUser.Click += buttonUser_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(406, 37);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(28, 23);
            buttonSettings.TabIndex = 22;
            buttonSettings.Text = "S";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(372, 37);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(28, 23);
            buttonReset.TabIndex = 23;
            buttonReset.Text = "R";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonAddAttributes
            // 
            buttonAddAttributes.Location = new Point(304, 37);
            buttonAddAttributes.Name = "buttonAddAttributes";
            buttonAddAttributes.Size = new Size(28, 23);
            buttonAddAttributes.TabIndex = 25;
            buttonAddAttributes.Text = "@";
            buttonAddAttributes.UseVisualStyleBackColor = true;
            buttonAddAttributes.Click += buttonAddAttributes_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(338, 37);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(28, 23);
            buttonRefresh.TabIndex = 24;
            buttonRefresh.Text = "Rf";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // txtMaterial
            // 
            txtMaterial.Font = new Font("Segoe UI", 8F);
            txtMaterial.Location = new Point(228, 239);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(172, 22);
            txtMaterial.TabIndex = 26;
            // 
            // buttonAddMaterial
            // 
            buttonAddMaterial.Location = new Point(406, 239);
            buttonAddMaterial.Name = "buttonAddMaterial";
            buttonAddMaterial.Size = new Size(28, 23);
            buttonAddMaterial.TabIndex = 27;
            buttonAddMaterial.Text = "A";
            buttonAddMaterial.UseVisualStyleBackColor = true;
            buttonAddMaterial.Click += buttonAddMaterial_Click;
            // 
            // cbPreset
            // 
            cbPreset.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPreset.Font = new Font("Segoe UI", 8F);
            cbPreset.FormattingEnabled = true;
            cbPreset.Location = new Point(228, 430);
            cbPreset.Name = "cbPreset";
            cbPreset.Size = new Size(172, 21);
            cbPreset.TabIndex = 32;
            // 
            // cbPresetCategory
            // 
            cbPresetCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPresetCategory.Font = new Font("Segoe UI", 8F);
            cbPresetCategory.FormattingEnabled = true;
            cbPresetCategory.Location = new Point(228, 394);
            cbPresetCategory.Name = "cbPresetCategory";
            cbPresetCategory.Size = new Size(172, 21);
            cbPresetCategory.TabIndex = 31;
            cbPresetCategory.SelectedIndexChanged += cbPresetCategory_SelectedIndexChanged;
            // 
            // cbCopyMaterial
            // 
            cbCopyMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCopyMaterial.Font = new Font("Segoe UI", 8F);
            cbCopyMaterial.FormattingEnabled = true;
            cbCopyMaterial.Location = new Point(228, 358);
            cbCopyMaterial.Name = "cbCopyMaterial";
            cbCopyMaterial.Size = new Size(172, 21);
            cbCopyMaterial.TabIndex = 30;
            // 
            // cbCopyDescription
            // 
            cbCopyDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCopyDescription.Font = new Font("Segoe UI", 8F);
            cbCopyDescription.FormattingEnabled = true;
            cbCopyDescription.Location = new Point(228, 322);
            cbCopyDescription.Name = "cbCopyDescription";
            cbCopyDescription.Size = new Size(172, 21);
            cbCopyDescription.TabIndex = 29;
            // 
            // cbCopyProductNumber
            // 
            cbCopyProductNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCopyProductNumber.Font = new Font("Segoe UI", 8F);
            cbCopyProductNumber.FormattingEnabled = true;
            cbCopyProductNumber.Location = new Point(228, 286);
            cbCopyProductNumber.Name = "cbCopyProductNumber";
            cbCopyProductNumber.Size = new Size(172, 21);
            cbCopyProductNumber.TabIndex = 28;
            // 
            // buttonApply
            // 
            buttonApply.Font = new Font("Segoe UI", 8F);
            buttonApply.Location = new Point(228, 513);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(172, 23);
            buttonApply.TabIndex = 33;
            buttonApply.Text = "Apply Changes";
            buttonApply.UseVisualStyleBackColor = true;
            // 
            // AttributeManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(454, 570);
            Controls.Add(buttonApply);
            Controls.Add(cbPreset);
            Controls.Add(cbPresetCategory);
            Controls.Add(cbCopyMaterial);
            Controls.Add(cbCopyDescription);
            Controls.Add(cbCopyProductNumber);
            Controls.Add(buttonAddMaterial);
            Controls.Add(txtMaterial);
            Controls.Add(buttonAddAttributes);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonReset);
            Controls.Add(buttonSettings);
            Controls.Add(cbApproverName);
            Controls.Add(cbLeaderName);
            Controls.Add(cbDesignerName);
            Controls.Add(buttonUser);
            Controls.Add(txtDescription);
            Controls.Add(cbProductName);
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
        private ComboBox cbProductName;
        private TextBox txtDescription;
        private ComboBox cbApproverName;
        private ComboBox cbLeaderName;
        private ComboBox cbDesignerName;
        private Button buttonUser;
        private Button buttonSettings;
        private Button buttonReset;
        private Button buttonAddAttributes;
        private Button buttonRefresh;
        private TextBox txtMaterial;
        private Button buttonAddMaterial;
        private ComboBox cbPreset;
        private ComboBox cbPresetCategory;
        private ComboBox cbCopyMaterial;
        private ComboBox cbCopyDescription;
        private ComboBox cbCopyProductNumber;
        private Button buttonApply;
    }
}
