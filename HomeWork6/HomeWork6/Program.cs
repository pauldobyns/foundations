//Assignment #6

//Copy this block into your Visual Studio.

// Review and Redo this code line by line at home.  

// Place comments on each line and describe what the code is doing

using System;

namespace ConsoleApplication1
{
    public struct Pet //Create a structure to contain our list of pets
    {
        public string Name;   //Add a field for the name of the pet
        public string TypeOfPet;  // add s field for the type of the pet (e.g. dog, cat, bird)
    }

    class Program
    {
        static void Main() //our programs point of entry
        {
            var numberOfPets = 0;   //intialize the pet counter at 0, indicating we have no pets
            var pets = new Pet[10]; //create a new object of type Pet, this is where we will store our list of pets

            while (true) //an infinite statement to continue dsiplaying the menu 
            {
                Console.Write("A)dd D)elete L)ist pets:"); //prompt the user for input
                var choice = Console.ReadLine(); //Take the user's input for menu selection

                switch (choice) //use the users menu selection to  execute the correct code block
                {
                    case "A": //case where user selects to add a pet using capital letter (use the same for lower case)
                    case "a": //same as above for lower case
                        {
                            Console.Write("Name :"); //Prompt the use for a pet name
                            var name = Console.ReadLine(); //take user input for pet name and store it as name

                            Console.Write("Type of pet :"); //Prompt the use for a pet type
                            var typeOfPet = Console.ReadLine(); //take user input for pet name and store it as typeOfPet

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name; //add the pet's name to the end of the array
                            pets[numberOfPets].TypeOfPet = typeOfPet; //add the pet's type to the end of the array

                            numberOfPets++; //increase pet counter to indicate we have a new pet
                            break; //exit the switch statement after adding our pet
                        }

                    case "D": //case where user selects to delete a pet using capital letter (use the same for lower case)
                    case "d": //same as above for lower case
                        {
                            if (numberOfPets == 0) //check if there are any pets to delete
                            {
                                Console.WriteLine("No pets"); //tell the user there are no pets to delete
                                break; //exit the switch to return to the main menu
                            }

                            for (var index = 0; index < numberOfPets; index++) //loop through the number of pets
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); //print the pet's number, name and type to the screen
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets);//ask the user for input to select a pet to be deleted

                            var petNumberToDelete = Console.ReadLine(); // take user input for which pet to delete
                            var indexToDelete = int.Parse(petNumberToDelete); //convert input to an integer to be used in the code to delete a pet

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++) //loop through the number of pets in the Pet object
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1]; //move the pets following the deleted one up one position
                            }

                            // We have one less pet
                            numberOfPets--;//decrease pet counter to denote that a pet has died/given away/sold/lost

                            break; //exit the switch and return to the main menu
                        }

                    case "L": //case where user selects to list the pets using capital letter (use the same for lower case)
                    case "l": //same as above for lower case
                        {
                            if (numberOfPets == 0) //check if there are any pets to list
                            {
                                Console.WriteLine("No pets"); //tell the user there are no pets to list
                            }

                            for (int index = 0; index < numberOfPets; index++) //loop through the number of pets
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); //print the pet's number, name and type to the screen
                            }

                            break; //exit the switch and return to the main menu
                        }
                    default: //have a default in the switch for if the user selects an option that we have not specified
                        {
                            Console.WriteLine("Invalid option [{0}]", choice); //tell the user the input was not a valid option
                            break; //exit the switch and return to the main menu
                        }
                }
            }
        }
    }
}