// Refactor the following examples to produce code with well-named identifiers in C#.
public class Creature
{
    private const string MISTER = "Mr.";
    private const string MISS = "Mrs.";

    public enum Gender
    {
        Male, Female
    };

    // Assumng input number might give us info for the person's gender.
    public void CreateHuman(int inputNumber)  
    {
        Human firstHuman = new Human();
        firstHuman.Age = inputNumber;
        if (inputNumber % 2 == 0)
        {
            firstHuman.Name = MISTER;
            firstHuman.HumanGender = Gender.Male;
        }
        else
        {
            firstHuman.Name = MISS;
            firstHuman.HumanGender = Gender.Female;
        }
    }

    public class Human
    {
        public Gender HumanGender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}