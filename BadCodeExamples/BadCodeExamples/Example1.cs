using BadCodeExamples.Entities;

namespace BadCodeExamples
{
    // Нарушен SOLID - Принцип единственной ответственности, слишком много методов для одного класса, 
    // нужно разделить логику на несколько классов 
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
            // Нарушение DRY - В каждом условии повторяется одна и та же логика "do some job". 
            // Лучше создать один метод, который будет выполнять задачу, получив тип машины как параметр.
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
            // Нарушение KISS - Здесь три отдельных условия для разных типов машин. 
            // Это можно упростить с помощью оператора `switch/case`, либо
            // создать классы для каждого типа машины, 
            // которые будут обрабатывать свою логику.
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
