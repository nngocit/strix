using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Manager = System.Configuration.ConfigurationManager;
using Settings = System.Configuration.ConnectionStringSettings;
using System.IO;
using System.Data.SqlClient;
using DLLDungChung;


namespace LabsManager.DAO
{
    class ReadConnect
    {
        #region bienthanhvien
        private string connectionString = "";
        // SqlConnection 
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        private string iniFile = "";

        public string IniFile
        {
            get { return iniFile; }
            set { iniFile = value; }
        }
        //thuộc tính dùng kiểm tra quyền đăng nhập
        private bool windowNT = false;

        public bool WindowNT
        {
            get { return windowNT; }
            set { windowNT = value; }
        }
        private string serverName = "(local)";

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        private string instanceName = "";

        public string InstanceName
        {
            get { return instanceName; }
            set { instanceName = value; }
        }
        private string databaseName = "";

        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        private string userName = "sa";

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string passWord = "";

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string connectionTimeout = "";

        public string ConnectionTimeout
        {
            get { return connectionTimeout; }
            set { connectionTimeout = value; }
        }
        private string portNo = "";

        public string PortNo
        {
            get { return portNo; }
            set { portNo = value; }
        }
        #endregion



        #region Constructor
        public ReadConnect()
        {
        }
        /// <summary>
        /// Khởi tạo chuỗi kết nối với chuỗi kết nối trực tiếp.
        /// </summary>
        /// <param name="connectstr">Giá trị chuỗi kết nối</param>
        public ReadConnect(string connectstr)
        {
            ConnectionString = connectstr;
        }
        /// <summary>
        /// Hàm khởi tạo giá trị chuỗi kết nối
        /// </summary>
        /// <param name="server">Tên server</param>
        /// <param name="database">Tên Cơ sở dữ liệu</param>
        /// <param name="userid">tên người dùng</param>
        /// <param name="password">Mật khẩu người dùng</param>
        public ReadConnect(string server, string database, string userid, string password)
        {
            serverName = server;
            databaseName = database;
            userName = userid;
            passWord = password;
        }
        /// <summary>
        /// Hàm khởi tạo với hai thuộc tính 
        /// </summary>
        /// <param name="server">ServerName</param>
        /// <param name="database">Tên Cơ sở dữ liệu</param>
        public ReadConnect(string server, string database)
        {
            serverName = server;
            databaseName = database;
        }
        /// <summary>
        /// hàm tạo chuỗi kết nối từ tập tin ini
        /// </summary>
        /// <param name="appfile">thuộc tính xác định tập tin ini hay app.config: true là file app.config; false là file *ini</param>
        /// <param name="filename"></param>
        public ReadConnect(bool appfile, string filename)
        {
            if (!appfile)
                iniFile = filename;
        }


        #endregion

        #region method
        //phương thức dùng đề tạo ra chuỗi kết nối từ các thuộc
        //tính trong chuỗt kết nối.
        /// <summary>
        /// Ý nghĩa : Nối các thuộc tính thành chuỗi kết nối.
        /// </summary>
        /// <returns></returns>
        public string GetconnectionString()
        {
            string conString = "";
            //truong hop co instance
            if (!instanceName.Equals(""))
            {
                serverName += @"\" + instanceName;
            }
            //hàm if kiểm tra quyền đăng nhập
            if (windowNT)
            {
                conString = "server=" + serverName + ";database=" + databaseName + ";Integrated Security= true";
            }
            //đăng nhập theo quyền của SQL
            else
            {
                conString = "server=" + serverName + ";database=" + databaseName + ";uid=" + userName + ";pwd=" + passWord;
            }
            //kiểm tra giá trị thuộc tính timeout
            if (!connectionTimeout.Equals(""))
            {
                conString += ";connection Timeout=" + connectionTimeout;
            }
            //kiểm tra port
            if (!portNo.Equals(""))
            {
                conString += ";Port=" + portNo;
            }
            return conString;
        }
        /// <summary>
        /// Ý nghĩa: Lấy chuỗi kết nối từ file App.config
        /// </summary>
        /// <param name="nodeName">Tên của node chứa chuối kết nối trong file AppConfig</param>
        /// <returns></returns>
        public string GetConnectionWithAppConfig(string nodeName)
        {
            string StrApp = "";
            //namespace sủ dụng để đọc giá trị trong file xml

            Settings settings;
            settings = Manager.ConnectionStrings[nodeName];
            //namespace Manager dùng đọc giá trị trong tab có tên là nodeName trong file config
            StrApp = settings.ConnectionString;

            return StrApp;
        }
        //hàm đọc chuỗi kết nối trong file ini theo từng thuộc tính.
        /// <summary>
        /// Ý nghĩa : Lấy chuỗi kết nối trong file ini
        /// </summary>
        /// <returns></returns>
        public bool GetConnectionWithinifile()
        {
            bool ketqua = false;
            if (File.Exists(iniFile))
            {
                using (StreamReader sReader = new StreamReader(iniFile))
                {
                    string line = "";
                    while ((line = sReader.ReadLine()) != null)
                    {
                        switch ((line.Substring(0, line.IndexOf("="))).ToLower())
                        {
                            case "servername":
                                serverName = MaHoaDuLieu.giaima(GetValue(line));
                                break;
                            case "databasename":
                                databaseName = MaHoaDuLieu.giaima(GetValue(line));
                                break;
                            case "instancename":
                                instanceName = MaHoaDuLieu.giaima(GetValue(line));
                                break;
                            case "uid":
                                userName = MaHoaDuLieu.giaima(GetValue(line));
                                break;
                            case "pwd":
                                passWord = MaHoaDuLieu.giaima(GetValue(line));
                                break;
                            case "portno":
                                portNo = MaHoaDuLieu.giaima(GetValue(line));
                                break;
                            case "timeout":
                                connectionTimeout = MaHoaDuLieu.giaima(GetValue(line));


                                break;
                        }
                    }
                    connectionString = GetconnectionString();
                    ketqua = true;
                }
            }
            return ketqua;
        }


        public bool docchuoiketnoi()
        {
            bool ketqua = false;
            if (File.Exists(iniFile))
            {
                using (StreamReader sReader = new StreamReader(iniFile))
                {
                    connectionString = MaHoaDuLieu.giaima(sReader.ReadLine());
                    ketqua = true;
                }
            }
            return ketqua;
        }
        /// <summary>
        /// Ý nghĩa: Lấy chuỗi kết nối từ file int
        /// Có chỉ đường dẫn cụ thể.
        /// </summary>
        /// <param name="path">Đường dẫn file ini</param>
        /// <returns></returns>
        public bool GetConnectionWithinifile(string path)
        {
            bool ketqua = false;
            using (StreamReader sReader = new StreamReader(path))
            {
                string line = "";
                while ((line = sReader.ReadLine()) != null)
                {
                    switch ((line.Substring(0, line.IndexOf("="))).ToLower())
                    {
                        case "servername":
                            serverName = MaHoaDuLieu.giaima(GetValue(line));
                            break;
                        case "databasename":
                            databaseName = MaHoaDuLieu.giaima(GetValue(line));
                            break;
                        case "instancename":
                            instanceName = MaHoaDuLieu.giaima(GetValue(line));
                            break;
                        case "portno":
                            portNo = MaHoaDuLieu.giaima(GetValue(line));
                            break;
                        case "uid":
                            userName = MaHoaDuLieu.giaima(GetValue(line));
                            break;
                        case "pwd":
                            passWord = MaHoaDuLieu.giaima(GetValue(line));
                            break;
                        case "timeout":
                            connectionTimeout = MaHoaDuLieu.giaima(GetValue(line));
                            break;
                    }
                }
                connectionString = GetconnectionString();
                ketqua = true;
            }
            return ketqua;
        }
        //hàm lấy giá trị trong từng thuộc tính trong file ini
        /// <summary>
        /// Láy giá trị trên từng dòng trong file ini
        /// </summary>
        /// <param name="line">dữ liệu từng dòng (string)</param>
        /// <returns></returns>
        private string GetValue(string line)
        {
            string stringvalue = "";
            if (!line.Equals(""))
                stringvalue = line.Substring(line.LastIndexOf("=") + 1);
            return stringvalue;
        }

        //hàm đọc chuỗi kết nối trong file config theo dang từng thuộc tính.
        /// <summary>
        /// Ý nghĩa: Lấy giá trị từ File App.Config lấy theo từng giá trị
        /// </summary>
        /// <param name="server">Server</param>
        /// <param name="instance">Đối tượng sql</param>
        /// <param name="database">Tên Database cần kết nối</param>
        /// <param name="userid">Người dùng</param>
        /// <param name="password">Mật khẩu</param>
        /// <param name="port">Cổng</param>
        /// <param name="timeout">Thời gian kết nối</param>
        /// <returns></returns>
        public string GetConnectionStringWithAppConfig(string server, string instance, string database, string userid, string password, string port, string timeout)
        {
            string strApp = "";

            //doc thuc tinh servername
            serverName = Manager.AppSettings.Get(server);
            //doc thuoc tinh instance

            instanceName = Manager.AppSettings.Get(instance);
            //doc thuoc tinh database
            databaseName = Manager.AppSettings.Get(database);
            //doc thuoc tinh username
            userName = Manager.AppSettings.Get(userid);
            //doc thuoc tinh pass
            passWord = Manager.AppSettings.Get(password);
            //doc thuoc tinh port
            portNo = Manager.AppSettings.Get(port);
            //doc thuoc tinh timeout
            connectionTimeout = Manager.AppSettings.Get(timeout);
            strApp = GetconnectionString();


            return strApp;
        }

        #endregion
        #region ghichuoiketnoi
        /// <summary>
        /// Ghi chuỗi kết nối theo dạng ghi trên một dòng
        /// </summary>
        /// <param name="chuoiketnoi"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public bool ghichuoiketnoi(string chuoiketnoi, ref string err)
        {
            bool ketqua = false;
            try
            {
                if (!File.Exists(iniFile))
                {
                    File.Delete(iniFile);
                    StreamWriter wr = new StreamWriter(iniFile, true, Encoding.Unicode);
                    wr.WriteLine(MaHoaDuLieu.mahoa(chuoiketnoi));
                    wr.Close();
                }
                else
                {
                    StreamWriter wr = new StreamWriter(iniFile, true, Encoding.Unicode);
                    wr.WriteLine(MaHoaDuLieu.mahoa(chuoiketnoi));
                    wr.Close();
                }
                ketqua = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return ketqua;
        }
        /// <summary>
        /// Ghi chuỗi kết nối theo từng thuộc tính
        /// </summary>
        /// <param name="path">Đường dẫn chuỗi kết nối</param>
        /// <param name="err">Biến lưu lỗi</param>
        public void ghichuoiketnoinhieuthuoctinh(string path, ref string err, string servername, string database, string uid, string password)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    StreamWriter wr = new StreamWriter(path, true, Encoding.Unicode);
                    wr.WriteLine("serverName=" + MaHoaDuLieu.mahoa(servername));
                    wr.WriteLine("databasename=" + MaHoaDuLieu.mahoa(database));
                    wr.WriteLine("uid=" + MaHoaDuLieu.mahoa(uid));
                    wr.WriteLine("pwd=" + MaHoaDuLieu.mahoa(password));
                    wr.WriteLine("timeout=" + MaHoaDuLieu.mahoa("6000"));
                    wr.Close();
                }
                else
                {
                    StreamWriter wr = new StreamWriter(path, true, Encoding.Unicode);
                    wr.WriteLine("serverName=" + MaHoaDuLieu.mahoa(servername));
                    wr.WriteLine("databasename=" + MaHoaDuLieu.mahoa(database));
                    wr.WriteLine("uid=" + MaHoaDuLieu.mahoa(uid));
                    wr.WriteLine("pwd=" + MaHoaDuLieu.mahoa(password));
                    wr.Close();
                }

            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
        }
        /// <summary>
        /// Ghi thiết lập theo từng thuộc tính
        /// </summary>
        /// <param name="path"></param>
        /// <param name="err"></param>
        /// <param name="servername"></param>


        #endregion
    }
}
