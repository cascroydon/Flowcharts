using System;

class Count
{
    static void Main(string[] args)
    {
        int count = 1;
    loop:
        Console.WriteLine(count);
        if (count == 10) goto end;
        count = count + 1;
        goto loop;
    end:
        return;
    }
}
