using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrirSystem.Data;

namespace NutrirSystem.Model
{
    public class ConvenioModel:ModelBD
    {
        public ConvenioModel():base(){}

        public bool VerifConv(Decimal num)
        {
            return(this.banco.Convenio.Any(item => item.numPlano == num));
        }

        public List<Convenio> RetonarListConvenios()
        { 
            return(this.banco.Convenio.ToList());
        }


        public Convenio RetonarConvenio(Decimal num)
        {
            return (this.banco.Convenio.Where(item => item.numPlano == num).SingleOrDefault());
        }
    }
}
