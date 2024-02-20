using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.DTO
{
    [Serializable]
    public class DataInfo
    {
        public string ServerName { get; set; }
        public string SqlUserName { get; set; }
        public string SqlPassword { get; set; }

        public string DataBaseName { get; set; }

        public string PathGescom { get; set; }

    }
}
