using System;
using app;
using app2;

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

        }
    }
}

