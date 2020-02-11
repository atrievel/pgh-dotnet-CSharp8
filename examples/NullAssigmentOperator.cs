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

            // do some work
        }

        public void NewAssigment(int? someInt) 
        {
            someInt ??= 100;
        }

        // do some work
    }
}