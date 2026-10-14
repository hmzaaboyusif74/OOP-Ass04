using Ass04;
using AssOOP03;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOp03
{

    public class DeliveryCenter
    {
        string centername { get; set; }
        public driver Driver { get; set; }

        private Shipment[] shipments;
        public DeliveryCenter(int size)
        {
            shipments = new Shipment[size];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    return shipments[index];
                }
                return default;
            }
            set
            {
                if (index >= 0)
                {
                 shipments[index]= value;
                }
                else { Console.WriteLine("nothing"); }

            }
        }
        public Shipment this[string trackingcode]
        {
            get
            {

                if (!string.IsNullOrWhiteSpace(trackingcode))
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {

                        if (shipments[i].TrackingCode == trackingcode)
                        {
                                
                        }
                    }
                }


                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {

                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {

                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null!;
                    return true;
                }
            }

            return false;
        }
        public void printallshipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                }
            }
        }
       public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine(shipment.CalculateInsurance());
        }
        public void PrintTrackingCode()
        {
            foreach(ITrackable x in shipments)
            {
                Console.WriteLine(x.GetTrackingStatus());
            }
        }
    }
}
