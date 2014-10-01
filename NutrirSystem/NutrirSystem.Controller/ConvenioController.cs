using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrirSystem.Model;
using NutrirSystem.Data;

namespace NutrirSystem.Controller
{
    public class ConvenioController
    {
        ConvenioModel cm;

        public ConvenioController()
        {
            this.cm = new ConvenioModel();
        }

        public List<Convenio> RetonarListConvenios()
        { 
            return(cm.RetonarListConvenios());
        }

        public Convenio RetonarConvenio(Decimal num)
        {
            return(cm.RetonarConvenio(num));
        }

    }
}
