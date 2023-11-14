using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_BOTO
{
    public partial class AdminPanel : Form
    {
        bool sidebarExpand;
        bool reportsCollapse;
        bool manageCollapse;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();   
        }

        private void sidebarContainerTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 5;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 5;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Votesbtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            ReportsTimer.Start();
        }

        private void ReportsTimer_Tick(object sender, EventArgs e)
        {
            if (manageCollapse)
            {
                ManagePanel.Height += 10;
                if (ReportsPanel.Height == ReportsPanel.MaximumSize.Height)
                {
                    reportsCollapse = true;    
                    ReportsTimer.Stop();   
                }
            }
            else
            {
                ReportsPanel.Height -= 10;
                if (ReportsPanel.Height == ReportsPanel.MinimumSize.Height)
                {
                    reportsCollapse = false;
                    ReportsTimer.Stop();
                }
            }
        }

        private void DashboardContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Positionsbtn_Click(object sender, EventArgs e)
        {

        }

        private void Managebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ManagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageTimer_Tick(object sender, EventArgs e)
        {
            if (manageCollapse)
            {
                ManagePanel.Height += 10;
                if (ManagePanel.Height == ManagePanel.Height)
                {
                    manageCollapse = false;
                    ManageTimer.Stop();    
                }
            }
            else
            {
                ManagePanel.Height -= 10;
                if (ManagePanel.Height == ManagePanel.MinimumSize.Height)
                {
                    manageCollapse = true;
                    ManageTimer.Stop();
                }
            }
        }
    }
}
