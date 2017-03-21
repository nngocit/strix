using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.DTO
{
      
    class DTO_TruongHoc
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }

        public DTO_TruongHoc()
        {

        }
        public DTO_TruongHoc(string ten, string diachi, string dienthoai)
        {
            NAME = ten;
            ADDRESS = diachi;
            PHONE = dienthoai;
        }
        public DTO_TruongHoc(int id,string ten, string diachi, string dienthoai)
        {
            ID = id;
            NAME = ten;
            ADDRESS = diachi;
            PHONE = dienthoai;
        }

    }
}
