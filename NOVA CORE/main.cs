using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOVA_CORE
{
    public class main
    {
        string releasedate = "01.08.2022";
        string verMajor = "1"; 
        string verminor = "0"; 
        string build_no = "0"; 
        string revison_no = "1";  
        string build_spec = "<alpha>";


        public string welcome()
        {
            string res = " v" + verMajor + "." + verminor + "  Build " + build_no + " " + build_spec;
            return res;
        }
        public string build()
        {
            string res = build_no + " " + build_spec;
            return res;
        }
        public string vernu()
        {
            string res = "v "+ verMajor +"." + verminor+ "." + build_no + "."+ revison_no;
            return res;
        }

        public string version()
        {
            string res = verMajor + "." + verminor + "." + build_no + "." + revison_no;
            return res;
        }
        public string reldate()
        {
            string res = releasedate;
            return res;
        }
    }
}
