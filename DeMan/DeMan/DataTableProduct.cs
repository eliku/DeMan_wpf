using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMan
{
    public class DataTableProduct
    {
        private int _idType;                 //тип устройства
        private int _Address;                //адрес
        private string _Name;                 //наименование устройства

        public int idType
        {
            get{
                return _idType;
            }
            set {
                _idType = value;
            } 
        }

        public int Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
    }
}
