using BadCodeExamples.Entities;

namespace BadCodeExamples
{
    public class RentCarService //Этот класс RentCarService имеет слишком много методов, которые выполняют разные функции.
                                //Это уже не сходится с принципом единой ответственности.
                                //Я бы лучше разделил этот класс на несколько классов, каждый из которых будет отвечать за одну конкретную задачу.
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
