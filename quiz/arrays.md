---
What will be the outcome?

```csharp
int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(arr[5]);
```

1. ✔ Error
2. 5
3. Null


---
Which is the maximum amount of dimensions an array can have?


1. 1
2. 2
3. ✔ 32
4. Unlimited


---
What will be the outcome?

```csharp
string[] arr = { "--5-", "-6-", "--3--" };
Console.WriteLine(arr[0].Length);
```

1. 3
2. 5
3. ✔ 4
4. 0


---
What will be the outcome?

```csharp
int [] myArray = { 1, 6, 3, 4,};
Console.WriteLine(myArray[2]);
```

1. ✔ 3
2. 2
3. 6

---
What will be the outcome?

```csharp
int[] table = new int[2, 2] {{ 3, 6}, { 2, 4}};
Console.WriteLine(table[1, 1]);
```

1. 4
2. ✔Compilation error 
3. 3

---
What will be the outcome?

```csharp
 int[] myArray = { 2, 4, 6, 8 };
            myArray[3] = 10;
            myArray[1] = 3;
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine($"{sum}");
```

1. 20
2. ✔21
3. 25

---
Which of the following correctly declares an array of four integers?

1. ```Int[] ages = new int[4] {20, 30, 40, 50};```
2. ```Int[] ages = new int[] {20, 30, 40, 50};```
3. ```Int[] ages = {20, 30, 40, 50}; ```
4. ✔All of these

---
When an ages array is correctly initialized using the values {20, 30, 40, 50}, then the value of ages[1] is:

1. 0
2. 20 
3. ✔30

---
When you declare an array as int[] temperature = {0, 32, 50, 90, 212, 451};, the value of temperature.Length is:

1. 5
2. ✔6 
3. 7

---
What will be the outcome?

```csharp
int[] array = { a,b,c,d };
Console.WriteLine(arr[3]);
```

1. ✔ Error
2. d
3. c

---
What will be the outcome?

```csharp
int[] array{1,2,3,4,5};
if(array[3]==4)
Console.WriteLine("yes");
else
Console.WriteLine("no");
```

1. ✔ no
2. yes
3. 4

---
What will be the outcome?

```csharp
int[] array{1,2,3,4,5};
if(array[5]==5)
Console.WriteLine("yes");
else
Console.WriteLine("no");
```

1. ✔ error
2. yes
3. no