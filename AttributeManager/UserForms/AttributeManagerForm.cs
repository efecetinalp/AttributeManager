using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using INFITF;
using PARTITF;
using MECMOD;
using TCIConstants;
using TCIAttributes;
using static System.Net.Mime.MediaTypeNames;
using AttributeManager.Utilities;
using File = System.IO.File;
using AttributeManager.Models.Abstract;
using AttributeManager.Models.Concrete;

namespace AttributeManager
{
    public partial class AttributeManagerForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static INFITF.Application CATIA;
        private IDepartment _department;
        private ConstantsLibrary _constantsLibrary;
        private AttributeHandler _attributeHandler;
        private ProductDataHandler _productDataHandler;

        Form _settingsForm;

        List<string> _productNameList = new();
        List<string> _descriptionList = new();
        List<string> _materialList = new();
        List<string> _instanceNameList = new();

        public AttributeManagerForm()
        {
            CATIA = (INFITF.Application)Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application"));
            _constantsLibrary = new ConstantsLibrary();
            _productDataHandler = new ProductDataHandler();

            //Check settings
            CheckDefaultUserSettings();

            //Configure attribute handler
            ConfigureSettings();

            InitializeComponent();

            new DropShadow().ApplyShadows(this);
        }

        private void ConfigureSettings()
        {
            if (Properties.Settings.Default.Department == "CABIN")
            {
                _department = new Cabin();
            }
            else if (Properties.Settings.Default.Department == "IFE")
            {
                _department = new IFE();
            }
            else if (Properties.Settings.Default.Department == "SEAT")
            {
                _department = new Seat();
            }
            else
            {
                MessageBox.Show("Settings not available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            _attributeHandler = new AttributeHandler(_department.AttributePath);
        }

        private void CheckDefaultUserSettings()
        {
            if (!Properties.Settings.Default.IsSet)
            {
                //Show settings form
                if (_settingsForm == null)
                {
                    _settingsForm = new SettingsForm();
                    _settingsForm.FormClosed += SettingsForm_FormClosed;
                    _settingsForm.ShowDialog();
                }
                else
                    _settingsForm.Activate();
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _settingsForm = null;

            if (!Properties.Settings.Default.IsSet)
                this.Close();
        }

        private void AttributeManagerForm_Load(object sender, EventArgs e)
        {
            LoadUIData();

            UpdateUIData();
        }

        private void UpdateUIData()
        {

        }

        private void LoadUIData()
        {
            //Get product data list
            _productNameList = _productDataHandler.GetProductList();
            _instanceNameList = _productDataHandler.GetInstanceNameList();
            _descriptionList = _productDataHandler.GetDescriptionList();
            _materialList = _productDataHandler.GetMaterialList();

            //Fills product combobox
            cbProductName.Items.AddRange(_productNameList.ToArray());

            //Fills attributes 
            try
            {
                cbItemType.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.ITEMTYPE).ToArray());
                cbCategory.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.CATEGORY).ToArray());
                cbCurrentStatus.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.CURRENT_STATUS).ToArray());
                cbUnitOfMeasure.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.UNIT_OF_MEASURE).ToArray());
                cbMaterialSpec.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.MATERIAL_SPEC).ToArray());
                cbManufacturingProcess.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.MANUFACTURING_PROCESS).ToArray());
                cbHeatTreatment.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.HEAT_TREATMENT).ToArray());
                cbCoatingColorProcess.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.COATING_COLOR_PROCESS).ToArray());
                cbStatusOfDataAuth.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.STATUS_OF_DATA_AUTH).ToArray());
                cbMakeOrBuy.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.MAKE_OR_BUY).ToArray());
                cbColor.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.COLOR).ToArray());
                cbEquipmentPN.Items.AddRange(_attributeHandler.GetDataset(_constantsLibrary.EQUIPMENT_PN_REV).ToArray());
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Fills user settings
            // Read all lines from user list
            string[] designers = File.ReadAllLines(_constantsLibrary.DESIGNER_LIST_PATH);
            string[] leaders = File.ReadAllLines(_constantsLibrary.LEADER_LIST_PATH);
            string[] approvers = File.ReadAllLines(_constantsLibrary.APPROVER_LIST_PATH);

            // Place values into comboboxes
            cbDesignerName.Items.AddRange(designers);
            cbLeaderName.Items.AddRange(leaders);
            cbApproverName.Items.AddRange(approvers);

            //Fills get attributes section
            cbCopyProductNumber.Items.AddRange(_productNameList.ToArray());
            cbCopyDescription.Items.AddRange(_descriptionList.ToArray());
            cbCopyMaterial.Items.AddRange(_materialList.ToArray());

            //Fills preset categories
            string[] categories = Directory.GetDirectories(_department.PresetPath, "", SearchOption.AllDirectories).Select(Path.GetFileName).ToArray();
            cbPresetCategory.Items.AddRange(categories);
        }

        private void AttributeManagerForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region Close UI

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region When Product Selected

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Text = _descriptionList[cbProductName.SelectedIndex];

            //Update UI form
        }

        #endregion

        //N/A
        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAttributes_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //Show settings form
            if (_settingsForm == null)
            {
                _settingsForm = new SettingsForm();
                _settingsForm.FormClosed += SettingsForm_FormClosed;
                _settingsForm.ShowDialog();
            }
            else
                _settingsForm.Activate();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            cbDesignerName.Text = Environment.UserName;
        }

        private void cbPresetCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPreset.Items.Clear();

            string[] presets = Directory.GetFiles(_department.PresetPath + "\\" + cbPresetCategory.Text).Select(Path.GetFileName).ToArray();

            for (int i = 0; i < presets.Length; i++)
            {
                presets[i] = presets[i].Split(".txt")[0];
            }

            cbPreset.Items.AddRange(presets);
        }
    }
}
