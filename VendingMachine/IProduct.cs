using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine    
{
    public interface IProduct
    {
        // Uppgiftens interface. Alla produkter ärver härifrån.
        void Description();
        void Buy();
        void Use();
    }
}
