using Ass04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp03
{
    public class ExpressShipment :Shipment , ITrackable, IInsurable
    {
        decimal extrafee; //filed

        #region prop
        public decimal Extrafee
        {
            get { return extrafee; }

            set
            {
                if (value > 0)
                {
                    extrafee = value;
                }

            }
        }
       
        #endregion

        #region const
        public ExpressShipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination, decimal extrafee)
           : base(trackingcode, description, weight, deliveryfee, destination)
        {
            Extrafee = extrafee;
            
        }
        #endregion
        #region expressoverride abstraction
        public override decimal EstimatedCost => Deliveryfee + (Weight * 5) + Extrafee; 
        public override void PrintShipment()
        {
            
            Console.WriteLine("ExpressShipment");
            Console.Write($" trackingcode : {trackingcode}  Destination:{Destination}     weight:{weight} deliveryfee:{deliveryfee}  description:{description}  EstimatedCost :{EstimatedCost}  : Extrafee {Extrafee}");

        
        }
        public string GetTrackingStatus()
        {
            return $"Shipment SH003 is Ready";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m  ;
        }
        #endregion
    }
}
