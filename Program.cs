for (int hour = 0; hour < 24; hour++)
{
    for(int min = 0; min < 60; min++)
    {
        for (int sek = 0; sek < 60; sek++)
        {
            Console.WriteLine(time(hour) + ":" + time(min) + ":" + time(sek));
        }

    }
}



string time(int nummer)
{
    if (nummer <= 9)
    {
        return "0" + nummer;
    }
    else return nummer.ToString();
}