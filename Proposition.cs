using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Proposition
    {
        private int id;
        private bool val;
        private String proposition;

        public Proposition()
        {

        }
        public Proposition(int id, bool val, String proposition)
        {
            this.id = id;
            this.val = val;
            this.proposition = proposition;

        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }



        public bool getVal()
        {
            return val;
        }
        public void setVal(bool val)
        {
            this.val = val;
        }


        public String getProposition()
        {
            return proposition;
        }
        public void setProposition(String proposition)
        {
            this.proposition = proposition;
        }
    }
}
