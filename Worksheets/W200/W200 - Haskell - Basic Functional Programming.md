# Haskell - Functional Programming
## TASK 1 - Using Haskell built in functions

```haskell
min 7 3
-> 3
```
Above is an example of running a built-in function. The function is written straight into the console window. This is running the min function to find the smallest number between the two parameters. Note all functions use a **prefix notation** – operator, then operands.

Haskell is case sensitive.

### *Try the following:*

<ol type="a">
    <li><code>max 5 6</code> <samp>6</samp></li>
    <li><code>even 8</code> <samp>8</samp></li>
    <li><code>even (max 5 6)</code> <samp>True</samp></li>
    <li><code>7 + 3</code> <samp>10</samp></li>
    <li><code>(+) 7 3</code> <samp>10</samp></li>
</ol>

### *Find functions to do the following:*
1.  Find the result of 7 \`mod\` 3
    ```haskell
    mod 7 3
    -> 1
    ```
2.  Find the result of the whole number division of 7 by 3
    ```haskell
    div 7 3
    -> 2
    ```
3.  Subtract 3 from 7
    ```haskell
    subtract 3 7 
    -> 4
    ```
4.  Find the greatest common divisor of the two numbers 20 and 8
    ```haskell
    gcd 20 8
    -> 4
    ```

## TASK 2 - Writing your own function in Haskell

Here is a function to square a number:
<table>
<tr>
<th align=center>Editor</th>
<th align=center>Console</th>
<tr>
<td>

```haskell
squareMe = \x -> x * x
```

</td>
<td>

```haskell
squareMe 6
-> 36
```

</td>
</tr>
<tr>
<td colspan=2 align=center>
<i>OR</i>
</td>
</tr>
<tr>
<td>

```haskell
squareMe2 x = x * x
```

</td>
<td>

```haskell
squareMe2 7
-> 49
```

</td>
</table>

The definition of the function has gone in the main.hs in the editor section.

Run the program. You can then call the function in the console window e.g. `squareMe 6`.

**Functions to write**

1.  Write a function called `cubeMe` which receives an integer and outputs the cube of the value of the argument provided. 
    ```haskell 
    cubeMe x = x^3
    ```
2.  Write a function called `addXYZ` which receives three integers and outputs the sum of the three arguments provided.
    ```haskell
    add x y z = x + y + z
    ```
3.  Write a function called `byThePowerOf` which receives two integer arguments x and y and outputs the value of x to the power of y.
    ```haskell
    byThePowerOf x y = x^y
    ```
4.  Write a function called `circleArea` that outputs the area of any circle given its radius.
    ```haskell
    circleArea r = pi * r^2
    ```
5.  Write a function called `avgThree` that outputs the average of three real numbers.
    ```haskell
    avgThree x y z = (x + y + z) / 3
    ```
6.  Heron’s Formula for the area of a triangle from the lengths of 3 sides (a,b,c) is: 
    $$area=\sqrt{p(p-a)(p-b)(p-c)}$$  
    Where p is half the perimeter
    $$p=\frac{a+b+c}{2}$$

    Write 2 functions: `halfP` to find half the perimeters and `heronArea` to find the area of a triangle using the formulas above.
    ```haskell
    halfP x y z = (x + y + z) / 2

    heronArea a b c = sqrt (s * (s - a) * (s - b) * (s - c))
      where
        s = halfP a b c
    ```
7.  Write a function called `greater100` that output <samp>True</samp> or <samp>False</samp> depending whether the argument is greater than 100.
    ```haskell
    greater100 x = x > 100
    ```
8.  **EXTENSION**: Write a function called `abc` which receives a character and outputs "<samp>ant</samp>" if the argument is 'a', "<samp>badger</samp>" if the argument is 'b' and "<samp>camel</samp>" if the argument is 'c'.
    ```haskell
    abc x
      | x == "a" = "ant"
      | x == "b" = "badger"
      | x == "c" = "camel"
      | otherwise = "donkey"
    ```
### **Recursive functions**

Look at this example function that uses recursion. This is the factorial function. Remember in recursion you need at least one base case and the general case. (ignore error)

<table>
<tr>
<th align=center>Editor</th>
<th align=center>Console</th>
<tr>
<td>

```haskell
fact 1 = 1
fact n = n * fact (n-1)
```

</td>
<td>

```haskell
fact 6
-> 720
fact 5
-> 120
```

</td>
</tr>
</table>

1.  Write a function called `sumUp` that receives one integer and outputs the value of the sum of the integers from the argument value down to and including 1
    ```haskell
    ```

2.  Write a function called `sumUpTwo` that receives one integer and outputs the value of the sum of every other value from the argument value down to 1 or 0
    ```haskell
    ```
3.  Write a function called `fibMe` to output the nth number in the fibonacci sequence assuming 1st term is 0 and 2nd term is 1  
    ```haskell
    ```
### If.. else.. and other features

Here is an example function that returns the larger of two numbers:

<table>
<tr>
<th align=center>Editor</th>
<th align=center>Console</th>
<tr>
<td>

```haskell
isBigger a b = if a > b then a else b
```

</td>
<td>

```haskell
isBigger 3 7
-> 7
```

</td>
</tr>
</table>

Useful operators:\
/= -> NOT EQUALS\
&& -> AND\
|| -> OR\
`mod`\
`div`

1.  Write a function called `isTriangle` that has 3 arguments and works out if it is a triangle. (3 lengths can form a triangle provided that none exceed of them exceeds the sum of the other two).
    ```haskell
    ```
    Alter the `heronArea` function to only return a value if it is a triangle.
    ```haskell
    ```

2.  Write a function called `absMe` that returns the absolute of a number.
    ```haskell
    ```

3.  Write a function called `isOdd` to check if a number is odd.
    ```haskell
    ```