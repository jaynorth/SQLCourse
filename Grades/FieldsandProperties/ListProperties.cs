using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsandProperties
{
    class ListProperties
    {

        public ListProperties()
        {
            this.NumberList = new List<int>();
        }


        private List<int> _numberList;

        public List<int> NumberList
        {
            get { return _numberList; }
            private set { _numberList = value; }
        }



    }
}
