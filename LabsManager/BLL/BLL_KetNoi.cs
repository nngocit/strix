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
    class BLL_KetNoi
    {
        ReadConnect _readconnect;
        DataBase _data;

        public BLL_KetNoi()
        {
            _readconnect = new ReadConnect();
            _data = new DataBase();
        }

        public BLL_KetNoi(string path)
        {
            if (File.Exists(path))
                _data = new DataBase(path);
        }
        public BLL_KetNoi(string path, ketnoi _ketnoi)
        {
            if (File.Exists(path))
                _data = new DataBase(path, _ketnoi);
        }


        #region Các phương thức trong lớp BLL_KetNoi
        public bool saveduongdan(string path, ref string err, string username, string database, string uid, string pwd)
        {
            bool ketqua = false;
            try
            {
                _readconnect.ghichuoiketnoinhieuthuoctinh(path, ref err, username, database, uid, pwd);
                ketqua = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return ketqua;

        }

        public bool kiemtraketnoi(string path)
        {
            _data = new DataBase(path);
            return _data.kiemtraketnoi();
        }
        public void LayThongtinchuoiketnoi()
        {

        }


        #endregion
    }
}
