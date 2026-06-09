namespace _08._06._2026
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~Task1~~~~~~~~~~~~~~~~~");
            Console.WriteLine(Task1(2, 6));

            Console.WriteLine("\n~~~~~~~~~~~~~Task5~~~~~~~~~~~~~~~~~");
            Employee empl = new Employee("Petro PP", new DateTime(2000, 11, 9), "0987654321", "petro.pp@example.com", "Developer", "Develop software");
            empl.Print();

            Console.WriteLine("\n~~~~~~~~~~~~~Task3~~~~~~~~~~~~~~~~~");
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


            Console.WriteLine("\n~~~~~~~~~~~~~Task4~~~~~~~~~~~~~~~~~");
            City city = new City("Kyiv", "Ukraine", 2800000, 044, "Shevchenko, Holosiiv, Pechersk");
            city.Print();
            city.setPopulation(3000000);


            Console.WriteLine("\n~~~~~~~~~~~~~Task6~~~~~~~~~~~~~~~~~");
            Plane plane = new Plane("747", "Boeing", 2020);
            plane.Print();
            Plane plane2 = new Plane("A380", "Airbus", 2019, "Passenger");
            plane2.Print(true);
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
        string mail;
        string position;
        string duties;
        public Employee() { }
        public Employee(string _name, DateTime birthday, string tel, string mail, string position, string duties)
        {
            name = _name;
            this.birthday = birthday;
            this.tel = tel;
            this.mail = mail;
            this.position = position;
            this.duties = duties;
        }
        public string getName()
        { return name; }
        public DateTime getBirthday()
        { return birthday; }
        public string getTel()
        { return tel; }
        public string getMail()
        { return mail; }
        public string getPosition()
        { return position; }
        public string getDuties()
        { return duties; }


        public void setName(string _name)
        { name = _name; }
        public void setBirthday(DateTime _birthday)
        { birthday = _birthday; }
        public void setTel(string _tel)
        { tel = _tel; }
        public void setMail(string _mail)
        { mail = _mail; }
        public void setPosition(string _position)
        { position = _position; }
        public void setDuties(string _duties)
        { duties = _duties; }
        public void Print()
        {
            Console.WriteLine($"Name {name} Year of birth {birthday.Year} Month of birth {birthday.Month} Tel - {tel} Mail - {mail} Position - {position} Duties - {duties}");
        }
    }


    class City
    {
        string name;
        string country;
        int population;
        int tel_code;
        string city_districts;
        public City() { }
        public City(string _name, string _country, int _population, int _tel_code, string _city_districts)
        {
            name = _name;
            country = _country;
            population = _population;
            tel_code = _tel_code;
            city_districts = _city_districts;
        }



        public string getName()
        { return name; }
        public string getCountry()
        { return country; }
        public int getPopulation()
        { return population; }
        public int getTelCode()
        { return tel_code; }
        public string getCityDistricts()
        { return city_districts; }


        public void setName(string _name)
        { name = _name; }
        public void setCountry(string _country)
        { country = _country; }
        public void setPopulation(int _population)
        { population = _population; }
        public void setTelCode(int _tel_code)
        { tel_code = _tel_code; }
        public void setCityDistricts(string _city_districts)
        { city_districts = _city_districts; }

        public void Print()
        {
            Console.WriteLine($"City name {name} Country {country} Population {population} Tel code {tel_code} City districts {city_districts}");
        }

    }


    class Plane
    {
        string model;
        string manufacturer;
        int year;
        string type;
        public Plane() { }
       
        public Plane(string _model, string _manufacturer, int _year)
        {
            model = _model;
            manufacturer = _manufacturer;
            year = _year;
        }
        public Plane(string _model, string _manufacturer, int _year, string _type)
        {
            model = _model;
            manufacturer = _manufacturer;
            year = _year;
            type = _type;
        }
        
        public string getModel()
        { return model; }
        public string getManufacturer()
        { return manufacturer; }
        public int getYear()
        { return year; }
        public string getType()
        { return type; }


        public void setManufacturer(string _manufacturer)
        {
            manufacturer = _manufacturer;
        }
        public void setModel(string _model)
        {
            model = _model;
        }
        public void setYear(int _year)
        {
            year = _year;
        }
        public void setType(string _type)
        {
            type = _type;
        }

        public void Print(bool fullInfo)
        {
            if (fullInfo)
            {
                Console.WriteLine($"Model {model} Manufacturer {manufacturer} Year {year} Type {type}");
            }
            
        }
        public void Print()
        {
            Console.WriteLine($"Model {model} Manufacturer {manufacturer} Year {year}");    
        }
    }
}