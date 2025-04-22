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

        public AttributeManagerForm()
        {
            CATIA = (INFITF.Application)Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application"));
            constantsLibrary = new ConstantsLibrary();
            attributeHandler = new AttributeHandler(constantsLibrary.CABIN_ATTRIBUTE_PATH);

            InitializeComponent();

            new DropShadow().ApplyShadows(this);
        }

        private void AttributeManagerForm_Load(object sender, EventArgs e)
        {
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
