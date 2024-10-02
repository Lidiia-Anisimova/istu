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
        //Нарушен принцип SOLID, если заказчик захочет еще один вид машины, придется менять и дописывать данный метод
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
        //Также нарушен SOLID, если помимо отправки сообщения еще будет необходимость отправлять СМС...также будет необходимо менять метод
        public void SendMessage(String typeMessage, String message)
        {
            if (typeMessage == ("email"))
            {
                //write email
                //use JavaMailSenderAPI
            }
        }
        //Необходимо разделить этот класс на несколько других классов и вносить в них инфу о машинах, сообщениях и тд
    }
}
