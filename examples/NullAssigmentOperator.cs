using System.Collections.Generic;

namespace DotNetLightningTalks
{
    class NullAssigmentOperator
    {
        public void OldAssigment(int? someInt) 
        {
            if (someInt is null) 
            {
                someInt = 100;
            }
        }

        public void NewAssigment(int? someInt) 
        {
            someInt ??= 100;
        }
    }
}