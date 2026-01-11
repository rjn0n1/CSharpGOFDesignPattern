using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class LazySingleton //sealed prevents inheritance that can break the Singleton guarantee.instance control,
    {
        //create an instace var
        private static LazySingleton lazySingleton;

        public static LazySingleton Instance //public get property
        {
            get
            {
                if (lazySingleton == null)
                {
                    lazySingleton = new LazySingleton();
                }
                return lazySingleton;
            }
        }
        private LazySingleton()  //private prevents the instanciation
        {

        }
    }
}
