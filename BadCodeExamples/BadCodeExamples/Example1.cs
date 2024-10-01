using BadCodeExamples.Entities;

namespace BadCodeExamples
{
    public class RentCarService // Большое кол-во методов в одном классе (GodObject)
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
        public void GetCarInterestInfo(String carType) // Большое кол-во циклов, можно создать словарь с характеристиками
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
        public void SendMessage(String typeMessage, String message) // Метод можно вынести в другой класс (Закон Деметры GodObject)
        {
            if (typeMessage == ("email"))
            {
                //write email
                //use JavaMailSenderAPI
            }
        }
    }
}
