using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsandProperties
{
    class Voiture
    {

        private int _nbRoues;
        private string _name;

        public Voiture(string name ="no name" )
        {
            _name = name;
        }

        public int NbRoues {
            get; set;
        }
        public string  Name {
            get {
                return _name;
            }
            set {
                if (!String.IsNullOrEmpty(value)) {

                    _name = value;
                }

            }

        }






    }
}
