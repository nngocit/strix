using LabsManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabsManager.DTO;
using System.Data.SqlClient;
namespace LabsManager.BLL
{
    class BLL_User
    {
        DataBase data;

        public BLL_User(string path)
       {
           data = new DataBase(path);
       }
        public DataTable DangNhap(ref string err, DTO_User _user)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt= data.GetDataTable("sp_CheckPassword", CommandType.StoredProcedure, ref err
                        , new SqlParameter("@IDUsername", _user.User)
                        , new SqlParameter("@IDPass", _user.Pass)
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }
        public DataTable ListPQ(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_UserLoadPQ", CommandType.StoredProcedure, ref err
                    
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable Them(ref string err, DTO_User _user,int idst)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_UserInsert", CommandType.StoredProcedure, ref err
                        , new SqlParameter("@IDUsername", _user.User)
                        , new SqlParameter("@IDPass", _user.Pass)
                        , new SqlParameter("@ID_TEACHER", idst)
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }

        public DataTable PhanQuyen(ref string err, int ma, int idst)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_Phanquyen", CommandType.StoredProcedure, ref err
                        , new SqlParameter("@ID_User", ma)
                        , new SqlParameter("@gt", idst)
                      
                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }


        public DataTable UserUpdate(ref string err, int ma, string  pass)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_UserUpdate", CommandType.StoredProcedure, ref err
                        , new SqlParameter("@ID_User", ma)
                        , new SqlParameter("@IDPass", pass)

                );
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return _dt;
            }
        }




        public DataTable LoadDanhSachTaiKhoan(ref string err)
        {
            DataTable _dt = new DataTable();
            try
            {
                return _dt = data.GetDataTable("sp_LoadUser", CommandType.StoredProcedure, ref err
                        
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
