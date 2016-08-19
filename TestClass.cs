using System;

public class TheMotivator
{
    public void returnFeedback(int score)
    {
        if (score == 100)
            Console.WriteLine("You're awesome");
		else
            Console.WriteLine("Well, what can I say?");
    }
    public static void main(String[] args)
    {
        TheMotivator tm = new TheMotivator();
        tm.returnFeedback(60);
    }
}
