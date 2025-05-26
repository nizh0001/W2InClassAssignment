namespace W2InClassAssignment;

public class StringMethods
{
  public static int CountVowels(string inputString)
  {
    
    int vowelsCount = 0;
    string vowels = "aeiou";
    foreach (char c in inputString.ToLower())
    {
        if (vowels.Contains(c))
        {
            vowelsCount++;
        }
      
    }
    return vowelsCount;
  }
  
}