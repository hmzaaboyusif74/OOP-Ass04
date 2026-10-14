using Ass04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp03
{
    public class StandardShipment :Shipment , ITrackable, IInsurable
    {
        #region const
        public StandardShipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
             : base(trackingcode, description, weight, deliveryfee, destination)
        {
         
        }
        #endregion

        #region Standardoverride abstraction
        public override decimal EstimatedCost
        {
            get
            {
                return Deliveryfee + (Weight * 5);
            }
        } 
        public override void PrintShipment() 
        {
            Console.WriteLine();
            Console.WriteLine("StandardShipment");
            Console.Write($" trackingcode : {trackingcode}  Destination:{Destination}     weight:{weight} deliveryfee:{deliveryfee}  description:{description}  EstimatedCost :{EstimatedCost} ");
        }
        public  string GetTrackingStatus()
        {
            return $"Shipment SH001 is Ready";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m ;
        }
        #endregion



    }
}
