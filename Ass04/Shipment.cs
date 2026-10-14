using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp03
{
    public abstract class Shipment
    {
        #region filed
        public string trackingcode;
        public string description;
        public decimal weight;
        public decimal deliveryfee;
        public DeliveryAddress Destination { get; set; }
        #endregion

        #region validation
        public string TrackingCode
        {
            get
            {
                return trackingcode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingcode = value;
                }
            }

        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public decimal Weight
        {
            set
            {
                if (value > 0)
                    weight = value;
            }
            get { return weight; }

        }
        public decimal Deliveryfee
        {
            private set
            {
                if (value > 0)
                    deliveryfee = value;
            }
            get
            {
                return deliveryfee;
            }
        }
        #endregion
        #region constractor
        public Shipment()
        {

        }
        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
        {

            TrackingCode = trackingcode;
            Description = description;
            Weight = weight;
            Deliveryfee = deliveryfee;
            Destination = destination;
           
        }
        public Shipment(string trackingcode) : this(trackingcode, "unknown", 1, 50, new DeliveryAddress("unkown", "unknown", 1))
        {

        }
        #endregion

      
        #region overloading
        public void updateweight(int weight) //overloading methode
        {
            Weight= weight;
            Console.WriteLine(Weight);
        }
        public void updateweight(int weight, int exstrapackingweight)
        {
            Weight = weight +exstrapackingweight;
            Console.WriteLine(Weight );
        } 
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                Deliveryfee = newFee;
        }

        #endregion




        #region abstraction
        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();

        #endregion
    }
}
