Jeff Espenschied

A super simple alarm. When you run it do: alarm.exe 20 for an alarm in 20 minutes. 
It will go into the background and will fire at the right time.

Started as:

    static void Main(string[] args)
    {
        Thread.Sleep(20 * 60 * 1000);
        for (int i = 0; i < 10; i++)
            Console.Beep();
    }
    
When I wanted to take a quick rest for 20 minutes today. I'm not sure it's 
current form is even worth publishing as I threw it together in about 20 
minutes, but here it is.