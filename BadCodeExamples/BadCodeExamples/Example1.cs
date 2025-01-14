using BadCodeExamples.Entities;

namespace BadCodeExamples
{
    public class RentCarService
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
            if (carType == /*(*/"pickup"/*)*/) //Ненужные скобки
            {
                //do some job
            }
            if (carType == /*(*/ "van"/*)*/) //Ненужные скобки
            {
                //do some job
            }
        }
        public void SendMessage(String typeMessage, String message)
        {
            if (typeMessage == /*(*/"email"/*)*/) //Ненужные скобки
            {
                //write email
                //use JavaMailSenderAPI
            }
        }
    }
}
