using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_Rabota.FormsDB.Components
{
    internal class Items
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public int Manufacture_id { get; set; }
        public int Type_id { get; set; }
        public int In_storage { get; set; }
        public decimal Price { get; set; }

    }
}
