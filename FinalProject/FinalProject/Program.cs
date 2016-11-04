using System;

class InventoryManagement
{
    //declare needed variables
    //Set up base inventory (columns and data structure)
    //add an item 
    //change an item (by giving its item number)
    //Delete an item (by giving its item number)
    //List all items in the database
}

struct Inventory
{
    public uint ItemNum;
    public string Desc;
    public decimal Price;
    public uint Quantity;
    public decimal Cost;
    public decimal InvVal;
    //setup base data and structure
}

class TestInventoryManagement
{
    static void Main()
    {
        //declare necessary variables
        uint MenuSelect;
        bool Continue = true;
        //display menu
        while (Continue)
        {
            Console.WriteLine("Please enter a corresponding number to select a menu item: ");
            Console.WriteLine("1. Add an Item to inventory");
            Console.WriteLine("2. Change an item in inventory");
            Console.WriteLine("3. Delete an item from inventory");
            Console.WriteLine("4. List all items in inventory");
            Console.WriteLine("5. Quit Program");
            
            //read input for menu selection
            string MenuStr = Console.ReadLine();
            MenuSelect = uint.Parse(MenuStr);
            
            //set cases to call appropriate frunction from InventoryManagement 
            switch (MenuSelect)
            {
                case 1: //Add an item
                    Console.Write("Please enter the item number: "); //intruction 1
                    Console.ReadLine(); //take user input
                                        //store input
                    Console.Write("Please enter the item's description: "); //intruction 2
                    Console.ReadLine(); //take user input
                                        //store input
                    Console.Write("Please enter the item's sale price: "); //intruction 3
                    Console.ReadLine(); //take user input
                                        //store input
                    Console.Write("Please enter the quantity of items: "); //intruction 4
                    Console.ReadLine(); //take user input
                                        //store input
                    Console.Write("Please enter the cost per item: "); //intruction 5
                    Console.ReadLine(); //take user input
                                        //store input
                    //calculate the item value
                    //store the item value
                    break;
                case 2:
                    //execute Menu item 1
                    break;
                case 3:
                    //execute Menu item 1
                    break;
                case 4:
                    //execute Menu item 1
                    break;
                case 5:
                    //execute Menu item 1
                    break;
                default:
                    //Invalid selection handling
                    Console.WriteLine("Please select a valid menu option.");
                    break;
            }
            //return to the main menu

            //quit

        }

    }

}