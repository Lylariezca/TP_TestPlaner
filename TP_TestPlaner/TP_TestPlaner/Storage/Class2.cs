using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TestPlaner.Storage
{
    public interface IStorage
    {

        List<Tester> GetTester();
        List<Testauftraege> GetTestauftraege();

        void AddTester(Tester tester);
        void AddTestauftrag(Testauftrag testauftrag);

        void UpdateTester(Tester tester);
        void UpdateTestauftrag(Testauftrag testauftrag);

    }
}
