using System;
using System.Collections.Generic;
using System.Diagnostics;
using Soneta.Business;

[assembly: ProgramInitializer(typeof(DodatekEnova.Inicjator))]

namespace DodatekEnova
{
    class Inicjator : IProgramInitializer
    {
        void IProgramInitializer.Initialize()
        {
            Debugger.Log(0, "", "Inicjacja mojego dodatku");
          //  Debug.WriteLine("Inicjacja mojego dodatku");
        }
    }
}
