using AssOOp03;

namespace Ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //abstraction is hidden complex impelementention for user and expose the essintial function only.
            //becouse it is make code more readable , maintance and hidden complex impelement for user.
            // diff  1-interface class is 100% abstraction all functions are hidden olso defult function  and only impelement.
            //       2-abstraction class can impelement and inhertance - partial abstraction.
            //when you need to hidden all impelementation and need muliable inhertance or need more impelemenet more one interface .
            //no in c# can not class inhert for more one class but in interface can do that.  
            #endregion
            #region Q
         
            StandardShipment std = new StandardShipment("SH001", "Books", 5m, 20m, new DeliveryAddress("Cairo", "Tahrir St", 10));

           
            ExpressShipment exp = new ExpressShipment("SH002", "Electronics", 3m, 50m, new DeliveryAddress("Giza", "Pyramids St", 15),25);

          
            InternationalShipment intl = new InternationalShipment("TR1", 25, " TR02", "s14,B45", 10m, 25, new DeliveryAddress("cairo", "el3taba", 253));

            DeliveryCenter D1 = new DeliveryCenter(3);

            D1.AddShipment(std);
            D1.AddShipment(exp);
            D1.AddShipment(intl);
            Console.WriteLine("print all shipments");
            D1.printallshipments();
            Console.WriteLine("print tracking and cost");
            Console.WriteLine("-----------------------");
            D1.PrintInsurance(std);
            D1.PrintShipment(std);
            Console.WriteLine("-----------------------");
            D1.PrintInsurance(exp);
            D1.PrintShipment(exp);
            Console.WriteLine("-----------------------");
            D1.PrintInsurance(intl);
            D1.PrintShipment(intl);
            Console.WriteLine("-----------------------");
            ITrackable[] trackableArray = new ITrackable[] { std, exp, intl };
            foreach (var item in trackableArray)
            {
                Console.WriteLine(item.GetTrackingStatus());
            }
            IInsurable[] insurableArray = new IInsurable[] { std, exp, intl };


            foreach (var item in insurableArray)
            {
                Console.WriteLine($"Insurance Value: {item.CalculateInsurance()}");
            }
            #endregion
        }
    }
}
