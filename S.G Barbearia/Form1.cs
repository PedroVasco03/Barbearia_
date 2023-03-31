using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.G_Barbearia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sidebarExpand;

        private void sideBarAnimation_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 40;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarAnimation.Stop();
                }
            }
            else
            {
                sidebar.Width += 40;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarAnimation.Stop();
                }
            }
        }

        private void pg_cortes_Click(object sender, EventArgs e)
        {
            sideBarAnimation.Start();
        }
    }
}
