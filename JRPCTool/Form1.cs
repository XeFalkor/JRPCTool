using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XDevkit;
using JRPC_Client;

namespace JRPCTool
{
    public partial class frmMain : Form
    {
        IXboxConsole Xbox;
        private static bool isConnected = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Xbox.Connect(out Xbox) && !isConnected)
                {
                    isConnected = true;
                    MessageBox.Show("JRPC Tool - Connected!");
                    connectToolStripMenuItem.Enabled = false;
                }
                else
                {
                    isConnected = false;
                    MessageBox.Show("JRPC Tool - Not Connected!");
                    connectToolStripMenuItem.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("JRPC Tool - Could not connect!");
            }
        }
    }
}
