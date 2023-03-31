namespace Indexers_C_
{
    class Employee
    {
        private int[] age = new int[3];


        // this replaced by object name in main
        // index replaced by object index in main
        // value replaced by value given to object in main 
        public int this[int index]
        {
            set 
            {
                if (index >= 0 && index < age.Length)
                {


                    if (value > 0)
                    {
                        age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Value is invalid !!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index");
                }
            }
            get 
            {
                return age[index];    
            }
        }

        public int this[int index,int i]
        {
            set 
            {
                age[index] = value + i;
            }
            get 
            {
                return age[index];
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee employee = new Employee();
            //employee[0] = 5;

            //overloaded indexer
            employee[0,1] = 10;
            Console.WriteLine(employee[0]);

        }
    }
}