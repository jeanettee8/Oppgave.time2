using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

DateTime timeNow = DateTime.Now;

    if (timeNow.Hour >= 7 && timeNow.Hour < 8) {
        Console.WriteLine("Good morning!");
    }

    else if (timeNow.Hour >= 8 && timeNow.Hour < 9) {
        Console.WriteLine("Time for check in!");
    }
    
    else if (timeNow.Hour >= 9 && timeNow.Hour < 11) {
        Console.WriteLine("Get to work.");
    }

    else if (timeNow.Hour >= 11 && timeNow.Hour < 12) {
        Console.WriteLine("Take a break and eat some food.");
    }

    else if (timeNow.Hour >=12 && timeNow.Hour < 15) {
        Console.WriteLine("Back to work.");
    }

    else if (timeNow.Hour >= 15 && timeNow.Hour < 16) {
        Console.WriteLine("Time to go home.");
    }

    else if (timeNow.Hour >= 16 && timeNow.Hour < 21) {
        Console.WriteLine("Relax and do something fun!");
    }

    else if (timeNow.Hour >= 21 && timeNow.Hour < 22){
        Console.WriteLine("Get ready for bed");
    }
    
    else if (timeNow.Hour >= 22 && timeNow.Hour < 7) {
        Console.WriteLine("You should be sleeping\">\"\":\"\"(\" ");
    }

    else {
        Console.WriteLine("Error: Wasn't able to tell the time.");
    }
