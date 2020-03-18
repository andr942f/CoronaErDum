using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpelt_spil.DatabaseAcess
{
    class NewEntry
    {
        /// <summary>
        /// Name of player, used when data will get inserted into the database
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Score of player, used when data will get inserted into the database
        /// </summary>
        public int Score { get; set; }
    }
}
