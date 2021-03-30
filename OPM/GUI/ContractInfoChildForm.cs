using System;
using System.Windows.Forms;
using OPM.WordHandler;
using OPM.OPMEnginee;
using OPM.EmailHandler;
using System.IO;

namespace OPM.GUI
{
    

    public partial class ContractInfoChildForm : Form
    {
        /*Delegate For Request Dashboard Update Catalog Admin*/
        public delegate void UpdateCatalogDelegate(string value);
        public UpdateCatalogDelegate UpdateCatalogPanel;
        public UpdateCatalogDelegate OpenPurchaseOrderInforGUI;

        /*Delegate For Request Dashboard Open PO Form*/
        public delegate void RequestDashBoardOpenChildForm(string strIDContract, string strKHMS);
        public RequestDashBoardOpenChildForm RequestDashBoardOpenPOForm;

        /*Delegate For Request Dashboard Open Description Form*/
        public delegate void RequestDashBoardOpenDescriptionForm(string siteId);
        public RequestDashBoardOpenDescriptionForm requestDashBoardOpendescriptionForm;

        /*Object Contract for Contract form*/
        private ContractObj newContract = new ContractObj();

        public ContractInfoChildForm()
        {
            InitializeComponent();
        }

        public void State(bool state)
        {
            txbKHMS.Enabled = state;
            tbContract.Enabled = state;
            tbBidName.Enabled = state;
            tbAccountingCode.Enabled = state;
            tbxDurationContract.Enabled = state;
            txbTypeContract.Enabled = state;
            tbxValueContract.Enabled = state;
            tbxDurationPO.Enabled = state;
            txbGaranteeValue.Enabled = state;
            txbGaranteeActiveDate.Enabled = state;
            tbxSiteA.Enabled = state;
            tbxSiteB.Enabled = state;
        }

        public void SetValueItemForm(string idContract)
        {
            //Add New Comment+ Edit From local
            //Add New Comment Level2+ Edit From Local Lan 2+Change Local Lan 2
            ContractObj contract = new ContractObj();
            contract.GetDisplayContract(idContract, ref contract);
            this.txbKHMS.Text = contract.KHMS;
            this.tbContract.Text = contract.IdContract;
            this.tbBidName.Text = contract.NameContract;
            this.tbAccountingCode.Text = contract.CodeAccounting;
            dateTimePickerDateSignedPO.Value= Convert.ToDateTime(contract.DateSigned.ToString());
            dateTimePickerDurationDateContract.Value = dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(contract.DurationContract));
            this.txbTypeContract.Text = contract.TypeContract;
            this.tbxDurationContract.Text = contract.DurationContract;
            dateTimePickerActiveDateContract.Value = Convert.ToDateTime(contract.ActiveDateContract.ToString());
            this.tbxValueContract.Text = contract.ValueContract;
            this.tbxDurationPO.Text = contract.DurationGuranteePO;
            this.tbxSiteA.Text = contract.SiteA;
            this.tbxSiteB.Text = contract.SiteB;
<<<<<<< HEAD
            this.ExpirationDate.Value = Convert.ToDateTime(contract.ExperationDate.ToString());
=======
            State(false);
>>>>>>> b509c2c9bcd2219a602f23a229b723a7d425a6d1
            return;
        }

        private IContract contract = new ContractObj();
        private void button1_Click(object sender, EventArgs e)
        {
            DescriptionSiteForm descriptionSiteForm = new DescriptionSiteForm();
           
            requestDashBoardOpendescriptionForm(tbxSiteA.Text.ToString());
            descriptionSiteForm.Close();
            return;
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            string strContract = "Contract_" + tbContract.Text.ToString();
            //OpenPurchaseOrderInforGUI(temp);
            /*Request DashBoard Open PO Form*/
            RequestDashBoardOpenPOForm(strContract, txbKHMS.Text);
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

/*        private void TextBox_Changed(object sender, EventArgs e)
        {
            if(tbxDurationContract.SelectionLength > 0)
            {
                dateTimePickerDurationDateContract.Value = dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(tbxDurationContract.Text));
            }
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ret = 0;
            /*Save The Edited Contract Info */
            //ContractObj newContract = new ContractObj();
            newContract.KHMS = txbKHMS.Text;
            newContract.IdContract = tbContract.Text;
            newContract.NameContract = tbBidName.Text;
            newContract.CodeAccounting = tbAccountingCode.Text;
            newContract.DateSigned = dateTimePickerDateSignedPO.Value.ToString("yyyy-MM-dd");
            newContract.TypeContract = txbTypeContract.Text;
            newContract.DurationContract = tbxDurationContract.Text;
<<<<<<< HEAD
            dateTimePickerDurationDateContract.Value = dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(tbxDurationContract.Text));
=======
>>>>>>> b509c2c9bcd2219a602f23a229b723a7d425a6d1
            newContract.ActiveDateContract = dateTimePickerActiveDateContract.Value.ToString("yyyy-MM-dd");
            newContract.ValueContract = tbxValueContract.Text;
            newContract.DurationGuranteePO = tbxDurationPO.Text;
            newContract.SiteA = tbxSiteA.Text;
            newContract.SiteB = tbxSiteB.Text;
            newContract.ExperationDate = ExpirationDate.Value.ToString("yyyy-MM-dd");
            ret = newContract.GetDetailContract(tbContract.Text);
            if(0==ret)
            {
                /*Create Folder Contract on F Disk*/
                string strContractDirectory = "F:\\OPM\\" + tbContract.Text;
                strContractDirectory = strContractDirectory.Replace('/','_');
                strContractDirectory = strContractDirectory.Replace('-', '_');
                if (!Directory.Exists(strContractDirectory))
                {

                    Directory.CreateDirectory(strContractDirectory);
                    MessageBox.Show("Folder Contract have been created!!!");
                }

                else
                {
                    MessageBox.Show("Folder already exist!!!");

                }
                ret = newContract.InsertNewContract(newContract);
                if (0 == ret)
                {
                    MessageBox.Show(ConstantVar.CreateNewContractFail);
                }
                else
                {
                    UpdateCatalogPanel(tbContract.Text);
                    /*Create Bao Lanh Thuc Hien Hop Dong*/
                    this.Cursor = Cursors.WaitCursor;
                    string filename = @"F:\LP\MSTT_Template.docx";
                    string strBLHPName = strContractDirectory + "\\Bao_Lanh_Hop_Dong.docx";
                    OpmWordHandler.CreateBLTH_Contract(filename, strBLHPName, tbContract.Text, tbBidName.Text, dateTimePickerDateSignedPO.Value.ToString(), tbxSiteB.Text, txbGaranteeValue.Text, txbGaranteeActiveDate.Text);
                    /*Send Email To DF*/
                    OPMEmailHandler.fSendEmail("Mail From DoanTD Gmail", strBLHPName);
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                ret = newContract.UpdateExistedContract(newContract);
                
                if (0 == ret)
                {
                    MessageBox.Show(ConstantVar.CreateNewContractFail);
                }
                else
                {
                    MessageBox.Show("Update Success");
                    State(false);
                }
            }
            
            return;
        }

        private static bool isNumber(string val)
        {
            if (val != "")
            {
                return System.Text.RegularExpressions.Regex.IsMatch(val, "[^0-9]");
            }
              else return true;
        }

        private void tbxDurationContract_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (isNumber(tbxDurationContract.Text) != true && (tbxDurationContract.Text) !=null)
            {
                dateTimePickerDurationDateContract.Value= dateTimePickerDateSignedPO.Value.AddDays(Convert.ToInt32(tbxDurationContract.Text));
            } else
            {
                MessageBox.Show("only allow input numbers");
                tbxDurationContract.Text = "";
            }
        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {
            DescriptionSiteForm descriptionSiteForm = new DescriptionSiteForm();
            
            requestDashBoardOpendescriptionForm(tbxSiteB.Text.ToString());
            descriptionSiteForm.Close();
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (isNumber(txbGaranteeActiveDate.Text) != true)
            {
                ExpirationDate.Value = dateTimePickerActiveDateContract.Value.AddDays(Convert.ToInt32(txbGaranteeActiveDate.Text));
            }
            else
            {
                MessageBox.Show("only allow input numbers");
                txbGaranteeActiveDate.Text = "";
            }
=======
        private void button5_Click(object sender, EventArgs e)
        {
            State(true);
>>>>>>> b509c2c9bcd2219a602f23a229b723a7d425a6d1
        }
    }
}
