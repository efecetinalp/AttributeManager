using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using INFITF;
using PARTITF;
using MECMOD;
using TCIConstants;
using TCIAttributes;
using KnowledgewareTypeLib;
using AttributeManager.Utilities;
using File = System.IO.File;
using AttributeManager.Models.Abstract;
using AttributeManager.Models.Concrete;
using ProductStructureTypeLib;

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
        private Product _activeProduct;
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

            try
            {
                if (CATIA.ActiveDocument is ProductDocument)
                {
                    _activeProduct = ((ProductDocument)CATIA.ActiveDocument).Product;
                }
                else if (CATIA.ActiveDocument is PartDocument)
                {
                    _activeProduct = ((PartDocument)CATIA.ActiveDocument).Product;
                }
                else
                {
                    MessageBox.Show("Please use this function on CATIA Part or Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please use this function on CATIA Part or Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }

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
        }

        #region Update / Reset / Load UI Form

        private void UpdateUIData(Product product, bool isCopied = false)
        {
            if (product == null)
            {
                MessageBox.Show("Selected product not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string productName = product.get_PartNumber();

            //Hide All Signs

            //Description Field
            if (!isCopied)
            {
                txtDescription.Text = _descriptionList[cbProductName.SelectedIndex];

                if (txtDescription.Text == "")
                {
                    //warning sign visible
                }
            }

            //Attribute Field
            //Product Parameters
            Parameters parameters = product.Parameters;

            //Find quick parameter index
            //This code start search "RELEASED" attribute in product parameters list from bottom to top.
            int parameterIndex = -1;
            for (int i = parameters.Count; i > 0; i--)
            {
                if (parameters.Item(i).get_Name() == productName + "\\Properties\\" + _constantsLibrary.RELEASED)
                {
                    parameterIndex = i;
                    break;
                }
            }

            if (parameterIndex == -1)
            {
                MessageBox.Show("No attributes available!");
                return;
            }

            //Item Type Attribute
            if (parameters.Item(parameterIndex - 13).get_Name() == productName + "\\Properties\\" + _constantsLibrary.ITEMTYPE)
            {
                cbItemType.Text = parameters.Item(parameterIndex - 13).ValueAsString();
            }
            else
            {
                cbItemType.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.ITEMTYPE)).ValueAsString();
            }

            //Category Attribute
            if (parameters.Item(parameterIndex - 12).get_Name() == productName + "\\Properties\\" + _constantsLibrary.CATEGORY)
            {
                cbCategory.Text = parameters.Item(parameterIndex - 12).ValueAsString();
            }
            else
            {
                cbCategory.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.CATEGORY)).ValueAsString();
            }

            //Current Status Attribute
            if (parameters.Item(parameterIndex - 11).get_Name() == productName + "\\Properties\\" + _constantsLibrary.CURRENT_STATUS)
            {
                cbCurrentStatus.Text = parameters.Item(parameterIndex - 11).ValueAsString();
            }
            else
            {
                cbCurrentStatus.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.CURRENT_STATUS)).ValueAsString();
            }

            //Unit of Measure Attribute
            if (parameters.Item(parameterIndex - 10).get_Name() == productName + "\\Properties\\" + _constantsLibrary.UNIT_OF_MEASURE)
            {
                cbUnitOfMeasure.Text = parameters.Item(parameterIndex - 10).ValueAsString();
            }
            else
            {
                cbUnitOfMeasure.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.UNIT_OF_MEASURE)).ValueAsString();
            }

            //Material Spec Attribute
            if (parameters.Item(parameterIndex - 9).get_Name() == productName + "\\Properties\\" + _constantsLibrary.MATERIAL_SPEC)
            {
                cbMaterialSpec.Text = parameters.Item(parameterIndex - 9).ValueAsString();
            }
            else
            {
                cbMaterialSpec.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.MATERIAL_SPEC)).ValueAsString();
            }

            //Manufacturing Process Attribute
            if (parameters.Item(parameterIndex - 8).get_Name() == productName + "\\Properties\\" + _constantsLibrary.MANUFACTURING_PROCESS)
            {
                cbManufacturingProcess.Text = parameters.Item(parameterIndex - 8).ValueAsString();
            }
            else
            {
                cbManufacturingProcess.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.MANUFACTURING_PROCESS)).ValueAsString();
            }

            //Heat Treatment Attribute
            if (parameters.Item(parameterIndex - 7).get_Name() == productName + "\\Properties\\" + _constantsLibrary.HEAT_TREATMENT)
            {
                cbHeatTreatment.Text = parameters.Item(parameterIndex - 7).ValueAsString();
            }
            else
            {
                cbHeatTreatment.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.HEAT_TREATMENT)).ValueAsString();
            }

            //Coating Color Process Attribute
            if (parameters.Item(parameterIndex - 6).get_Name() == productName + "\\Properties\\" + _constantsLibrary.COATING_COLOR_PROCESS)
            {
                cbCoatingColorProcess.Text = parameters.Item(parameterIndex - 6).ValueAsString();
            }
            else
            {
                cbCoatingColorProcess.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.COATING_COLOR_PROCESS)).ValueAsString();
            }

            //Status Of Data Authority Attribute
            if (parameters.Item(parameterIndex - 5).get_Name() == productName + "\\Properties\\" + _constantsLibrary.STATUS_OF_DATA_AUTH)
            {
                cbStatusOfDataAuth.Text = parameters.Item(parameterIndex - 5).ValueAsString();
            }
            else
            {
                cbStatusOfDataAuth.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.STATUS_OF_DATA_AUTH)).ValueAsString();
            }

            //Make or Buy Attribute
            if (parameters.Item(parameterIndex - 4).get_Name() == productName + "\\Properties\\" + _constantsLibrary.MAKE_OR_BUY)
            {
                cbMakeOrBuy.Text = parameters.Item(parameterIndex - 4).ValueAsString();
            }
            else
            {
                cbMakeOrBuy.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.MAKE_OR_BUY)).ValueAsString();
            }

            //Color Attribute
            if (parameters.Item(parameterIndex - 3).get_Name() == productName + "\\Properties\\" + _constantsLibrary.COLOR)
            {
                cbColor.Text = parameters.Item(parameterIndex - 3).ValueAsString();
            }
            else
            {
                cbColor.Text = ((Parameter)parameters.GetItem(productName + "\\Properties\\" + _constantsLibrary.COLOR)).ValueAsString();
            }

            //Material Field
            if (!isCopied)
            {

                txtMaterial.Enabled = true;

                if (product.ReferenceProduct.Parent is PartDocument)
                {
                    Part currentPart = ((PartDocument)product.ReferenceProduct.Parent).Part;
                    txtMaterial.Text = _productDataHandler.GetCurrentMaterial(currentPart);
                }
                else
                {
                    txtMaterial.Enabled = false;
                    txtMaterial.Text = "---";
                }
            }


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

        private void ResetUIData()
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox comboBox)
                {
                    //don't need to reset product combobox
                    if (control.Name != "cbProductName")
                    {
                        comboBox.SelectedIndex = -1;
                    }
                }
            }
        }

        #endregion



        #region When Product Selected or Product Changed

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset UI form
            ResetUIData();

            //Set Selected Product
            Product selectedProduct;
            if (cbProductName.SelectedIndex == 0)
            {
                selectedProduct = _activeProduct;
            }
            else
            {
                _productDataHandler.SearchSubProduct(_activeProduct, _instanceNameList[cbProductName.SelectedIndex]);
                selectedProduct = _productDataHandler.GetSearchedProduct;
            }

            //Update UI form
            UpdateUIData(selectedProduct);
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
            ResetUIData();
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

        #region UI Form Drag to Move

        private void AttributeManagerForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion 

        #region Close UI

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
