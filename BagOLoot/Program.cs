using System;
using System.Collections.Generic;
using System.Linq;
using BagOLoot.Actions;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            ChildRegister book = new ChildRegister();
            ToyRegister bag = new ToyRegister();

            // Choice will hold the number entered by the user
            // after main menu ws displayed
            int choice;

            do
            {
                // Show the main menu
                choice = menu.Show();

                switch (choice)
                {
                    // Menu option 1: Add a child
                    case 1:
                        CreateChild.DoAction(book);
                        break;

                    // Menu option 2: Assign toy to a child
                    case 2:
                        AddToy.DoAction(bag, book);
                        break;

                    // Menu option 3: Revoke toy from a child
                    case 3:
                        RemoveToy.DoAction(bag, book);
                        break;

                    // Menu option 4: Review child's toy list
                    case 4:
                        ReviewToyList.DoAction(bag, book);
                        break;

                    // Menu option 5: Child toy delivery complete
                    case 5:
                        AssignDeliveredChildren.DoAction(bag, book);
                        break;

                    // Menu option 6: Yuletime Delivery Report
                    case 6:
                        Console.WriteLine("selected option 6");
                        ListYuletimeDeliveryReport.DoAction(bag, book);
                        break;

                    // Menu option 7: Quit
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 7);

        }
    }
}
