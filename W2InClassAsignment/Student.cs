using System.Reflection.Metadata.Ecma335;

namespace W2InClassAssignment;

public class Student
{
    private string name;
    private int grade;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Grade
    {
        get => grade;
        set
        {
            if (value is >= 0 and <= 100)
            {
                grade = value;
            }
            else
            {
                Console.WriteLine("Grade is invalid, must be between 0 and 100.");
            }
        }
        
    }

    public bool IsPassing()
    {
        return grade >= 50;
    }
    

}