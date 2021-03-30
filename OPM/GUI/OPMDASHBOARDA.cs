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
    public partial class OPMDASHBOARDA : Form
    {
        
        private TreeNode selectedNode;

        public PurchaseOderInfor objPurchaseOder= new PurchaseOderInfor();

        

        public OPMDASHBOARDA()
        {
            InitializeComponent();
            //var addedDate = DateTime.Now.Date.AddDays(10);
            TreeNode node = null;
            InitCatalogAdmin(node, null);
            
        }

        private int LoadCatalogAdmin()
        {
            List<CatalogAdmin> lstCatalogAdmins = new List<CatalogAdmin>();
            int ret = CatalogAdmin.GetFamilyNodes(ref lstCatalogAdmins);

            treeView1.Nodes.Clear();

            foreach(CatalogAdmin catalogAdmin in lstCatalogAdmins)
            {
                TreeNode a = treeView1.Nodes.Add(catalogAdmin.CatalogParent);
                
                AddChildTreeNode(ref a, catalogAdmin.GetListChildNode());

            }    
            return 1;
        }

        private int InitCatalogAdmin(TreeNode parentNode, string parent)
        {
            DataSet ds = new DataSet();
            int ret = CatalogAdmin.GetCatalogNodes(ref ds, parent);
            if(0 == ret)
            {
                return 0;
            }

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TreeNode node = new TreeNode();
                node.Text = dr["ctlname"].ToString();
                node.Name = dr["ctlID"].ToString();
                string strChildID = dr["ctlID"].ToString();
                if(null == parentNode|| null==parent)
                {
                    InitCatalogAdmin(node, strChildID);
                    treeView1.Nodes.Add(node);
                }
                else
                {
                    InitCatalogAdmin(node, strChildID);
                    parentNode.Nodes.Add(node);

                }    
            }
            return 1;
        }
        public  void UpdateTreeView(string strNewNode)
        {
            treeView1.Nodes[0].Nodes[0].Nodes.Add(strNewNode);
        }
        private Form activeForm = null;
        private UserControl activateUserControl = null;
        private  void OpenChidForm(Form childForm)
        {
            if (null != activeForm)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panContent.Controls.Add(childForm);
            panContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void OpenChidForm1(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panDescription.Controls.Add(childForm);
            panDescription.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void OpenChidForm2(Form childForm, string strTypeForm, object strParam)
        {
            if (null != activeForm)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            /*Set Properties Child Form*/
            switch (strTypeForm)
            {
                case "PurchaseOderInfor":
                    break;
                default:
                    break;
            }    
            panContent.Controls.Add(childForm);
            panContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        public void treeView1_DoubleClick(object sender, EventArgs e)
        {
            /*OK Important for Communication*/

            /*Check What Label Checked and it's parent Checked*/
            MessageBox.Show(treeView1.SelectedNode.Name.ToString());

            string strNodeID = treeView1.SelectedNode.Name.ToString();
            if (null != treeView1.SelectedNode.Parent)
            {
                string strParentNodeID = treeView1.SelectedNode.Parent.Name.ToString();
                MessageBox.Show(treeView1.SelectedNode.Parent.Text);
            }    
            else
            {
                MessageBox.Show("No Parent Node");
            }
            string[] temp = strNodeID.Split('_');
            temp[0] += "_";
            /*Get Detail Infor On Database*/
            switch (temp[0])
            {
                case ConstantVar.ContractType:
                    /*DASHBOARD Display Gui Contract*/
                    ContractInfoChildForm contractInfoChildForm = new ContractInfoChildForm();
                    contractInfoChildForm.UpdateCatalogPanel = new ContractInfoChildForm.UpdateCatalogDelegate(GetCatalogvalue);
                    /*DASHBOAD GET REQEST FROM CONTRACT GUI*/
                    contractInfoChildForm.RequestDashBoardOpenPOForm = new ContractInfoChildForm.RequestDashBoardOpenChildForm(OpenPOForm);
                    
                    contractInfoChildForm.SetValueItemForm(temp[1]);
                    

                    //PurchaseOderInfor purchaseOderInfor1 = new PurchaseOderInfor();
                    //purchaseOderInfor1.requestDashBoardOpenNTKTForm = new PurchaseOderInfor.RequestDashBoardOpenNTKTForm(OpenNTKTForm);

                    OpenChidForm(contractInfoChildForm);
                    contractInfoChildForm.requestDashBoardOpendescriptionForm = new ContractInfoChildForm.RequestDashBoardOpenDescriptionForm(OpenDescription);

                    break;
                case ConstantVar.POType:
                    /*Display PO */
                    PurchaseOderInfor purchaseOderInfor  = new PurchaseOderInfor();
                    purchaseOderInfor.UpdateCatalogPanel = new PurchaseOderInfor.UpdateCatalogDelegate(GetCatalogvalue);
                    MessageBox.Show(temp[1]);
                    purchaseOderInfor.requestDashBoardOpenNTKTForm = new PurchaseOderInfor.RequestDashBoardOpenNTKTForm(OpenNTKTForm);
                    purchaseOderInfor.SetValueItemForPO(temp[1]);

                    OpenChidForm(purchaseOderInfor);
                    break;
                case ConstantVar.DPType:
                    /*Display DP */
                    DeliverPartInforDetail deliverPartInforDetail = new DeliverPartInforDetail();
                    deliverPartInforDetail.UpdateCatalogPanel = new DeliverPartInforDetail.UpdateCatalogDelegate(GetCatalogvalue);
                    OpenChidForm(deliverPartInforDetail);
                    break;
                case ConstantVar.NTKTType:
                    /*Display NTKT */
                    NTKTInfor nTKTInfor = new NTKTInfor();
                    nTKTInfor.UpdateCatalogPanel = new NTKTInfor.UpdateCatalogDelegate(GetCatalogvalue);
                    nTKTInfor.setValueItemForNTKT(temp[1]);
                    OpenChidForm(nTKTInfor);
                    break;
                case ConstantVar.PLType:
                    /*Display PL */
                    PackageListInfor packageListInfor = new PackageListInfor();
                    packageListInfor.UpdateCatalogPanel = new PackageListInfor.UpdateCatalogDelegate(GetCatalogvalue);
                    OpenChidForm(packageListInfor);
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }

        private void contextMenuStrip_Click(object sender, EventArgs e)
        {
            OpenChidForm(new ContractInfoChildForm());

        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuRefresh")
            {
                /*DashBoard Call Contract Child Form*/
                ContractInfoChildForm contractInfoChildForm = new ContractInfoChildForm();
                contractInfoChildForm.UpdateCatalogPanel = new ContractInfoChildForm.UpdateCatalogDelegate(GetCatalogvalue);

                /*DASHBOAD GET REQEST FROM CONTRACT GUI*/
                contractInfoChildForm.RequestDashBoardOpenPOForm = new ContractInfoChildForm.RequestDashBoardOpenChildForm(OpenPOForm);
                /*end of DashBoard Call Contract Child Form*/

                //Vừa thêm vào xem có chạy hay không đây
                PurchaseOderInfor purchaseOderInfor = new PurchaseOderInfor();
                purchaseOderInfor.UpdateCatalogPanel = new PurchaseOderInfor.UpdateCatalogDelegate(GetCatalogvalue);

                /*Open NTKT Form*/
                purchaseOderInfor.requestDashBoardOpenNTKTForm = new PurchaseOderInfor.RequestDashBoardOpenNTKTForm(OpenNTKTForm);

                contractInfoChildForm.requestDashBoardOpendescriptionForm = new ContractInfoChildForm.RequestDashBoardOpenDescriptionForm(OpenDescription);

                OpenChidForm(contractInfoChildForm);
            }
            else if(e.ClickedItem.Name == "toolStripMenuNew")
            {
                //Do Something
                PurchaseOderInfor purchaseOderInfor = new PurchaseOderInfor();
                purchaseOderInfor.UpdateCatalogPanel = new PurchaseOderInfor.UpdateCatalogDelegate(GetCatalogvalue);
                OpenChidForm(purchaseOderInfor);
            }
            else if (e.ClickedItem.Name == "toolStripMenuEdit")
            {
                //Do Something
                TreeNode a = treeView1.Nodes[0];
                List<string> MyList4 = new List<string>();
                MyList4.Add("Free");
                MyList4.Add("Education");

                AddChildTreeNode(ref a, MyList4);

            }
            else
            {
                //Do Something
                MessageBox.Show("Wanna Delete this Node?");

            }


        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedNode = treeView1.GetNodeAt(e.X, e.Y);
                //MessageBox.Show("You clicked on node: " + selectedNode.Name.ToString());

            }
            if(e.Button == MouseButtons.Right)
            {
                if(null == treeView1.SelectedNode)
                {
                    return;
                }    
                if(treeView1.SelectedNode.Name.Contains("Year"))
                {
                    return;

                }else if(treeView1.SelectedNode.Name.Contains("PO_Year"))
                {
                    return;
                }
                else if (treeView1.SelectedNode.Name.Contains("NTKT"))
                {
                    return;
                }
                else if (treeView1.SelectedNode.Name.Contains("DP_PO_Year"))
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        private void AddChildTreeNode(ref TreeNode treeParentNode, List<string> treeChildNodes)
        {
            foreach(string childNode in treeChildNodes)
            {

                TreeNode treeChildNode = new System.Windows.Forms.TreeNode(childNode);
                treeParentNode.Nodes.Add(childNode);
            } 
            return;
        }

        private void AfterLabelEdited()
        {
            return;
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            /*Check What Lalel was Editted*/
            /*Update On DataBase*/
            return;
        }

        private void OPMDASHBOARDA_Load(object sender, EventArgs e)
        {
            //GUI.UsrCtltabHeader usrCtltabHeader = new GUI.UsrCtltabHeader();
            //this.panHeader.Controls.Add(usrCtltabHeader);
            //usrCtltabHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));

        }
        /*OK Important for Comunicate*/
        public void GetCatalogvalue(string strvalue)
        {
            treeView1.Nodes.Clear();
            TreeNode node = null;
            InitCatalogAdmin(node, null);

            return;
        }

        public void UpdateCatalogNodes(TreeNode parentNode, string strNewnode)
        {
            TreeNode newTreeNode = new TreeNode(strNewnode);
            if(!parentNode.Nodes.Contains(newTreeNode))
            {
                parentNode.Nodes.Add(newTreeNode);
            }    
            return;
        }

        public void OpenSequenceChildForm(string strParentInfo)
        {
            if(strParentInfo.Contains(ConstantVar.ContractType))
            {
                PurchaseOderInfor purchaseOderInfor = new PurchaseOderInfor();
                purchaseOderInfor.UpdateCatalogPanel = new PurchaseOderInfor.UpdateCatalogDelegate(GetCatalogvalue);
                /*Set Properties For Purchase Order Form*/
                string strTemp = strParentInfo.Replace("Contract_", "");
                purchaseOderInfor.SetTxbIDContract(strTemp);
                //contractInfoChildForm.SetValueItemForm();
                OpenChidForm(purchaseOderInfor);
            }    
        }

        public void OpenPOForm(string strIDContract, string strKHMS)
        {
            PurchaseOderInfor purchaseOderInfor = new PurchaseOderInfor();
            purchaseOderInfor.UpdateCatalogPanel = new PurchaseOderInfor.UpdateCatalogDelegate(GetCatalogvalue);

            /*Receipt Request Open Nghiệm Thu Kỹ Thuật Form*/
            purchaseOderInfor.requestDashBoardOpenNTKTForm = new PurchaseOderInfor.RequestDashBoardOpenNTKTForm(OpenNTKTForm);

            /*Receipt Request Open Xác Nhận Đơn Hàng Form*/
            purchaseOderInfor.requestDashBoardOpenConfirmPOForm = new PurchaseOderInfor.RequestDashBoardOpenConfirmForm(OpenConfirmPOForm);

            /**/
            ContractInfoChildForm contractInfoChildForm = new ContractInfoChildForm();
            contractInfoChildForm.requestDashBoardOpendescriptionForm = new ContractInfoChildForm.RequestDashBoardOpenDescriptionForm(OpenDescription);
            strIDContract = strIDContract.Replace("Contract_","");
            purchaseOderInfor.SetTxbIDContract(strIDContract);
            purchaseOderInfor.SetTxbKHMS(strKHMS);
            OpenChidForm(purchaseOderInfor);
            return;

        }

        public void OpenNTKTForm(string strKHMS, string strContractID, string strPOID, string strPONumber)
        {
            NTKTInfor nTKTInfor= new NTKTInfor();
            nTKTInfor.UpdateCatalogPanel = new NTKTInfor.UpdateCatalogDelegate(GetCatalogvalue);
            nTKTInfor.SetKHMS(strKHMS);
            nTKTInfor.requestDashBoardPurchaseOderForm = new NTKTInfor.RequestDashBoardPurchaseOderForm(OpenPOForm);
            strContractID = strContractID.Replace("Contract_","");
            nTKTInfor.SetContractID(strContractID);
            nTKTInfor.SetPOID(strPOID);
            nTKTInfor.SetPONumber(strPONumber);
            OpenChidForm(nTKTInfor);
            return;
        }

        public void OpenConfirmPOForm(string strKHMS, string strContractID, string strPOID, string strPONumber)
        {
            ConfirmPOInfor confirmPO = new ConfirmPOInfor();
            confirmPO.SetKHMS(strKHMS);

            strContractID = strContractID.Replace("Contract_", "");
            confirmPO.SetContractID(strContractID);
            confirmPO.SetPOID(strPOID);
            confirmPO.SetPONumber(strPONumber);
            OpenChidForm(confirmPO);
            return;
        }
        public void OpenDescription(String idSite)
        {
          
            DescriptionSiteForm descriptionSiteForm = new DescriptionSiteForm();            
            SiteInfo siteInfo = new SiteInfo();
            
            siteInfo.GetSiteInfo(idSite, ref siteInfo);
            descriptionSiteForm.setId(siteInfo.Id);
            descriptionSiteForm.setAccount(siteInfo.Account);
            descriptionSiteForm.setAddress(siteInfo.Address);
            descriptionSiteForm.setFax(siteInfo.Tin);
            descriptionSiteForm.setHeadquater(siteInfo.HeadquaterInfo);
            descriptionSiteForm.setPhone(siteInfo.Phonenumber);
            descriptionSiteForm.setRepresentative(siteInfo.Representative);
            OpenChidForm1(descriptionSiteForm);
            return;
        }

    }
}
