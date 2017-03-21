using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.DTO
{
    class DTO_PhongHoc
    {
        public int ID_CLASS { get; set; }
        public int SCHOOL { get; set; }
        public string NAMES { get; set; }
        // contrustor chuẩn
        public DTO_PhongHoc()
        {

        }
        public DTO_PhongHoc(int matruong,string tenphong)
        {
            SCHOOL = matruong;
            NAMES = tenphong;
        }
    }
}
