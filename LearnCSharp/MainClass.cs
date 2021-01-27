using app; // NameSpace
using app2;// NameSpace
using Loop;// NameSpace
using Controlstatement;// NameSpace
using arrays;
// OOPs Concepts
namespace LearnCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Namespace Concept
            _Data d = new _Data();
            _Data2 d2 = new _Data2();
            d.app();
            d2.app();

            // Loop Object 
            Loops l = new Loops();
            // Loops
            l.loop_for();
            // Loops
            l.loop_while();
            // Loops
            l.loop_do_while();

            // Statement Object
            ControlStatement s = new ControlStatement();
            // Statement
            s._if_statement();
            // Statement
            s._if_else_statement();
            // Statement
            s._if_elseif_statement();

            // Array Object
            Arrays ar = new Arrays();
            ar._array();
        }
    }
}

