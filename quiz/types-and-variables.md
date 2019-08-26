---
Which will convert type string to type int?

1. int number = Convert.ToInt32(Console.ReadLine());
2. int number = int.Parse(Console.ReadLine());
3. ✔ Both


---
Can a variable name start with a digit?

1. Yes
2. ✔ No
3. Yes, but is not recomended


---
What will be the outcome?

```csharp
int nr1 = 10;
double nr2 = 10.5;
int nr3 = nr1 + nr2;
Console.Write(nr3);
```

1. ✔ Error
2. 20.5
3. 20


---
What will be the outcome?

```csharp
int x = 5;
int y = 2;
double sum = (double) x / (double) y;
Console.WriteLine(sum);
```

1. ✔ 2.5
2. Compilation error
3. 2

---
What will be the outcome?

```csharp
int x = 3;
int y = 7;
string sum = ten;
Console.WriteLine($"{x} + {y} = {sum}");
```

1. 10
2. ✔ Compilation error
3. 3 + 7 = ten


---
What will be the outcome?

```csharp
string event = "birthday";
Console.WriteLine($"{event}");
```

1. birthday
2. ✔ Compilation error

---
What will be the outcome?

```csharp
static void Main(string[] args)
 {
     char a = 'A';
     string b = "a";
     Console.WriteLine(Convert.ToInt32(a));
     Console.WriteLine(Convert.ToInt32(Convert.Tochar(b)));
 }
```

1. 1, 97
2. ✔ 65, 97
3. 97, 65
4. 97, 1

---
What will be the outcome?

```csharp
static void Main(string[] args)
{
    String name = "Dr.Gupta";
    Console.WriteLine("Good Morning" + name);
}
```

1. Dr.Gupta
2. Good Morning
3. ✔ Good Morning Dr.Gupta
4. Good Morning name

---
Which is the String method used to compare two strings with each other?

1. CompareTo()
2. ✔ Compare()
3. Copy()


---
With one is correct?

1.  string a = 5;
2. ✔ string b = "5";
3. string c = '5';

---
What will be the outcome?

```csharp
short a = 1000032634 - 1000000000;
         
            Console.WriteLine(a);
```

1. System.OutOfRange
2. Compilation Error
3. ✔ G32634
4. Cant Convert Long to Short      

---
What will be the outcome?

```csharp
char a = 'z';
            char z = 'a';
            if(!a==z)

                Console.WriteLine(a);
```

1. a
2. z
3. ✔ Compilation Error
4. Math.PI(a-z) 