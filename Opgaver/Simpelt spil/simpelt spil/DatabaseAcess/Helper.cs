using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace simpelt_spil.DatabaseAcess
{
    class Helper
    {
        /// <summary>
        /// So you can connect to database through App.config
        /// </summary>
        /// <param name="name">DB as it says in App.config</param>
        /// <returns></returns>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
