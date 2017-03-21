using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.DTO
{
    class DTO_LoaiThietBi
    {
       
        public int ID_INF1 { get; set; }
        public string Day_inf { get; set; }


        public int Exp_machine { get; set; }

        public int Num_now { get; set; }


        public string NAMES_INF1 { get; set; }


        public int ID_CLASS1 { get; set; }

        public DTO_LoaiThietBi() { }
        
        public DTO_LoaiThietBi(int idinf,string name_inf1, int numn, int expmachine, string dayinf)
        {
            ID_INF1 = idinf;
            NAMES_INF1 = name_inf1;
            Num_now = numn;
            Exp_machine = expmachine;
            Day_inf = dayinf;
        }
        public DTO_LoaiThietBi(string name_inf, int numn, int expmachine, string dayinf, int idclss)
        {
            ID_CLASS1 = idclss;
            NAMES_INF1 = name_inf;
            Num_now = numn;
            Exp_machine = expmachine;
            Day_inf = dayinf;
        }
      
    }
}
