using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramStructure
{
    class _01_Statements
    {
        public _01_Statements()
        {
            //variable declaration statements
            int counter;
            float distance;
            string firstName;
            
            //assignment statements
            counter = 0;
            distance = 4.5F;
            firstName = "Isuru";
            
            //jump statements
            /*
            break;
            return;
            */
        }

        void EmptyStatement()
        {
            // the empty statement consisit of a single semicolan on a line by itself 
            // the statement does nothing and is merely a placeholder where a code
            //statement is required but you don't want an action to take place. 
            //A good example of this in a looping statement using in a delyaed processing scenario
            while (DoSomething())
                ;

            // C# recognizes a statement that contains no keyword but because the semicolon is present,
            // C# recognizes it as a statement
        }

        bool DoSomething()
        {
            return false;
        }
    }
}
