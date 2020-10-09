using System;
//this is a practice project to do an order calculation for a delivery order online
namespace CostCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            string fullName; //first and last
            string address;
            string areaLocation; //city, province, postal code
            string instructions;
            
            //string numOfOrders; //item amount
            


            //double
            double phoneNum = 0;
            
            //double studentDiscount = 10; 
            //decimal orderTotalS = 0;
            decimal Total = 0;


            decimal savings = 0;
            decimal subTotal = 0;
            decimal taxAmount = 0;
            //int
            int itemAmount = 0;
            //decimal
            

            //string isStudent;
            //string dinner;

            //intro to project
            Console.WriteLine("Welcome to Arnold's Amazing Eats. This program is designed to take customers food orders and process them. " +
                "After the users personal information is taken along with there order, the recipt will display back" +
                "showing your order. Let's get started. Today there are two specials going on!");

            //Steps to take customers information
            Console.WriteLine("Please provide your first and last name");
            fullName = Console.ReadLine();
            Console.WriteLine("Please provide your address");
            address = Console.ReadLine();
            Console.WriteLine("Please provide your city, province, and postal code");
            areaLocation = Console.ReadLine();
            Console.WriteLine("Please provide a phone number we can reach you at");
            phoneNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please provide special instructions for deliveries from this address");
            instructions = Console.ReadLine();


            Console.WriteLine("Great! Now that we have your delivery information lets get into ordering some food");
            double choice;
            do
            {
                Console.WriteLine("Select option 1 or 2");
                Console.WriteLine("1) Burger combo | 15.99 (Burger with a side of fries and choice of drink)");
                Console.WriteLine("2) Steak combo | 25.45 (Steak how you like it with a side of veggies and baked potato with choice of drink)");
                Console.WriteLine("");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    BurgerCombo();
                }
                else if (choice == 2)
                {
                    SteakCombo();
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine("Please specify from the menu");
                }


            } while (choice !=3);

        
            //Console.WriteLine("");
            //Console.WriteLine("Is this correct? (Y/N): " + itemAmount); //confirm amount
            //optionOne = Console.ReadLine();
            //optionTwo = Console.ReadLine();
            
        static void BurgerCombo()
        {
                decimal HST = 1.13M;
                string Student;
                
                decimal Total = 0;
                decimal savings = 0;
                decimal subTotal = 0;
                decimal taxAmount = 0;
                //int
                int itemAmount = 0;
                //decimal
                decimal priceComboOne = 0;

                //int itemAmount = 0;
                Console.WriteLine("How many of those meals are being ordered today?"); //ask how many they want
                string numOfOrders = Console.ReadLine(); //converting string to int
                itemAmount = int.Parse(numOfOrders);
                Console.WriteLine("Is this correct? (Y/N): " + itemAmount); //confirm amount
                string answer = Console.ReadLine();
                
                if (answer == "y" || answer == "Y")
                {
                    Console.WriteLine("Are you a student? (Y/N)");
                    Student = Console.ReadLine();

                    if (Student == "y" || Student == "Y")
                    {
                        decimal d = 15.99M;
                        priceComboOne = d * itemAmount; //price of option 1
                        //int discount = 10; //dicount amount
                        savings = priceComboOne * 0.1M; //calculate discount savings
                        Math.Round(savings, 2); //round 2 decimal places
                        subTotal = priceComboOne - savings; //sub total is a result from the price of the item minus the discount
                        taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
                        Math.Round(taxAmount, 2);
                        Total = subTotal + taxAmount;

                    }
                    else if (Student == "n" || Student == "N")
                    {
                        subTotal = priceComboOne * itemAmount; //sub total is the price of the item 
                        taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
                        Math.Round(taxAmount, 2);
                        Total = priceComboOne + subTotal + taxAmount;

                    }
                }
                else
                {

                }
            }
            Console.Clear();
            //Data recipt of the order
            Console.WriteLine("");
            Console.WriteLine(fullName);
            Console.WriteLine("");
            Console.WriteLine(address);
            Console.WriteLine("");
            Console.WriteLine(areaLocation);
            Console.WriteLine("");
            Console.WriteLine(phoneNum);
            Console.WriteLine("");
            Console.WriteLine(instructions);
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("Item Amt: " + itemAmount);
            Console.WriteLine("Name of the dinner: " + choice);
            Console.WriteLine("");
            Console.WriteLine("10% student savings: " + savings);
            Console.WriteLine("Sub Total: " + subTotal);
            Console.WriteLine("Tax (13%): " + taxAmount);
            Console.WriteLine("");
            Console.WriteLine("TOTAL: " + Total);

            Console.ReadKey(true);

        }



            static void SteakCombo()
        {

        }

        //if (optionOne == "1") //if the first option is selected
        //{
        //    //Console.WriteLine("How many of those meals are being ordered today?"); //ask how many they want
        //    numOfOrders = Console.ReadLine(); //converting string to int
        //    itemAmount = int.Parse(numOfOrders);

        //    if (numOfOrders == "y" || numOfOrders == "Y")
        //    {
        //        Console.WriteLine("Are you a student? (Y/N)");
        //        Student = Console.ReadLine();

        //        if (Student == "y" || Student == "Y")
        //        {
        //            priceComboOne = 15.99M + itemAmount; //price of option 1
        //            int discount = 10; //dicount amount
        //            savings = priceComboOne * discount / 100; //calculate discount savings
        //            Math.Round(savings, 2); //round 2 decimal places
        //            subTotal = priceComboOne - savings; //sub total is a result from the price of the item minus the discount
        //            taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
        //            Math.Round(taxAmount, 2);
        //            orderTotalS = priceComboOne + savings + subTotal + taxAmount;

        //            Console.WriteLine("10% student saving" + savings);
        //        }
        //        else if (Student == "n" || Student == "N")
        //        {
        //            subTotal = priceComboOne + itemAmount; //sub total is the price of the item 
        //            taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
        //            Math.Round(taxAmount, 2);
        //            orderTotal = priceComboOne + subTotal + taxAmount;

        //        }
        //    }

        //}

        //else if (optionTwo == "2")
        //{
        //    Console.WriteLine("How many of those meals are being ordered today?");
        //    numOfOrders = Console.ReadLine();
        //    itemAmount = int.Parse(numOfOrders);

        //    Console.WriteLine("");
        //    Console.WriteLine("Is this correct? (Y/N): " + itemAmount); //confirm amount

        //    if (numOfOrders == "y" || numOfOrders == "Y")
        //    {
        //        Console.WriteLine("Are you a student? (Y/N)");
        //        Student = Console.ReadLine();

        //        if (Student == "y" || Student == "Y")
        //        {
        //            priceComboTwo = 25.45M; //price of option 2
        //            int discount = 10; //dicount amount
        //            savings = priceComboTwo * discount / 100; //calculate discount savings
        //            Math.Round(savings, 2); //round 2 decimal places
        //            subTotal = priceComboTwo - savings; //sub total is a result from the price of the item minus the discount
        //            taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
        //            Math.Round(taxAmount, 2);
        //            orderTotal = priceComboTwo + savings + subTotal + taxAmount;
        //        }
        //        else if (Student == "n" || Student == "N")
        //        {
        //            subTotal = priceComboTwo; //sub total is the price of the item 
        //            taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
        //            Math.Round(taxAmount, 2);
        //            orderTotal = priceComboTwo + subTotal + taxAmount;

        //        }
        //    }
        //}
        //Console.Clear();
        //    //Data recipt of the order
        //    Console.WriteLine("");
        //    Console.WriteLine(fullName);
        //    Console.WriteLine("");
        //    Console.WriteLine(address);
        //    Console.WriteLine("");
        //    Console.WriteLine(areaLocation);
        //    Console.WriteLine("");
        //    Console.WriteLine(phoneNum);
        //    Console.WriteLine("");
        //    Console.WriteLine(instructions);
        //    Console.WriteLine("");
        //    Console.WriteLine("------------------");
        //    Console.WriteLine("");
        //    Console.WriteLine("Item Amt: " + itemAmount);
        //    Console.WriteLine("Name of the dinner: " + choice);
        //    Console.WriteLine("");
        //    Console.WriteLine("10% student savings: " + savings);
        //    Console.WriteLine("Sub Total: " + subTotal);
        //    Console.WriteLine("Tax (13%): " + taxAmount);
        //    Console.WriteLine("");
        //    Console.WriteLine("TOTAL: " + Total);
            

        //    Console.ReadKey(true);
        }
    }

