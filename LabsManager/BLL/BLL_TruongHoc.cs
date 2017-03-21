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
    class BLL_TruongHoc
    {
        DataBase data;
        public BLL_TruongHoc(string path)
       {
           data = new DataBase(path);
       }


        public DataTable TruongHocLoad(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_SchoolSelect", CommandType.StoredProcedure, ref err
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable PhongHocSelect(ref string err, int th)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ClassSelect", CommandType.StoredProcedure, ref err
                      , new SqlParameter("@SCHOOL", th)
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable PhongHocLoad(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_ClassLoad", CommandType.StoredProcedure, ref err
                    
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }


        public DataTable LopHocLoadAll(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_LopHocSelectAll", CommandType.StoredProcedure, ref err

                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }



        public DataTable TruongHocLoadAll(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_TruongHocSelectAll", CommandType.StoredProcedure, ref err

                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }


        public DataTable TruongHocInsert(ref string err,DTO_TruongHoc th)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_TruongHocInsert", CommandType.StoredProcedure, ref err
                      , new SqlParameter("@NAME", th.NAME)
                      , new SqlParameter("@ADDRESSs", th.ADDRESS)
                      , new SqlParameter("@PHONES", th.PHONE)
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable TruongHocXoa(ref string err, DTO_TruongHoc th)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_TruongHocXoa", CommandType.StoredProcedure, ref err
                  
                      , new SqlParameter("@ID", th.ID)
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable TruongHocUpdate(ref string err, DTO_TruongHoc th)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_TruongCapNhat", CommandType.StoredProcedure, ref err
                      , new SqlParameter("@ID", th.ID)
                      , new SqlParameter("@NAME", th.NAME)
                      , new SqlParameter("@DC", th.ADDRESS)
                      , new SqlParameter("@SDT", th.PHONE)
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }



        public DataTable PhongHocInsert(ref string err, DTO_PhongHoc ph)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_PhongHoc", CommandType.StoredProcedure, ref err
                      , new SqlParameter("@SCHOOL", ph.SCHOOL)
                      , new SqlParameter("@CLASSNAME", ph.NAMES)
                      
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable PhongHocCapNhat(ref string err, DTO_PhongHoc ph)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_PhongHocCapNhat", CommandType.StoredProcedure, ref err
                      , new SqlParameter("@SCHOOL", ph.SCHOOL)
                      , new SqlParameter("@NAMES", ph.NAMES)
                    , new SqlParameter("@ID_CLASS", ph.NAMES)
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable PhongHocXoa(ref string err, DTO_PhongHoc ph)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_PhongHocXoa", CommandType.StoredProcedure, ref err
             
                    , new SqlParameter("@ID_CLASS", ph.ID_CLASS)
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
