using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using INFITF;
using PARTITF;
using MECMOD;
using DashboardUI;
using TCIConstants;
using TCIAttributes;
using static System.Net.Mime.MediaTypeNames;

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
        private ConstantsLibrary constantsLibrary;
        private AttributeHandler attributeHandler;
        private ProductDataHandler productDataHandler;

        public AttributeManagerForm()
        {
            CATIA = (INFITF.Application)Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application"));
            constantsLibrary = new ConstantsLibrary();
            productDataHandler = new ProductDataHandler();

            //Check settings
            //Configure attribute handler

            attributeHandler = new AttributeHandler(constantsLibrary.CABIN_ATTRIBUTE_PATH);

            InitializeComponent();

            new DropShadow().ApplyShadows(this);
        }

        private void AttributeManagerForm_Load(object sender, EventArgs e)
        {
            //Fills product combobox
            List<string> newList = new();
            newList = productDataHandler.GeneratedDatas;

            foreach (var data in newList)
            {
                Debug.Print(data);
            }

            //Fills attributes 
            try
            {
                cbItemType.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.ITEMTYPE).ToArray());
                cbCategory.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.CATEGORY).ToArray());
                cbCurrentStatus.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.CURRENT_STATUS).ToArray());
                cbUnitOfMeasure.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.UNIT_OF_MEASURE).ToArray());
                cbMaterialSpec.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.MATERIAL_SPEC).ToArray());
                cbManufacturingProcess.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.MANUFACTURING_PROCESS).ToArray());
                cbHeatTreatment.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.HEAT_TREATMENT).ToArray());
                cbCoatingColorProcess.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.COATING_COLOR_PROCESS).ToArray());
                cbStatusOfDataAuth.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.STATUS_OF_DATA_AUTH).ToArray());
                cbMakeOrBuy.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.MAKE_OR_BUY).ToArray());
                cbColor.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.COLOR).ToArray());
                cbEquipmentPN.Items.AddRange(attributeHandler.GetDataset(constantsLibrary.EQUIPMENT_PN_REV).ToArray());
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Fills user settings
            
            //Fills get attributes section

            //Update UI form
        }

        private void AttributeManagerForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
