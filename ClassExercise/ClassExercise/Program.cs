using System;


class VerySimple //useful tool or useful object
    {
        int simpleValue; //this is a field
        //string Testy;
        public VerySimple() // constructor must be the same name as the class
        {
            simpleValue = 10;
            //Testy = "Does this work?";
        }
        //methods (functions)
        //properties
        //another class
        //enums
    }

class TestVerySimpleClass
{
    static void Main()
    {
        VerySimple ver; //notice that ver is null

        ver = new VerySimple(); //instantiation (give me an object of type VerySimple
    }
}