---
Which will create a new instance of a class?

1. ✔ Car car = new Car();
2. car = new Car();
3. Car car = new Car;


---
What coused this error?

```csharp
error CS0122: Car.engine' is inaccessible due to its protection level
```

1. It's set to private
2. ✔ It's set to private
3. It's set to static
4. It's set to void


---
When a class is instantiated, you call a...

1. Method
2. Object
3. ✔ Constructor
4. Fields


---
What will be the output?

```csharp
class Program
    {
        static void Main(string[] args)
        {
          
            Address person1 = new Address();
            person1.name = "Linda";
            person1.address = "Riga";
            person1.display();
            Console.ReadKey();
        }
    class Address
    {
        public string name;
        public string address;
        public void display()
        {
            Console.WriteLine($"{name} is in {address}");
        }
    }
```


1. ✔ Linda is in Riga
2. Compilation error 
3. Nothing will print out


---
What will be the output?

```csharp
class Program
    {
        static void Main(string[] args)
        {
        Person person1 = new Person();
        person1.name = "Linda";
        person1.display();
        Console.ReadKey();
        }
    class Person
    {
        string name;
        public void display()
        {
            Console.WriteLine($"{name}");
        }
    }
```

1. Linda
2. ✔Compilation error 
3. Nothing will print out


---
What will be the output?

```csharp
 class Program
    {
        private static void Main(string[] args)
        {
            abc example = new abc(10, 20);
            example.Print();
            Console.ReadKey();
        }
    }
    class abc
    {
        int _i;
        int _k;
        public abc(int i, int k)
        {
            _i = i;
            _k = k;
        }
        public void Print()
        {
            Console.WriteLine(_i + _k);
        }
    }
```

1. ✔30
2. Compilation error 
3. 10 + 20

---
What will be the output?

```csharp
 class emp
  {
      public string name;
      public string address;
      public void display()
      {
          Console.WriteLine("{0} is in city {1}", name, address);
      }
  }
  class Program
  {
      static void Main(string[] args)
      {
          emp obj = new emp();
          obj.name = "Akshay";
          obj.address = "new delhi";
          obj.display();
          Console.ReadLine();
      }
}
```

1. Syntax error
2. {0} is in city {1} Akshay new delhi
3. Akshay is in new delhi
4. ✔ Akshay is in city new delhi

---
Which of the following gives the correct count of the constructors that a class can define?

1. 1
2. 2
3. ✔ Any number
4. None of the above

---
What will be the output?

```csharp
 class program
{
    static void Main(string[] args)
    {
        int num = 2;
        fun1 (num);
        Console.WriteLine(num);
        Console.ReadLine();
    }
    static void fun1(int num)
    {
        num = num * num * num;
    }
}
```

1. ✔ 8
2. 0
3. 2
4. 16

---
What will be the output?

```csharp
 class program
{
    static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 4, 5)); 
            Console.ReadKey();
        }

        static int Add(int a, int b, int c)
        {
            int a=5;
            int b=6;
            int c=7;
            return a + b + c;
        }
}
```

1. ✔ Error
2. 12
3. System.SemiTransendentError() GatawayCurropted:412a
4. 18

---
What will be the output?

```csharp
 class program
{
    static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5, 8)); 
            Console.ReadKey();
        }

        static int Add(int a, int b, int c)
        {
            return ((a + (b)) + c);
        }
}
```

1. ✔ 18
2. Compilation Error
3. System.SemiTransendentError() GatawayCurropted:412a
4. 36

---
What will be the output?

```csharp
 class program
{
    sstatic void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5)); 
            Console.ReadKey();
        }

        static int Add(int a, int b, int c)
        {
            return ((a + (b)) + c);
        }
        static int Add(int a, int b)
        {
            return ((a + (b)));
        }
}
```

1. ✔ 10
2. Compilation Error
3. System.SemiTransendentError() GatawayCurropted:412a
4. System OwerRiding Error