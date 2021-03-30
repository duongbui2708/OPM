using OPM.DBHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OPM.OPMEnginee
{
    class SiteInfo : ISiteInfo
    {
        private string _id;
        private string _type;
        private string _headquaterInfo;
        private string _address;
        private string _phonenumber;
        private string _tin;
        private string _account;
        private string _representative;

        public SiteInfo()
        {
        }

        public SiteInfo(string id, string type, string headquaterInfo, string address, string phonenumber, string tin, string account, string representative)
        {
            Id = id;
            Type = type;
            HeadquaterInfo = headquaterInfo;
            Address = address;
            Phonenumber = phonenumber;
            Tin = tin;
            Account = account;
            Representative = representative;
        }

        public string Id { get => _id; set => _id = value; }
        public string Type { get => _type; set => _type = value; }
        public string HeadquaterInfo { get => _headquaterInfo; set => _headquaterInfo = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }
        public string Tin { get => _tin; set => _tin = value; }
        public string Account { get => _account; set => _account = value; }
        public string Representative { get => _representative; set => _representative = value; }
<<<<<<< HEAD
        
=======
>>>>>>> b509c2c9bcd2219a602f23a229b723a7d425a6d1

        public int GetSiteInfo(string idSiteInfo, ref SiteInfo siteInfo)
        {
            string strQueryOne = "SELECT DISTINCT * FROM Site_Info  WHERE Site_Info.id =" + "'" + idSiteInfo + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                siteInfo.Id = (string)ds.Tables[0].Rows[0].ItemArray[0];
                siteInfo.Type = (string)ds.Tables[0].Rows[0].ItemArray[1];
                siteInfo.HeadquaterInfo = (string)ds.Tables[0].Rows[0].ItemArray[2];
                siteInfo.Address = (string)ds.Tables[0].Rows[0].ItemArray[3];
                siteInfo.Phonenumber = (string)ds.Tables[0].Rows[0].ItemArray[4];
                siteInfo.Tin = (string)ds.Tables[0].Rows[0].ItemArray[5];
                siteInfo.Account = (string)ds.Tables[0].Rows[0].ItemArray[6];
                siteInfo.Representative = (string)ds.Tables[0].Rows[0].ItemArray[7];
            }
            else
            {
                return 0;
            }
            return 1;
        }


        public int GetSiteInfoObject(string idContract, ref SiteInfo siteInfo)
        {
            string strQueryOne = "SELECT DISTINCT * FROM Contract INNER JOIN Site_Info ON Site_Info.id COLLATE SQL_Latin1_General_CP1_CI_AS = Contract.id_siteB WHERE Contract.id =" + "'" + idContract + "'";
            DataSet ds = new DataSet();
            int ret = OPMDBHandler.fQuerryData(strQueryOne, ref ds);
            if (0 != ds.Tables.Count)
            {
                siteInfo.Id = (string)ds.Tables[0].Rows[0].ItemArray[14];
                siteInfo.Type = (string)ds.Tables[0].Rows[0].ItemArray[15];
                siteInfo.HeadquaterInfo = (string)ds.Tables[0].Rows[0].ItemArray[16];
                siteInfo.Address = (string)ds.Tables[0].Rows[0].ItemArray[17];
                siteInfo.Phonenumber = (string)ds.Tables[0].Rows[0].ItemArray[18];
                siteInfo.Tin = (string)ds.Tables[0].Rows[0].ItemArray[19];
                siteInfo.Account = (string)ds.Tables[0].Rows[0].ItemArray[20];
                siteInfo.Representative = (string)ds.Tables[0].Rows[0].ItemArray[21];
            }
            else
            {
                return 0;
            }
            return 1;
        }
    }
}
