using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.DTO
{
    class DTO_GiaoVien
    {
        public int ID_TEACHER { get; set; }
        public string  _Date { get; set; }
        public string IM { get; set; }
        public string NAME_TEACHER { get; set; }
        public int ID_CLASS { get; set; }
         public DTO_GiaoVien()
        {

        }

         public DTO_GiaoVien(int idGV, int idclass)
        {

            ID_TEACHER = idGV;
            ID_CLASS = idclass;

        }
         public DTO_GiaoVien(string namegv)
         {

             NAME_TEACHER = namegv;
             
         }
         public DTO_GiaoVien(int idt,int idc, string ng, string  gc)
         {

             ID_TEACHER = idt;
             ID_CLASS = idc;
             _Date = ng;
             IM = gc;

         }
    }
}
