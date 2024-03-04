class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswerLetter = 'X';

    public Question()
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        questionText = null;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswerLetter;

    }

    // This is an example of constructor overloading 
    // here i am passing only one parameter for the constructor so it will update only the single and keep the other value default or one that is set in the constructor by user.
    public Question(string questionText)
    {
        //TO DO: Initialize questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        questionText = questionText;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswerLetter;
    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD and correctAnswerText. Validate the value of correctAnswerLetter. It should either 'A', 'B', 'C' or 'D' only
        questionText = questionText;
        optionA = optionA;
        optionB = optionB;
        optionC = optionC;
        optionD = optionD;
        if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D')
        {
            this.correctAnswerLetter = correctAnswerLetter;
        }
        else
        {
            correctAnswerLetter = Question.defaultCorrectAnswerLetter;
        }
        

    }

    public bool AreOptionsValid()
    {
        return (optionA != null || optionB != null) && (optionC != null || optionD != null);
    }
}

class Program
{
    static void Main()
    {
        //TO DO: Create an object of Question class and pass no arguments to the constructor

        Question question1 = new Question();

        //TO DO: Create an object of Question class and pass value for questionText only to the constructor.

        Question question2 = new Question("What is your name?");

        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.

        Question question3 = new Question("How are you?", "Very Good", "Good", "Okay", "Bad",'C');

        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.

        Question question4 = new Question() { questionText = "What is your fav food", optionA = "Pizza", optionB = "Burger", optionC = "Chaap", optionD = "Chaat" };
    }
}