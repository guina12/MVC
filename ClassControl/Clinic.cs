using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace turn.ClassControl
{
    public class Clinic
    {
        public string NameClinic {get;set;}
        public Medic medics {get;set;}
        

        public Clinic(){

        }

        public Clinic(string nameClinic, Medic medics)
        {
            NameClinic = nameClinic;
            this.medics = medics;
        }
    }
}  
    



        