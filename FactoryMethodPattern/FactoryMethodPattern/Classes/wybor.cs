using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Classes
{
    internal class wybor : factory 
    {
        public override Interface GetMiejsca(String Miejsca)
        {
            switch (Miejsca)
            {
               
                case "miejscastandard":
                    return new miejscastandard();
                case "miejscapremium":
                    return new miejscapremium();
                default: 
                    throw new ApplicationException(String.Format("wywalilo", Miejsca));
            }
        }
    }
}
