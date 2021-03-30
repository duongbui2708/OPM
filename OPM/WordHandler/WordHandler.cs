using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using WordOffice = Microsoft.Office.Interop.Word;
using System.Reflection;
using OPM.OPMEnginee;

namespace OPM.WordHandler
{
    class OpmWordHandler
    {
        private string _nameWordfile;
        public OpmWordHandler()
        {
        }
        ~OpmWordHandler()
        { }

        public string FileName
        {
            set { _nameWordfile = value; }
            get { return _nameWordfile; }
        }
        public static void FindAndReplace(WordOffice.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        public static void CreateWordDocument(object filename, object SaveAs, string strName, string strFirstname, string strBirthday, string strDate)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<name>", strName);
                FindAndReplace(wordApp, "<firstname>", strFirstname);
                //this.FindAndReplace(wordApp, "<birthday>", dateTimePicker1.Value.ToShortDateString());
                FindAndReplace(wordApp, "<birthday>", strBirthday);
                //this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                FindAndReplace(wordApp, "<date>", strDate);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        public static void Create_BLTU_Contract(object filename, object SaveAs, string strPOnumber, string strIdContract, string strSigndate, string strPOdate)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<tempPO>" , " " + strPOnumber + " ");
                FindAndReplace(wordApp, "<temp_IdContract>", " " + strIdContract + " ");
                //this.FindAndReplace(wordApp, "<birthday>", dateTimePicker1.Value.ToShortDateString());
                FindAndReplace(wordApp, "<tmp_signdate>", " " + strSigndate + " ");
                //this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                FindAndReplace(wordApp, "<date_po>", " " + strPOdate + " ");
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }
        public static void Create_BLTH_PO(object filename, object SaveAs,string strPOnumber)
        { }
        public static void Create_BLTU_PO(object filename, object SaveAs,string strPOnumber, string strIdContract, string strContractName, string strSigneddateContract, string strPOSigneddate, string strPOValueNotVAT, string strPOValueTU, string strSiteB, string strActiveDatePO)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<PO_Name>", " " + strPOnumber);
                FindAndReplace(wordApp, "<Contract_ID>", " " + strIdContract);
                FindAndReplace(wordApp, "<Contract_Name>", " " + strContractName);
                FindAndReplace(wordApp, "<Signed_DateContract>", " " + strSigneddateContract);
                FindAndReplace(wordApp, "<Signed_DatePO>", " " + strPOSigneddate);
                FindAndReplace(wordApp, "<Total_Value>", " " + strPOValueNotVAT);
                FindAndReplace(wordApp, "<Value_Tamung>", " " + strPOValueTU);
                FindAndReplace(wordApp, "<Site_B>", " " + strSiteB);
                FindAndReplace(wordApp, "<Active_Date>", " " + strActiveDatePO);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Bảo Lãnh Thực Hiện Created!");
        }
        public static void Create_DNTU_PO(object filename, object SaveAs)
        { }
        public static void Create_RQNTKT_PO(object filename, object SaveAs, NTKT nTKT, PO objPO, ContractObj contractObj)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<dd>"," " + DateTime.Now.ToString("dd") + " ");
                FindAndReplace(wordApp, "<MM>", " " + DateTime.Now.ToString("MM") + " ");
                FindAndReplace(wordApp, "<yyyy>", " " + DateTime.Now.ToString("yyyy") + " ");

                FindAndReplace(wordApp, "<NTKT_ID>", " " + nTKT.ID_NTKT + " ");
                FindAndReplace(wordApp, "<Date_NTKT_DuKien>", " " + nTKT.DateDuKienNTKT + " ");

                FindAndReplace(wordApp, "<PO_Number>", " " + nTKT.PONumber + " ");
                FindAndReplace(wordApp, "<PO_ID>", " " + nTKT.POID + " ");
                FindAndReplace(wordApp, "<Created_DatePO>", " " + objPO.DateCreatedPO + " ");

                FindAndReplace(wordApp, "<KHMS>", " " + nTKT.KHMS + " ");
                FindAndReplace(wordApp, "<Contract_ID>", " " + nTKT.IDContract + " ");
                FindAndReplace(wordApp, "<Contract_Name>", " " + contractObj.NameContract + " ");
                FindAndReplace(wordApp, "<SignedDate_Contract>", " " + contractObj.DateSigned + " ");
                FindAndReplace(wordApp, "<Site_B>", " " + contractObj.SiteB + " ");

                FindAndReplace(wordApp, "<Mr_PhoBan>", " " + nTKT.MrPhoBan + " ");
                FindAndReplace(wordApp, "<Mobile>", " " + nTKT.MrPhoBanMobile + " ");

                FindAndReplace(wordApp, "<Mr_GD_HTKT_CSKH>", " " + nTKT.MrGD_CSKH + " ");
                FindAndReplace(wordApp, "<Mr_GD_Mobile>", " " + nTKT.MrGD_CSKH_mobile + " ");

                FindAndReplace(wordApp, "<MrGDLandLine>", " " + nTKT.MrGD_CSKH_Landline + " ");
                FindAndReplace(wordApp, "<Ext>", " " + nTKT.MrrGD_CSKH_LandlineExt + " ");

            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Yêu Cầu Nghiệm Thu Kỹ Thuật Đã Được Created!");
        }

        public static void PrintDocument(object filename)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                myWordDoc.Application.ActivePrinter = "PCL6 V4 Driver for Universal Print";
                myWordDoc.PrintOut();
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        public static void PrintDocumentA(object filename)
        {
            return;
        }

        public static void  CreateBLTH_Contract(object filename, object SaveAs, string strContractCode, string strContractName, string strSigneddate,string tbxSiteB,string txbGaranteeValue,string txbGaranteeActiveDate)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<Contract_Code>", " " + strContractCode + " ");
                FindAndReplace(wordApp, "<Contract_Name>", " " + strContractName + " ");
                FindAndReplace(wordApp, "<Signed_Date>", " " + strSigneddate + " ");
                FindAndReplace(wordApp, "<Site_B>", " " + tbxSiteB + " ");
                FindAndReplace(wordApp, "<Grt_Val>", " " + txbGaranteeValue + " ");
                FindAndReplace(wordApp, "<Grt_Act_Date>", " " + txbGaranteeActiveDate + " ");

            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Bảo Lãnh Thực Hiện Hợp Đồng Đã Được Tạo");
        }
           
        public static void Create_VBConfirm_PO(object filename, object SaveAs, ConfirmPO confirmPO, PO objPO, ContractObj contractObj)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<dd>", " " + DateTime.Now.ToString("dd") + " ");
                FindAndReplace(wordApp, "<MM>", " " + DateTime.Now.ToString("MM") + " ");
                FindAndReplace(wordApp, "<yyyy>", " " + DateTime.Now.ToString("yyyy") + " ");

                FindAndReplace(wordApp, "<XNDH_ID>", " " + confirmPO.ConfirmPOID + " ");
                FindAndReplace(wordApp, "<DateNow>", " " + DateTime.Now.ToString("dd/MM/yyyy") + " ");


                FindAndReplace(wordApp, "<PO_Number>", " " + confirmPO.PONumber + " ");
                FindAndReplace(wordApp, "<PO_ID>", " " + confirmPO.POID + " ");
                FindAndReplace(wordApp, "<PO_DateCreated>", " " + objPO.DateCreatedPO + " ");

                FindAndReplace(wordApp, "<KHMS>", " " + confirmPO.KHMS + " ");
                FindAndReplace(wordApp, "<Contract_ID>", " " + confirmPO.IDContract + " ");
                FindAndReplace(wordApp, "<Contract_Name>", " " + contractObj.NameContract + " ");
                FindAndReplace(wordApp, "<Contract_DateSigned>", " " + contractObj.DateSigned + " ");
                FindAndReplace(wordApp, "<Site_B>", " " + contractObj.SiteB + " ");

                FindAndReplace(wordApp, "<MrPhoBan>", " " + confirmPO.MrPhoBan + " ");
                FindAndReplace(wordApp, "<Mobile>", " " + confirmPO.MrPhoBanMobile + " ");

                FindAndReplace(wordApp, "<MrGDCSKH>", " " + confirmPO.MrGD_CSKH + " ");
                FindAndReplace(wordApp, "<MrGDMobile>", " " + confirmPO.MrGD_CSKH_mobile + " ");

                FindAndReplace(wordApp, "<LandLine>", " " + confirmPO.MrGD_CSKH_Landline + " ");
                FindAndReplace(wordApp, "<Ext>", " " + confirmPO.MrrGD_CSKH_LandlineExt + " ");

            }
            else
            {
                MessageBox.Show("File Xác Nhận Đơn Hàng Not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Xác Nhận Đơn Hàng Đã Được Created!");
        }


        public static void Create_BBKTKT_HH(object filename, object SaveAs,ContractObj contractObject ,PO objPO, NTKT nTKT, SiteInfo siteInfo)
        {
            WordOffice.Application wordApp = new WordOffice.Application();
            object missing = Missing.Value;
            WordOffice.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                FindAndReplace(wordApp, "<PO_Number>", " " + objPO.PONumber + " ");
                FindAndReplace(wordApp, "<PO_ID>", " " + objPO.IDPO + " ");
                FindAndReplace(wordApp, "<PO_CreatedDate>", " " + objPO.DateCreatedPO + " ");
                FindAndReplace(wordApp, "<XNDH_ID>", " " + objPO.IDPO + " ");
                FindAndReplace(wordApp, "<XNDH_CreatedDate>", " " + objPO.DefaultActiveDatePO + " ");
                FindAndReplace(wordApp, "<NTKT_ID>", " " + nTKT.ID_NTKT + " ");
                FindAndReplace(wordApp, "<NTKT_CreatedDate>", " " + nTKT.getCreateDate + " ");
                FindAndReplace(wordApp, "<DC>", " " + objPO.NumberOfDevice + " ");
                FindAndReplace(wordApp, "<PDC>", " " + (Math.Round((objPO.NumberOfDevice)*0.02)) + " ");
                FindAndReplace(wordApp, "<DateNow>", " " + DateTime.Now.ToString("dd/MM/yyyy") + " ");
                FindAndReplace(wordApp, "<Contract_ID>", " " + contractObject.IdContract + " ");
                FindAndReplace(wordApp, "<Contract_Name>", " " + contractObject.NameContract + " ");
                FindAndReplace(wordApp, "<KHMS>", " " + contractObject.KHMS + " ");
                FindAndReplace(wordApp, "<Contract_DateSigned>", " " + contractObject.DateSigned + " ");
                FindAndReplace(wordApp, "<Site_B>", " " + contractObject.SiteB + " ");

                FindAndReplace(wordApp, "<Address_Site_B>", " " + siteInfo.Address + " ");
                FindAndReplace(wordApp, "<LandLine_Site_B>", " " + siteInfo.Phonenumber + " ");
                FindAndReplace(wordApp, "<Fax_Site_B>", " " + siteInfo.Tin + " ");

            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Biên Bản Kiểm Tra Kĩ Thuật Hàng Hóa Được Tạo");
        }
    }
}
