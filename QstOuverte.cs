using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class QstOuverte : Question
    {
        private String Reponse;

        //l'appel du constructeur de la classe mère
        public QstOuverte() : base() { }

        public QstOuverte(String Reponse, String Qst, int Id) : base(Qst, Id)
        {
            this.Reponse = Reponse;
        }
        //getter et setter de Reponse
        public String getReponse()
        {
            return Reponse;
        }

        public void setReponse(String reponse)
        {
            this.Reponse = reponse;
        }
    }
}
