---
In a loop the keyword 'continue' will...

1. ✔ make the code run from top of the loop again.
2. Continue executing the code down.
3. Skip the rest of the loop iterations.


---
Which loop is best for collection?

1. for
2. ✔ foreach
3. while
4. do...while


---
Which loop will run at least once?

1. for
2. foreach
3. while
4. ✔ do...while

---
Which will be the outcome?

```csharp
 for (i = 0; i <= 4; i++)
  {
  if (i == 3)
     {
     Console.WriteLine($"Here we have 3 ");           
     }
	 else if (i != 2)
     {
      Console.WriteLine($"Here {i} is not 2 ");
     }
	 else
      Console.WriteLine($"Here {i} is {i} ");
  }
Console.ReadLine();
```

1. Here 0 is 2
Here 1 is 2
Here 2 is 2
Here we have 3
Here 4 is 4

2. ✔ Here 0 is not 2
Here 1 is not 2
Here 2 is 2
Here we have 3
Here 4 is not 2

3. Here 0 is not 2
Here 1 is not 2
Here 2 is 2
Here we have 3

---
Which loop is better when you know how many times you will need to execute it?

1. ✔ for
2. foreach
3. while
4. do...while

---
Which will be the outcome?

```csharp
int x = 6;
   do
   {
    Console.WriteLine($"x is {x}");
   } while (x > 5);
```

1. ✔ infinitive loop
2. x is 6
3. Compilation error
4. Will work, but won't show anything

---
Which will be the outcome?

```csharp
     static void Main(string[] args)
     {
         int i;
         for (i = 0;  ; )
         {
             Console.WriteLine("hello");
         }
         Console.ReadLine();
     }
```

1. No output
2. hello
3. ✔ hello printed infinite times
4. Code will give error as expression syntax

---
Which will be the outcome?

```csharp
  static void Main(string[] args)
  {
	  int i = 5;
	  for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i--)) ;
  }
```

1. 4 3 2 1
2. 3 2 1
3. ✔ 5 4 3 2 1
4. 2 1

---
Which will be the outcome?

```csharp
class FindOutput
    {
     static void Main(string[] args)
     {
       int i = 1, j = 5;
    do
    {
        Console.WriteLine(i = i++ * j);
    }while (i <= 10);
     }
}
```

1. ✔ 5 25
2. 5 10 15 20 25 30 35 40 45 50
3. 25 30
4. 5 11 16 21 26 31 36 41 46 51

---
Which will be the outcome?

```csharp
int x = 5;
            for(; ; )
            {
                Console.WriteLine("x+x");
                
            }
```

1. ✔ infinite x+x
2. infinite 10
3. Compilation Error
4. System.NoParameters: For

---
Which will be the outcome?

```csharp
for (int x = 0; x++; x < 5)
            {
                Console.WriteLine(x+x);
                
            }
```

1. ✔ Compilation Error
2. 0 2 4 6 8 10
3. x+x x+x x+x x+x x+x
4. System.NoParameters: For

---
Which will be the outcome?

```csharp
            for (int x = 0; x<=5; ++x)
            {
                Console.WriteLine(x+x);
                
            }
```

1. ✔ 0 2 4 6 8 10
2. 0 2 4 6 8 
3. x+x x+x x+x x+x x+x
4.  2 4 6 8 10 12