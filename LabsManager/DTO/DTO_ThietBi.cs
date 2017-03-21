using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.DTO
{
    class DTO_ThietBi
    {   public int ID_INF { get; set; }
        public int ID_CALEN { get; set; }
        public string NAMES_INF_MAC { get; set; }
        public string DAY_INF_MAC { get; set; }
        public string IM_MACHINE { get; set; }
        public int STT { get; set; }
        public int ID_STATUS { get; set; }
        public int ID_TEACHER { get; set; }
        public int ID_INF_MAC { get; set; }
        public string DATE_TIME { get; set; }
        public string REASON_RENT { get; set; }
        public string REASON_FIX { get; set; }
        public string DATE_RENT { get; set; }
        public string DATE_RENT_Complete { get; set; }
        public string REASON_ERROR { get; set; }
        public string DATE_FIX_Complete { get; set; }
        public string DATE_FIX{ get; set; }
        public DTO_ThietBi()
        {

        }
        public DTO_ThietBi( int idmac)
        {
            ID_INF_MAC = idmac;
        }
        public DTO_ThietBi(string dtcom, int stt, int idmac)
        {
            DATE_RENT_Complete = dtcom;
            STT = stt;
            ID_INF_MAC = idmac;
        }

        public DTO_ThietBi(int id, string ten, string ng, string ghichu)
        {
            ID_INF = id;
            NAMES_INF_MAC = ten;
            DAY_INF_MAC = ng;
            IM_MACHINE = ghichu;
        }

          public DTO_ThietBi(int stt,int idcalen,int id_inf_mac ,int id_status_int, int id_teacher,string date_time, string reason_rent,string date_rent)
        {
           
        STT =stt;
        ID_CALEN = idcalen;
	    ID_INF_MAC =id_inf_mac;
	    ID_STATUS =id_status_int;
	    ID_TEACHER =id_teacher;
	    DATE_TIME =date_time;
	    REASON_RENT =reason_rent;
        DATE_RENT = date_rent;
        }

          public DTO_ThietBi(int st, int idcl, int id_inf_m, string date, string date_timefix, string reason_fix, string reason_error)
          {

              STT = st;
              ID_CALEN = idcl;
              ID_INF_MAC = id_inf_m;
              DATE_TIME = date;
              DATE_FIX = date_timefix;
              REASON_FIX = reason_fix;
              REASON_ERROR = reason_error;
           
          }
    }
}
