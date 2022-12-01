
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Question
    {
        private String Qst;
        private int Id;

        public Question() { }

        public Question(String Qst, int Id)
        {
            this.Qst = Qst;
            this.Id = Id;
        }

        public String getQst()
        {
            return Qst;
        }

        public void setQst(String qst)
        {
            this.Qst = qst;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            this.Id = id;
        }
    }
}
