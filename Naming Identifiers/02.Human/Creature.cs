using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Refactor the following examples to produce code with well-named identifiers in C#:


class Creature
{
    enum Gender { Male, Female };

    public class Human
    {
        public Gender HumanGender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


    }

    public void CreateHuman(int InputNumber) //assumng input number might give us info for the person's gender 
    {
        Human FirstHuman = new Human();
        FirstHuman.Age = InputNumber;
        if (InputNumber % 2 == 0)
        {
            FirstHuman.Name = "Mr.";
            FirstHuman.HumanGender = Gender.Male;
        }
        else
        {
            FirstHuman.Name = "Mrs.";
            FirstHuman.HumanGender = Gender.Female;
        }
    }
}



