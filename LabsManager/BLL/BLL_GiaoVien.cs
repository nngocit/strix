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
using System;

namespace LabsManager.BLL
{
    class BLL_GiaoVien
    {
        DataBase data;
        public BLL_GiaoVien(string path)
       {
        data = new DataBase(path);
       }
        public DataTable GiaoVienLoad(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_GiaoVienLoad", CommandType.StoredProcedure, ref err
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable LichGiaoVien(ref string err, DTO_GiaoVien gv)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_LichGiaoVienSelect", CommandType.StoredProcedure, ref err
                 , new SqlParameter("@ID_TEACHER", gv.ID_TEACHER)
                   , new SqlParameter("@ID_CLASS", gv.ID_CLASS)
                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }


        public DataTable GiaoVienThem(ref string err, DTO_GiaoVien gv)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_GiaoVienThem", CommandType.StoredProcedure, ref err
                 , new SqlParameter("@NAME_TEACHER", gv.NAME_TEACHER)
              
                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable GiaoVienCapNhat(ref string err, DTO_GiaoVien gv)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_GiaoVienCapNhat", CommandType.StoredProcedure, ref err
                 , new SqlParameter("@NAME_TEACHER", gv.NAME_TEACHER)
                   , new SqlParameter("@ID_TEACHER", gv.ID_TEACHER)

                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable GiaoVienXoa(ref string err, DTO_GiaoVien gv)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_GiaoVienXoa", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@ID_TEACHER", gv.ID_TEACHER)

                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }




        public DataTable GiaoVienCalenThem(ref string err, DTO_GiaoVien gv)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_CalenThem", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@ID", gv.ID_TEACHER)
                       , new SqlParameter("@IDclass", gv.ID_CLASS)
                       , new SqlParameter("@date", gv._Date)
                       , new SqlParameter("@im", gv.IM)
                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable GiaoVienCalenCapNhat(ref string err, DTO_GiaoVien gv,int stt)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_CalenUpdate", CommandType.StoredProcedure, ref err
                    , new SqlParameter("@STT", stt)
                    , new SqlParameter("@ID", gv.ID_TEACHER)
                       , new SqlParameter("@IDclass", gv.ID_CLASS)
                       , new SqlParameter("@date", gv._Date)
                       , new SqlParameter("@im", gv.IM)
                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable GiaoVienCalenXoa(ref string err, int ma)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_CalenXoa", CommandType.StoredProcedure, ref err
                   , new SqlParameter("@STT", ma)
                   
                    );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }



        public DataTable GiaoVienCalenLoad(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_CalenLoad", CommandType.StoredProcedure, ref err
            
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
