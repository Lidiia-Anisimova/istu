using BadCodeExamples.Entities;

namespace BadCodeExamples
{
    public class RentCarService // Данный класс нарушает  принцип единной ответственности так как отвечает за разные действия SRP
    {

        public void FindCar(String carNo)
        {
            //find car by number
            // return car;
        }

        public void OrderCar(String carNo, Client client)
        {
            //client order car
            // return order;
        }

        public void PrintOrder(Order order)
        {
            //print order
        }
        public void GetCarInterestInfo(String carType)  
        {
            if (carType == "sedan")
            {
                //do some job
            }
            if (carType == ("pickup"))
            {
                //do some job
            }
            if (carType == ("van"))
            {
                //do some job
            }
        }
        public void SendMessage(String typeMessage, String message)
        {
            if (typeMessage == ("email"))
            {
                //write email
                //use JavaMailSenderAPI
            }
        }
    }
}
