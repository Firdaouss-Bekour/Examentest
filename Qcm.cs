using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Qcm : Question
    {
        private List<Proposition> propos;

        public Qcm()
        {

        }

        public Qcm(List<Proposition> propos)
        {
            this.propos = propos;
        }

        public Proposition getProposition(int nbrpropos)
        {
            return propos[nbrpropos];
        }

        public List<Proposition> getpropos()
        {
            return propos;
        }


        public void setpropos(List<Proposition> propos)
        {
            this.propos = propos;
        }


    }
}
