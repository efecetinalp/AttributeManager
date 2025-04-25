using AttributeManager.Utilities;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCIConstants;

namespace AttributeManager
{
    public partial class SettingsForm : Form
    {
        //Form window drag to move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        ConstantsLibrary constantsLibrary;
        private string _activeDepartment;

        public SettingsForm()
        {
            constantsLibrary = new ConstantsLibrary();

            InitializeComponent();

            new DropShadow().ApplyShadows(this);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            GetFormData();

            if (Properties.Settings.Default.IsSet)
            {
                cbDesignerName.Text = Properties.Settings.Default.DesignerName;
                cbLeaderName.Text = Properties.Settings.Default.LeaderName;
                cbApproverName.Text = Properties.Settings.Default.ApproverName;

                //Move slider bar



            }

        }

        private void GetFormData()
        {
            // Read all lines from user list
            string[] designers = File.ReadAllLines(constantsLibrary.DESIGNER_LIST_PATH);
            string[] leaders = File.ReadAllLines(constantsLibrary.LEADER_LIST_PATH);
            string[] approvers = File.ReadAllLines(constantsLibrary.APPROVER_LIST_PATH);

            // Place values into comboboxes
            cbDesignerName.Items.AddRange(designers);
            cbLeaderName.Items.AddRange(leaders);
            cbApproverName.Items.AddRange(approvers);
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            cbDesignerName.Text = Environment.UserName;
        }

        #region Close UI

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (cbDesignerName.SelectedIndex > -1 && cbLeaderName.SelectedIndex > -1 && cbApproverName.SelectedIndex > -1 && _activeDepartment != "")
            {
                Properties.Settings.Default.DesignerName = cbDesignerName.Text;
                Properties.Settings.Default.LeaderName = cbLeaderName.Text;
                Properties.Settings.Default.ApproverName = cbApproverName.Text;
                Properties.Settings.Default.Department = _activeDepartment;
                Properties.Settings.Default.IsSet = true;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
                MessageBox.Show("Please fill all empty areas","Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            cbDesignerName.SelectedIndex = -1;
            cbLeaderName.SelectedIndex = -1;
            cbApproverName.SelectedIndex = -1;

            Properties.Settings.Default.DesignerName = "";
            Properties.Settings.Default.LeaderName = "";
            Properties.Settings.Default.ApproverName = "";
            Properties.Settings.Default.Department = "";
            Properties.Settings.Default.IsSet = false;
            Properties.Settings.Default.Save();
        }

        private void buttonCabin_Click(object sender, EventArgs e)
        {
            _activeDepartment = "CABIN";
        }

        private void buttonIFE_Click(object sender, EventArgs e)
        {
            _activeDepartment = "IFE";
        }

        private void buttonSeat_Click(object sender, EventArgs e)
        {
            _activeDepartment = "SEAT";
        }
    }
}
