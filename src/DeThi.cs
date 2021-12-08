using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class DeThi
    {
        public String NoiDung { get; set; }
        public String DapAnA { get; set; }
        public String DapAnB { get; set; }
        public String DapAnC { get; set; }
        public String DapAnD { get; set; }

        public DeThi()
        {
            this.NoiDung = String.Empty;
            this.DapAnA = String.Empty;
            this.DapAnB = String.Empty;
            this.DapAnC = String.Empty;
            this.DapAnD = String.Empty;
        }

        public DeThi(String _NoiDung, String _DapAnA, String _DapAnB, String _DapAnC, String _DapAnD)
        {
            this.NoiDung = _NoiDung;
            this.DapAnA = _DapAnA;
            this.DapAnB = _DapAnB;
            this.DapAnC = _DapAnC;
            this.DapAnD = _DapAnD;
        }

        public override string ToString()
        {
            return this.NoiDung + "|" + this.DapAnA + "|" + this.DapAnB + "|" + this.DapAnC + "|" + this.DapAnD;
        }
    }
}
