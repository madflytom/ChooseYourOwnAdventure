using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace ChooseYourOwnAdventure
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity AdventureSetup2 = new AdventureSetup2();
            WorkflowInvoker.Invoke(AdventureSetup2);
        }
    }
}
