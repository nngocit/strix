using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using LabsManager.DAO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabsManager.DTO;
using System.Data.SqlClient;
using System.IO;

namespace LabsManager.BLL
{
    class BLL_bkrt
    {
           DataBase data;

           public BLL_bkrt(string path)
           {
               data = new DataBase(path);
           }

     
        public  bool Ng_TK_SaoLuu(ref string err, string dataname, string str)
        {
            data = new DataBase(cls_Main.duongdanfileketnoi);
            return data.MyExcuteNonQuery("sp_BackupLabs", CommandType.StoredProcedure, ref err
                 , new SqlParameter("@ten", dataname)
                 , new SqlParameter("@diachi", str)
               );
        }
        public DataTable Ng_TK_SaoLuu1(ref string err, string dataname, string str)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_SaoLuuu", CommandType.StoredProcedure, ref err
                 , new SqlParameter("@NameData", dataname)
                   , new SqlParameter("@Addr", str)
                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
         
        }
        public  bool Phuchoi(string sql, ref string err)
        {
            data = new DataBase(cls_Main.duongdanfileketnoi);
            return data.MyExcuteNonQuery(sql, CommandType.Text, ref err, null);

        }
        public bool SaoLuu(ref string err, string sql)
        {
            data = new DataBase(cls_Main.duongdanfileketnoi);
            return data.MyExcuteNonQuery(sql, CommandType.Text, ref err, null);

        }
    }
}
