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

namespace LabsManager.BLL
{
    class BLL_LoaiThietBi
    {
         DataBase data;

         public BLL_LoaiThietBi(string path)
       {
           data = new DataBase(path);
       }


         public DataTable LoaiThietBiLoad(ref string err)
         {
             DataTable _dt = new DataTable();
             try
             {
                 return _dt = data.GetDataTable("sp_LoaiThietBiDanhSach", CommandType.StoredProcedure, ref err
                 );
             }
             catch (Exception ex)
             {
                 err = ex.Message;
                 return _dt;
             }
         }

         public DataTable ThietBiLoad(ref string err,int loai, int lop)
         {
             DataTable _dt = new DataTable();
             try
             {
                 return _dt = data.GetDataTable("sp_ThietBiLoad", CommandType.StoredProcedure, ref err
                 , new SqlParameter("@ID_INF", loai)
                 , new SqlParameter("@ID_CLASS", lop)
                     );
             }
             catch (Exception ex)
             {
                 err = ex.Message;
                 return _dt;
             }
         }
         public DataTable ThietBiLoadCombo(ref string err,int lop)
         {
             DataTable _dt = new DataTable();
             try
             {
                 return _dt = data.GetDataTable("sp_LoaiThietBiSelect", CommandType.StoredProcedure, ref err
                 , new SqlParameter("@ID_CLASS", lop)
                     );
             }
             catch (Exception ex)
             {
                 err = ex.Message;
                 return _dt;
             }
         }
         public DataTable LoaiThietBiInsert(ref string err, DTO_LoaiThietBi ltb)
         {
             DataTable _dt = new DataTable();
             try
             {
                 return _dt = data.GetDataTable("sp_TypeINF_Insert", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_CLASS", ltb.ID_CLASS1)
                , new SqlParameter("@NAMES_INF", ltb.NAMES_INF1)
                , new SqlParameter("@NUM_NOW_INF", ltb.Num_now)
                , new SqlParameter("@EXP_MACHINE", ltb.Exp_machine)
                , new SqlParameter("@DAY_INF", ltb.Day_inf)
                );
             }
             catch (Exception ex)
             {
                 err = ex.Message;
                 return _dt;
             }
         }
         public DataTable ThietBiInsert(ref string err, DTO_ThietBi ltb)
         {
             DataTable _dt = new DataTable();
             try
             {
                 return _dt = data.GetDataTable("sp_ThietBiInsert", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF", ltb.ID_INF)
                , new SqlParameter("@NAMES_INF_MAC", ltb.NAMES_INF_MAC)
                , new SqlParameter("@DAY_INF_MAC", ltb.DAY_INF_MAC)
                , new SqlParameter("@IM_MACHINE", ltb.IM_MACHINE)
                
                );
             }
             catch (Exception ex)
             {
                 err = ex.Message;
                 return _dt;
             }
         }
         public DataTable LoaiThietBiUpdate(ref string err, DTO_LoaiThietBi ltb)
         {
             DataTable _dt = new DataTable();
             try
             {
                 return _dt = data.GetDataTable("sp_TypeINF_Update", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF", ltb.ID_INF1)
                , new SqlParameter("@NAMES_INF", ltb.NAMES_INF1)
                , new SqlParameter("@NUM_NOW_INF", ltb.Num_now)
                , new SqlParameter("@EXP_MACHINE", ltb.Exp_machine)
                , new SqlParameter("@DAY_INF", ltb.Day_inf)
                );
             }
             catch (Exception ex)
             {
                 err = ex.Message;
                 return _dt;
             }
         }
         public DataTable LoaiThietBiDelete(ref string err, DTO_LoaiThietBi ltb)
         {
             DataTable _dt = new DataTable();
             try
             {
                 return _dt = data.GetDataTable("sp_TypeINF_Delete", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF", ltb.ID_INF1)
                );
             }
             catch (Exception ex)
             {
                 err = ex.Message;
                 return _dt;
             }
         }
    }
}
