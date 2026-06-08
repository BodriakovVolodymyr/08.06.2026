namespace _08._06._2026
{
    internal class Program
    {
        static void Main()
        {
            //Task1
            Console.WriteLine(Task1(2, 6));

            //Task2
            Employee empl = new Employee("Petro PP", new DateTime(2000, 11, 9), "0987654321");
            empl.Print();
            //Task3
            int[] arr = { 5, 9, 8, 4, 1, 3, 5, 4 };
            int choise = 0;
            Console.WriteLine("Enter sort type: 1 - min to max, 2 - max to min:");
            choise = int.Parse(Console.ReadLine());
            SortArr(arr, choise == 1);

            Console.WriteLine($"Array after sort: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static int Task1(int x, int y)
        {
            int res = 1;
            for (int i = x; i <= y; i++)
            {
                res *= i;
            }
            return res;
        }
        static void SortArr(int[] arr, bool from_min_to_max)
        {
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (from_min_to_max)
                        {
                            if (arr[j] > arr[j + 1])
                            {
                                int temp = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = temp;
                            }
                        }
                        else
                        {
                            if (arr[j] < arr[j + 1])
                            {
                                int temp = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = temp;
                            }
                        }
                    }
                }
            }

        }
    }
    class Employee
    {
        string name;
        DateTime birthday;
        string tel;
        public Employee(){ }
        public Employee(string _name,DateTime birthday,string tel){
            name = _name;
            this.birthday = birthday;
            this.tel = tel;        
        }
        public string getName()
        {  return name; }
        public void setName(string _name)
        {  name = _name; }
        public void Print()
        {
            Console.WriteLine($"Name {name} Year of birth {birthday.Year} Month of birth {birthday.Month} Tel - {tel}");        
        }
    }
}
