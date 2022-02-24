using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFG_LaboGSB.Classes
{
    [AddINotifyPropertyChangedInterface]
    public partial class Visiteur
    {
        public int VIS_ID { get; set; }
        public string VIS_NOM { get; set; }
        public string VIS_PRENOM { get; set; }
        public string VIS_MDP { get; set; }
        public string VIS_LOGIN { get; set; }
    }

}
