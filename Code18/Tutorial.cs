using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code18
{
    class Tutorial
    {
        public int TId;
        public string TName;

        public void SetTute(int MId,string MName)
        {
            TId = MId;
            TName = MName;
        }

        public string GetTute()
        {
            return  TName;
        }
        public int GetID()
        {
            return TId;
        }

    }
}
