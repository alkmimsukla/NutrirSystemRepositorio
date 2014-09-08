using NutrirSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Model
{
    public class ModelBD
    {
        protected DBNutrirSystemEntities banco;
        
        public ModelBD() 
        {
            banco = new DBNutrirSystemEntities();
        }
    }
}
