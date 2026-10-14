using Ass04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp03
{
    internal class InternationalShipment : Shipment , ITrackable, IInsurable
    {
        #region filed
        string destinationcountry;

        decimal customsfee;
        #endregion
        #region const
        public InternationalShipment()
        {
            
        }
        public InternationalShipment(string destinationcountry,decimal customsfee, string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination) 
            :base( trackingcode,  description,  weight, deliveryfee,  destination)
        {
            DestinationCountry = destinationcountry;
            CustomsFee = customsfee;
           
        }

        #endregion

        #region prop
        public string DestinationCountry
        {
            get { return destinationcountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(destinationcountry)!)
                {
                    destinationcountry = value;
                }

            }
        }

        public decimal CustomsFee
        {
            get
            {
                return customsfee;
            }
            set
            {
                if (customsfee >= 0)
                {
                    customsfee = value;
                }

            }
        }

        #endregion
        #region override abstraction
        public override decimal EstimatedCost => Deliveryfee + (Weight * 5) + CustomsFee;

        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("InternationalShipment");
            Console.Write($" trackingcode : {trackingcode}  Destination:{Destination}     weight:{weight} deliveryfee:{deliveryfee}  description:{description}  EstimatedCost :{EstimatedCost} DestinationCountry : {DestinationCountry}   CustomsFee : {CustomsFee}");

        }
        public string GetTrackingStatus()
        {
            return $"Shipment SH002 is Ready";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m ;
        }
        #endregion
        #region 
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("CustomsReport");
        }

        #endregion

    }
}
