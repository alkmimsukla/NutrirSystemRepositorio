using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NutrirSystem.Data
{
    class ConvenioCopy:Convenio
    {
        public Convenio Copy()
        {
            Convenio cv = new Convenio();
            cv.nome = this.nome;
            cv.numPlano = this.numPlano;

            return(cv);
        }

    }
}
