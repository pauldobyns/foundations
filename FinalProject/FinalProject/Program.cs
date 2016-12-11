using System;

class InventoryManagement : TestInventoryManagement
{
    //declare needed variables
    private int c = 0; //used for counting inventory items
    private Inventory[] inventory = new Inventory[10]; //initialize the Inventory
    //Set up base inventory (columns and data structure)
    //add an item 
    public void AddItem(uint N,string D, decimal P, uint Q,decimal C,decimal V)
    {
        //check for item number
        bool ItemNew = true;
        for (uint i = 0; i < c; i++)
        {
            if (N == inventory[i].ItemNum)
            {
                Console.WriteLine("");
                Console.WriteLine("Item {0} is already in the inventory, please add a different item or change this one from the main menu", N);
                ItemNew = false;
                break;
            }
        }
        //add the item to the inventory
        if (ItemNew)
        {
            inventory[(c)].ItemNum = N;
            inventory[(c)].Desc = D;
            inventory[(c)].Price = P;
            inventory[(c)].Quantity = Q;
            inventory[(c)].Cost = C;
            inventory[(c)].InvVal = V;
            c++;
        }
    }
    public void DisplayMenu()
    {
        Console.WriteLine("1. Add an Item to inventory");
        Console.WriteLine("2. Change an item in inventory");
        Console.WriteLine("3. Delete an item from inventory");
        Console.WriteLine("4. List all items in inventory");
        Console.WriteLine("5. Quit Program");
        Console.WriteLine();
        Console.WriteLine("Please enter a corresponding number to select a menu item: ");
    }
    //Delete an item (by giving its item number)
    public void DeleteItem(uint N)
    {
        //variables
        bool iDeleted = false;
        //search for the item
        for (uint i = 0; i < c; i++)
        {
            if (inventory[i].ItemNum == N)
            {
                iDeleted = true;
                for (uint j = i; j < c; j++)
                {
                    inventory[(j)].ItemNum = inventory[(j+1)].ItemNum;
                    inventory[(j)].Desc = inventory[(j + 1)].Desc;
                    inventory[(j)].Price = inventory[(j + 1)].Price;
                    inventory[(j)].Quantity = inventory[(j + 1)].Quantity;
                    inventory[(j)].Cost = inventory[(j + 1)].Cost;
                    inventory[(j)].InvVal = inventory[(j + 1)].InvVal;
                }
                break;
            }
        }
        //handle unfound item
        if (iDeleted)
        {
            Console.WriteLine("Item {0} was deleted", N);
            c--;
            Console.WriteLine("Press [enter] to continue");
            Console.ReadLine();
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Item {0} was not found", N);
            Console.WriteLine("Press [enter] to continue");
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
    //List all items in the database
    public void PrintItems()
    {
        //loop through each item in inventory and print
        for (uint i = 0; i < c; i++)
        {
            Console.Write("{0,-5}  ", i+1);
            Console.Write("{0,-6}  ", inventory[i].ItemNum);
            Console.Write("{0,-20}  ", inventory[i].Desc);
            Console.Write("{0,-6}  ", inventory[i].Price);
            Console.Write("{0,-3}  ", inventory[i].Quantity);
            Console.Write("{0,-6}  ", inventory[i].Cost);
            Console.WriteLine("{0,-10}  ", inventory[i].InvVal);
        }
    }
    public void ChangeItem(uint N, string D, decimal P, uint Q, decimal C, decimal V)
    {
        //variables
        bool iDeleted = false;
        //search for the item
        for (uint i = 0; i < c; i++)
        {
            if (inventory[i].ItemNum == N)
            {
                iDeleted = true;
                for (uint j = i; j < c; j++)
                {
                    inventory[(j)].ItemNum = inventory[(j + 1)].ItemNum;
                    inventory[(j)].Desc = inventory[(j + 1)].Desc;
                    inventory[(j)].Price = inventory[(j + 1)].Price;
                    inventory[(j)].Quantity = inventory[(j + 1)].Quantity;
                    inventory[(j)].Cost = inventory[(j + 1)].Cost;
                    inventory[(j)].InvVal = inventory[(j + 1)].InvVal;
                }
            }
            break;
        }
        //handle unfound item
        if (iDeleted)
        {
            inventory[(c - 1)].ItemNum = N;
            inventory[(c - 1)].Desc = D;
            inventory[(c - 1)].Price = P;
            inventory[(c - 1)].Quantity = Q;
            inventory[(c - 1)].Cost = C;
            inventory[(c - 1)].InvVal = V;

        }
        else
        {
            Console.WriteLine("Item {0} was not found", N);
            Console.WriteLine("Press [enter] to continue");
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
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
        InventoryManagement Inv = new InventoryManagement();

        // use the code below for setting up a test inventory
        ///*
        Inv.AddItem(323, "Green Pens", 1.50m, 20, 0.75m, 30m);
        Inv.AddItem(657, "Red Pens", 1.50m, 20, 0.75m, 30m);
        Inv.AddItem(846, "Orange Pens", 1.50m, 30, 0.75m, 45m);
        Inv.AddItem(325, "Purple Pens", 1.50m, 45, 0.75m, 67.5m);
        Inv.AddItem(987, "Yellow Pens", 1.50m, 33, 0.75m, 49.5m);
        Inv.AddItem(654, "Black Pens", 1.00m, 100, 0.50m, 100m);
        //*/

        while (Continue)
        {
            Inv.DisplayMenu();
            //read input for menu selection
            string MenuStr = Console.ReadLine();
            MenuSelect = uint.Parse(MenuStr);
            
            //set cases to call appropriate frunction from InventoryManagement 
            switch (MenuSelect)
            {
                case 1: //Add an item
                    {
                        Console.Write("Please enter the item number(3 digits): "); //intruction 1
                        uint Inum = uint.Parse(Console.ReadLine()); //take user input

                        Console.Write("Please enter the item's description (20 characters): "); //intruction 2
                        string IDesc = Console.ReadLine();//take user input

                        Console.Write("Please enter the item's sale price: "); //intruction 3
                        decimal IPrice = decimal.Parse(Console.ReadLine()); //take user input

                        Console.Write("Please enter the quantity of items: "); //intruction 4
                        uint IQuant = uint.Parse(Console.ReadLine()); //take user input
                        
                        Console.Write("Please enter the cost per item: "); //intruction 5
                        decimal ICost = decimal.Parse(Console.ReadLine()); //take user input
                        decimal IVal = IPrice * IQuant;                    //calculate the item value
                        Inv.AddItem(Inum, IDesc, IPrice, IQuant, ICost, IVal);                    //store the item value
                        break;
                    }
                case 2: //change an item
                    {
                        Console.Write("Please enter the item number(3 digits): "); //intruction 1
                        uint Inum = uint.Parse(Console.ReadLine()); //take user input

                        Console.Write("Please enter the item's description (20 characters): "); //intruction 2
                        string IDesc = Console.ReadLine();//take user input

                        Console.Write("Please enter the item's sale price: "); //intruction 3
                        decimal IPrice = decimal.Parse(Console.ReadLine()); //take user input

                        Console.Write("Please enter the quantity of items: "); //intruction 4
                        uint IQuant = uint.Parse(Console.ReadLine()); //take user input

                        Console.Write("Please enter the cost per item: "); //intruction 5
                        decimal ICost = decimal.Parse(Console.ReadLine()); //take user input
                        decimal IVal = IPrice * IQuant;                    //calculate the item value
                        Inv.ChangeItem(Inum, IDesc, IPrice, IQuant, ICost, IVal);                    //store the item value
                        break;
                    }
                case 3: //delete an item
                    {
                        Console.Write("Please enter the item number(3 digits): "); //intruction 1
                        uint Inum = uint.Parse(Console.ReadLine()); //take user input
                        Inv.DeleteItem(Inum);
                        break;
                    }
                case 4: //list all items from inventory
                    {
                        //Display Entire Inventory
                        Console.WriteLine("Item#  ItemID  Description           Price   QOH  Cost    Value     ");
                        Console.WriteLine("-----  ------  --------------------  ------  ---  ------  ----------");
                        Inv.PrintItems();
                        Console.WriteLine("");
                        break;
                    }
                case 5: //quit the application
                    {
                        //execute Menu item 5
                        Continue = false;
                        break;
                    }
                default:
                    {
                        //Invalid selection handling
                        Console.WriteLine("Please select a valid menu option...");
                        break;
                    }
            }
        }
    }
}