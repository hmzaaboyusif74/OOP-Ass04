using AssOOp03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP03
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("override CustomsReport");
        }
    }
}
