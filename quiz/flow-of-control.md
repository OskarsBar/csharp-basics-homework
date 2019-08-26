---
Which will be the outcome?

```csharp
for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.Write(i);
            }
```

1. 123...100
2. 12345
3. ✔ 1234


---
Which will be the outcome?

```csharp
for (int i = 1; i <= 10; i++)
            {
                if (i < 9)
                {
                    continue;
                }
                Console.Write(i);
            }
```

1. 12345678910
2. ✔ 910
3. 123456789


---
In switch statment, is default obligatory?


1. ✔ No
2. Yes

---
Which will be the outcome?

```csharp
int number = 6;
    if (number > 0)
    {
       if (number % 2 != 0)
       {
          Console.WriteLine("Number is odd.");
       }
       Console.WriteLine("Number is negative.");
    }
     Console.WriteLine("This will print out.");
```

1. Number is odd
  Number is negative.
  This will print out.

2. ✔ Number is negative.
      This will print out.

3. This will print out.


---
Which will be the outcome?

```csharp
int number = 6;
  switch (number)
  { 
  case 2,
  case 4,
  case 6,
  case 8:
	Console.WriteLine("Number is even!");
	break;
  case 1,
  case 3,
  case 5,
  case 7,
  case 9:
     Console.WriteLine("Number is odd!");
      break;
  default:
      Console.WriteLine("I don't know this number.");
      break;
  }
```

1.Number is even
2. ✔ Compilation error
3. I don't know this number.


---
Which will be the outcome?

```csharp
  int x = 10;
  bool number = x > 10 ? false : true;
  Console.WriteLine(number);
```


1.✔ true
2. false
3. Compilation error

---
Which will be the outcome?

```csharp
  public void test(int x) 
{ 
    int odd = 1; 
    if(odd)
    {
        Console.WriteLine("odd"); 
    } 
    else 
    {
        Console.WriteLine("even"); 
    } 
}
```


1. ✔Compilation fails
2. "odd" will always be output
3. "even" will always be output

---
Which will be the outcome?

```csharp
int i = 1, j = 10; 
do 
{
    if(i > j) 
    {
        break; 
    } 
    j--; 
} while (++i < 5); 
Console.WriteLine("i = " + i + " and j = " + j);
```

1. i = 6 and j = 5
2. i = 6 and j = 4
3. ✔i = 5 and j = 6

---
Which will be the outcome?

```csharp
int i = l, j = -1; 
switch (i) 
{
    case 0, 1: j = 1; /* Line 4 */
    case 2: j = 2; 
    default: j = 0; 
} 
Console.WriteLine("j = " + j);
```

1. j = -1
2. j = 1
3. ✔Compilation fails

---
Which will be the outcome?

```csharp
int a = 5;
            if(a+0.5==5.5)
            Console.WriteLine("nice"); 
```

1. null
2. empty
3. ✔nice

---
Which will be the outcome?

```csharp
int a = 5;
            if(a+0.5==5.5)
            Console.WriteLine(a+0.5); 
            
```

1. empty
2. 5
3. ✔5.5

---
Which will be the outcome?

```csharp
int a = 5;
            if(a+++a==11)
            Console.WriteLine(a); 
            Console.ReadKey();
            
```

1. 11
2. 10
3. ✔6