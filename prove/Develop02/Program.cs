using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Journal journal = new Journal();

        menu.Display();
        journal.Display();
        
    }
}