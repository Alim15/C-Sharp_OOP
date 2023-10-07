using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_2
{
    public abstract class GodsCreations
    {
        string name;
        int run;
        int jump; 

    public GodsCreations(string name, int run, int jump){
        this.name = name;
        this.run = run;
        this.jump = jump;
        }

    public void Run(){
        System.Console.WriteLine("Бежит!");
    }
    public void Jump(){
        System.Console.WriteLine("Прыгает!");
    }

    }


}