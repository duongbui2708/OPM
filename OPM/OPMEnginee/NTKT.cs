using OPM.DBHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OPM.OPMEnginee
{
    class NTKT
    {
        private string _KHMS;
        private string _idContract;
        private string _idPO;
        private string _PONumber;
        private string _idNTKT;
        private string _dateDuKienNTKT;
        private string _mrPhoBan;
        private string _mrPhoBanMobile;
        private string _mrGD_CSKH;
        private string _mrGD_CSKH_mobile;
        private string _mrGD_CSKH_Landline;
        private string _mrGD_CSKH_LandlineExt;

        private string _idProvince;
        private string _deviceName;
        private float _numberOfDevice;
        private string _typeOfDevice;
        private string _deliverDateExpected;
        private string _emailRequeststatus;
        private string _createDate;

        /*Add New*/
        public float NumberOfDevice
        {
            set { _numberOfDevice = value; }
            get { return _numberOfDevice; }
        }
        public string KHMS
        {
            set { _KHMS = value; }
            get { return _KHMS; }
        }
        public string IDContract
        {
            set { _idContract = value; }
            get { return _idContract; }
        }

        public string POID
        {
            set { _idPO = value; }
            get { return _idPO; }
        }

        public string PONumber
        {
            set { _PONumber = value; }
            get { return _PONumber; }
        }

        public string ID_NTKT
        {
            set { _idNTKT = value; }
            get { return _idNTKT; }
        }

        public string DateDuKienNTKT
        {
            set { _dateDuKienNTKT = value; }
            get { return _dateDuKienNTKT; }
        }

        public string MrPhoBan
        {
            set { _mrPhoBan = value; }
            get { return _mrPhoBan; }
        }

        public string MrPhoBanMobile
        {
            set { _mrPhoBanMobile = value; }
            get { return _mrPhoBanMobile; }
        }

        public string MrGD_CSKH
        {
            set { _mrGD_CSKH = value; }
            get { return _mrGD_CSKH; }
        }

        public string MrGD_CSKH_mobile
        {
            set { _mrGD_CSKH_mobile = value; }
            get { return _mrGD_CSKH_mobile; }
        }

        public string MrGD_CSKH_Landline
        {
            set { _mrGD_CSKH_Landline = value; }
            get { return _mrGD_CSKH_Landline; }
        }

        public string MrrGD_CSKH_LandlineExt
        {
            set { _mrGD_CSKH_LandlineExt = value; }
            get { return _mrGD_CSKH_LandlineExt; }
        }
        public string getCreateDate
        {
            set { _createDate = value; }
            get { return _createDate; }
        }

        public int CheckExistNTKT(string strIDNTKT)
        {
            string strQueryOne = "select * from NTKT where id=" + "'" + strIDNTKT + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ret)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int InsertNewNTKT(NTKT nTKT)
        {
            string strInsertNTKTNew = "insert into NTKT values (";
            strInsertNTKTNew += "'";
            strInsertNTKTNew += nTKT.ID_NTKT;
            strInsertNTKTNew += "',N'";
            strInsertNTKTNew += nTKT.POID;
            strInsertNTKTNew += "','";
            strInsertNTKTNew += nTKT.NumberOfDevice;
            strInsertNTKTNew += "','";
            strInsertNTKTNew += nTKT.DateDuKienNTKT;
            strInsertNTKTNew += "','";
            strInsertNTKTNew += "')";
            int ret = OPMDBHandler.fInsertData(strInsertNTKTNew);
            if (0 == ret)
            {
                return ret;
            }
            return 1;
        }
        public int GetObjectNTKT(string strIdNTKT, ref NTKT nTKT)
        {
            string strQueryOne = "select * from NTKT where id=" + "'" + strIdNTKT + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                nTKT.ID_NTKT = (string)ds.Tables[0].Rows[0].ItemArray[0];
                nTKT.POID = (string)ds.Tables[0].Rows[0].ItemArray[1];
                nTKT.NumberOfDevice = (int)ds.Tables[0].Rows[0].ItemArray[2];
                nTKT.DateDuKienNTKT = ((DateTime)ds.Tables[0].Rows[0].ItemArray[3]).ToString("yyyy-MM-dd");
                //nTKT.getCreateDate = ((DateTime)ds.Tables[0].Rows[0].ItemArray[5]).ToString("yyyy-MM-dd");
            }
            else
            {
                return 0;
            }
            return 1;
        }

        public int GetObjectNTKTByIDPO(string strIdPO, ref NTKT nTKT)
        {
            string strQueryOne = "select * from NTKT where id_po=" + "'" + strIdPO + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                nTKT.ID_NTKT = (string)ds.Tables[0].Rows[0].ItemArray[0];
                nTKT.POID = (string)ds.Tables[0].Rows[0].ItemArray[1];
                nTKT.NumberOfDevice = (int)ds.Tables[0].Rows[0].ItemArray[2];
                nTKT.DateDuKienNTKT = ((DateTime)ds.Tables[0].Rows[0].ItemArray[3]).ToString("yyyy-MM-dd");
                //nTKT.getCreateDate = ((DateTime)ds.Tables[0].Rows[0].ItemArray[5]).ToString("yyyy-MM-dd");
            }
            else
            {
                return 0;
            }
            return 1;
        }
        public int GetObjectNTKTGUI(string strIdNTKT, ref NTKT nTKT)
        {
            string strQueryOne = "SELECT t1.id,t1.id_po, t1.deliver_date_expected, t1.email_request_status, t2.po_number, t2.id_contract, t3.KHMS FROM NTKT t1 join PO t2 ON t1.id_po =t2.id join Contract t3 ON t2.id_Contract =t3.id where t1.id = " +"'"+ strIdNTKT + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                nTKT.ID_NTKT = (string)ds.Tables[0].Rows[0].ItemArray[0];
                nTKT.POID = (string)ds.Tables[0].Rows[0].ItemArray[1];
                nTKT.DateDuKienNTKT = ((DateTime)ds.Tables[0].Rows[0].ItemArray[2]).ToString("yyyy-MM-dd");
                nTKT.PONumber = (string)ds.Tables[0].Rows[0].ItemArray[4];
                nTKT.IDContract = (string)ds.Tables[0].Rows[0].ItemArray[5];
                nTKT.KHMS = (string)ds.Tables[0].Rows[0].ItemArray[6];
            }
            else
            {
                return 0;
            }
            return 1;
        }
        //@Dưỡng Bùi -- Lấy thông tin mã PO, PO number, idContract bằng mã NTKT
        public int getPOinfor(string idNTKT, ref string idPO, ref string PONumber, ref string idContract)
        {
            string strQueryOne = "SELECT DISTINCT PO.id, PO.po_number, PO.id_contract FROM NTKT INNER JOIN PO ON NTKT.id_po = PO.id WHERE NTKT.id = " + "'" + idNTKT + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                idPO = (string)ds.Tables[0].Rows[0].ItemArray[0];
                PONumber = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                idContract = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            else
            {
                return 0;
            }
            return 1;
        }
    }
}
