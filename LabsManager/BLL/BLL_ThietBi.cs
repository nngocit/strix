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
    class BLL_ThietBi
    {

        DataBase data;
        public BLL_ThietBi(string path)
       {
           data = new DataBase(path);
       }

        public DataTable ThietBiLoad(ref string err, int thietbi)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("HistoryMachineLoad", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF_MAC", thietbi)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable MuonThietBi(ref string err,DTO_ThietBi tb)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ThueThietBi", CommandType.StoredProcedure, ref err
                , new SqlParameter("@STT", tb.STT)

                    , new SqlParameter("@STT_CALEN", tb.ID_CALEN)
                   , new SqlParameter("@ID_INF_MAC", tb.ID_INF_MAC)
                      , new SqlParameter("@ID_STATUS", tb.ID_STATUS)
                         , new SqlParameter("@ID_TEACHER", tb.ID_TEACHER)
                            , new SqlParameter("@DATE_TIME", tb.DATE_TIME)
                            , new SqlParameter("@REASON_RENT", tb.REASON_RENT)
                            , new SqlParameter("@DATE_RENT", tb.DATE_RENT)

               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable HongThietBi(ref string err, DTO_ThietBi tb)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_BaoHongThietBi", CommandType.StoredProcedure, ref err
                , new SqlParameter("@STT", tb.STT)
                , new SqlParameter("@STT_CALEN", tb.ID_CALEN)
                , new SqlParameter("@ID_INF_MAC", tb.ID_INF_MAC)
                , new SqlParameter("@DATE", tb.DATE_TIME)
                , new SqlParameter("@DATE_FIX", tb.DATE_FIX)
                , new SqlParameter("@_REASON_FIX", tb.REASON_FIX)
                , new SqlParameter("@_REASON_ERROR", tb.REASON_ERROR)
                  
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable ThietBiKhongHoatDong(ref string err, DTO_ThietBi tb,int a)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ThietBiKhonghd", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF_MAC", tb.ID_INF_MAC)
                , new SqlParameter("@a", a)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
       
        public DataTable ThietBiDangMuon(ref string err, DTO_ThietBi tb)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_spKiemTraThietBiCoMuon", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF_MAC", tb.ID_INF_MAC)
 
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable TinhTrangThietBi(ref string err, DTO_ThietBi tb)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_spKiemTraTinhTrangThietBi", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF_MAC", tb.ID_INF_MAC)

               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable ThietBiGetMax(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_LayMaxHis", CommandType.StoredProcedure, ref err

               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }



        public DataTable ThietBiSelectThongTinTBMuon(ref string err, int thietbi)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ThongTinThietBiMuon", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF_MAC", thietbi)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable ThietBiSelectThongTinTBHong(ref string err, int thietbi)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ThongTinThietBiMuon", CommandType.StoredProcedure, ref err
                , new SqlParameter("@ID_INF_MAC", thietbi)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }


        public DataTable TraThietBi(ref string err, DTO_ThietBi tb)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_TraThietBi", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@DATE_RENT_COMPLETE", tb.DATE_RENT)
                   , new SqlParameter("@STT", tb.STT)
                   , new SqlParameter("@ID_INF_MAC", tb.ID_INF_MAC)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable TraThietBi_Tra(ref string err, DTO_ThietBi tb)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_TraThietBi_Hong", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@_DATE_FIX_COMPLETE", tb.DATE_RENT)
                   , new SqlParameter("@STT", tb.STT)
                   , new SqlParameter("@ID_INF_MAC", tb.ID_INF_MAC)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable GetSTT(ref string err,int STT)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_GetSTT", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@ID_INF_MAC", STT)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }



        public DataTable GetSTT_Tra(ref string err, int STT)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_GetSTT_Tra", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@ID_INF_MAC", STT)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable ThietBiDel(ref string err, int ma)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ThietBiDel", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@a", ma)
               );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable TKThietBiCacLop(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ThongKeAllCacClass", CommandType.StoredProcedure, ref err
                  
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
