using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class BaiNop
    {
        public String CauHoi { get; set; }
        public String CauTraLoi { get; set; }
        public BaiNop()
        {
            this.CauHoi = String.Empty;
            this.CauTraLoi = String.Empty;
        }

        public BaiNop(String _CauHoi,String _CauTraLoi)
        {
            this.CauHoi = _CauHoi;
            this.CauTraLoi = _CauTraLoi;
        }

        public override string ToString()
        {
            return this.CauHoi + '/' + this.CauTraLoi;
        }
    }
}
