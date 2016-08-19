using System;

// This class is used for returning of Feedback
public class TheMotivator
{
    public void returnFeedback(int score)
    {
        if (score == 100)
            Console.WriteLine("You're awesome");
        else if (score > 90)
            Console.WriteLine("That's great");
        else if (score > 60)
            Console.WriteLine("That's good ");
        else
            Console.WriteLine("Well, what can I say? This is only feedback you will have");
    }
    public static void main(String[] args)
    {
        TheMotivator tm = new TheMotivator();
        tm.returnFeedback(60);
    }
}
