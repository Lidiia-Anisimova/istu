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
        public void GetCarInterestInfo(String carType)// Избыточная сложность (D.R.Y)Повторяющиеся проверки в методе GetCarInterestInfo и других частях кода нарушают принцип "Не повторяйся"
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
            if (typeMessage == ("email")) //В методе SendMessage только проверяется typeMessage на равенство "email", но в случае добавления новых типов сообщений, это потребует изменения кода
            {
                //write email
                //use JavaMailSenderAPI
            }
        }
    }
}
