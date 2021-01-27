using System;
// Namespace
namespace Controlstatement
{
    // Class
    public class ControlStatement
    {
        String name = "Waleed";
        string author = "Waleed";
        // If Statement
        public void _if_statement(/* Function */)
        {
            if (name == author)
            {
                Console.WriteLine($"{name} and {author} are same strings");
            }
        }
        // If else Statement
        public void _if_else_statement(/* Function */) {
            if (name == "Ali")
            {
                Console.WriteLine($"{name} and {author} is same strings");
            }
            else
            {
                Console.WriteLine($"{name} and Ali is not same strings");
            }

        }
        // If else ladder Statement
        public void _if_elseif_statement(/* Function */) {
            if (name == "Ali")
            {
                Console.WriteLine($"{name} and {author} is same strings");
            }
            else if (name == author)
            {
                Console.WriteLine($"{name} and {author} is same strings");
            }
            else
            {
                Console.WriteLine($"{name} and Ali is not same strings");
            }

        }
    
    
    }
}
