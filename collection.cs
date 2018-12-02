using System;

namespace Csharp
{
    class employee
    {
        public int empId;
        public string empName;
        public string empType;
        public employee(int aId, string aName, string aType)
        {
            empId = aId;
            empName = aName;
            empType = aType;
        }
        public double payment()
        {
            if(empType == "M-E")
            {
                double a,b,c;
                int grossSalary=20000;
                a=(grossSalary*18)/100;
                b=grossSalary-a;
                c=b*3/100;
                return (b-c);


            }
            else if(empType == "T-E")
            {
                double d;
                int grossSalary=5000;
                d=grossSalary*18/100;
                return (grossSalary-d);
            } 
            else{
                double e,f,g;
                int grossSalary=2500;
                e=(grossSalary*18/100);
                f=grossSalary-e;
                g=(f*0.15)/100;
                return (g+f); 
            }           
        }
        static void Main(string[] args)
        {
            employee employee1 = new employee(1, "James", "M-E");
            employee employee2 = new employee(2, "John", "M-E");
            employee employee3 = new employee(3, "Diane", "M-E");
            employee employee4 = new employee(4, "Doreen", "M-E");
            employee employee5 = new employee(5, "Obama", "T-E");
            employee employee6 = new employee(6, "David", "T-E");
            employee employee7 = new employee(7, "Rachel", "T-E");
            employee employee8 = new employee(8, "Esther", "T-E");
            employee employee9 = new employee(9, "Emmanuel", "E-E");
            employee employee10 = new employee(10, "Eric", "E-E");
            employee employee11 = new employee(11, "Sandrine", "E-E");
            employee employee12 = new employee(12, "Kevine", "E-E");
            Console.WriteLine(employee1.payment());
            Console.WriteLine("Hello World!");
        }
    }
}
