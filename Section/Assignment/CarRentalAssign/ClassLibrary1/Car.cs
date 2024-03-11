using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    namespace ClassLibrary1
    {
        public class Car
        {
            public int Id {  get; set; }
            public string Make {  get; set; }
            public string Model { get; set; }
            public decimal RentalPrice { get; set; }
            public bool IsAvailable { get; set; }

            public Car(int id, string make, string model, int rentalPrice, bool isAvailable)
            {
                Id = id;
                Make = make;
                Model = model;
                RentalPrice = rentalPrice;
                IsAvailable = isAvailable;
            }

            public void Rent()
            {
                IsAvailable = false;
            }

            public void Return()
            {
                IsAvailable = true;
            }

        
            public string GetCarDetail()
            {
                return Id + ". " + Make + " " + Model + " (Rental price: " + RentalPrice + "/day)";
            }
        }
    }
