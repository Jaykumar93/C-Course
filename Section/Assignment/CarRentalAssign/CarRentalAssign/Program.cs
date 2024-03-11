using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace CarRentalAssign
{
    class CarRental
    {
        static void Main()
        {
            Car[] cars =
            {
                new Car(1, "Maruti", "Baleno", 5000, true),
                new Car(2, "Mahindra", "Scorpio", 6000, true),
                new Car(3, "Maruti", "Suzuki", 7000, true),
                new Car(4, "MG", "Hector", 10000, true)
            };

            void CarListing()
            {
                foreach (Car car in cars)
                {
                    if (car.IsAvailable)
                    {
                        Console.WriteLine(car.GetCarDetail() + " - Available");
                    }
                    else
                    {
                        Console.WriteLine(car.GetCarDetail() + " - Rented");
                    }
                }
            }

            Console.WriteLine("\n++++++  Welcome to the Car Rental System  ++++++\n");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Rent a car");
                Console.WriteLine("2. Return a car");
                Console.WriteLine("3. View available cars");
                Console.WriteLine("4. Exit");

                Console.Write("\nPlease enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if(choice == "1")
                {
                    Console.WriteLine("Rent a Car : ");
                    CarListing();

                    Console.WriteLine("\n\nEnter the id of the car that you want to rent:");
                    int CarToRent = int.Parse(Console.ReadLine());


                    Car RentedCar = null;

                    foreach (Car car in cars)
                    {
                        if( car.Id ==CarToRent && car.IsAvailable)
                        {
                            RentedCar = car;
                            break;
                        }
                    }
                    if (RentedCar == null)
                    {
                        Console.WriteLine("\nSorry, the selected car is not available for rent.\n");
                    }
                    else
                    {
                        RentedCar.Rent();
                        Console.WriteLine($"\n{RentedCar.Make} {RentedCar.Model} is rented by you for for ${RentedCar.RentalPrice}/day.\n");
                    }
                }



                else if(choice == "2")
                {
                    Console.WriteLine("Return a Car : ");
                    CarListing();

                    Console.WriteLine("\n\nEnter the id of the car that you want to return :");
                    int CarToReturn = int.Parse(Console.ReadLine());

                    Car ReturnCar = null;

                    foreach (Car car in cars)
                    {
                        if (car.Id == CarToReturn && (!car.IsAvailable))
                        {
                            ReturnCar = car;
                            break;
                        }
                    }
                    if (ReturnCar == null)
                    {
                        Console.WriteLine("\nSorry, the selected model doesnt match with your model.\n");
                    }
                    else
                    {
                        ReturnCar.Rent();
                        Console.WriteLine($"\n{ReturnCar.Make} {ReturnCar.Model} is returned back. \n");
                    }
                }

                else if(choice == "3")
                {
                    Console.WriteLine("The Available cars are :");
                    CarListing();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Thank you for using the car rental system!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.\n");
                }
            }

            Console.ReadKey();
        }
    }
}
