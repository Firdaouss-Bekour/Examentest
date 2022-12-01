using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Examen
    {
        private DateTime DateDebut;
        private DateTime DateFin;
        private String Intitule;
        private List<Question> qsts;

        public Examen() { }

        public Examen(string Intitule, DateTime DateDebut, DateTime DateFin, List<Question> qsts)
        {

            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
            this.Intitule = Intitule;
            this.qsts = qsts;
        }

        //setter et getter DateDebut
        public DateTime getDateDebut()
        {
            return DateDebut;
        }

        public void setDateDebut(DateTime datedebut)
        {
            this.DateDebut = datedebut;
        }


        //setter et getter DateFin
        public DateTime getDateFin()
        {
            return DateFin;
        }

        public void setDateFin(DateTime datefin)
        {
            this.DateFin = datefin;
        }


        //setter et getter de intitule
        public String getIntitule()
        {
            return Intitule;
        }

        public void setIntitule(String intitule)
        {
            this.Intitule = intitule;
        }

        //setter et getter de qsts
        public void getQuestion(List<Question> qsts)
        {
            this.qsts = qsts;
        }
    }
}
