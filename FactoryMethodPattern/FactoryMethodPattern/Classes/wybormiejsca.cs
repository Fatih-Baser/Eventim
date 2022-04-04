using System;
namespace FactoryMethodPattern.Classes
{
    internal class wybormiejsca : factory
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
                    throw new ApplicationException(String.Format("crashed", Miejsca));
            }
        }
    }
}