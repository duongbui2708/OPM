using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OPM.OPMEnginee;
namespace OPM.GUI
{
    public partial class DescriptionSiteForm : Form
    {
        public delegate void UpdateCatalogDelegate(string value);
        public UpdateCatalogDelegate UpdateCatalogPanel;

        public delegate void RequestDashBoardOpenDescriptionForm(string siteId);
        public RequestDashBoardOpenDescriptionForm requestDashBoardOpendescriptionForm;

        public void refresh()
        {
            this.Controls.Clear();
            InitializeComponent();
            SetDefaultValues();
            
        }
        private void SetDefaultValues()
        {
            txbID.Clear();
            txbhead.Clear();
            txbAddress.Clear();
            txbPhone.Clear();
            txbFax.Clear();
            txbRepresen.Clear();
            txbAccount.Clear();
        }
        public void setId(string value)
        {
            txbID.Text = value;
            return;
        }
        public void setHeadquater(string value)
        {
            txbhead.Text = value;
            return;
        }
        public void setAddress(string value)
        {
            txbAddress.Text = value;
            return;
        }
        public void setPhone(string value)
        {
            txbPhone.Text = value;
            return;
        }
        public void setFax(string value)
        {
            txbFax.Text = value;
            return;

        }
        public void setAccount(string value)
        {
            txbAccount.Text = value;
            return;

        }
        public void setRepresentative(string value)
        {
            txbRepresen.Text = value;
            return;

        }
        public DescriptionSiteForm()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionSiteForm_Load(object sender, EventArgs e)
        {
            //refresh();
        }

        private void DescriptionSiteForm_Activated(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
