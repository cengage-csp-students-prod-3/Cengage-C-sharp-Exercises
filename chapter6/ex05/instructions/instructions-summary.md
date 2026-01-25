Write a program called *DeliveryCharges* for the package delivery service in Exercise 4.
The program should again use an array that holds the 10 zip codes of areas to which the company makes deliveries. (Note that this array has been created for your and does not need to be changed.)
```cs
string[] zips = {"12789", "54012", "54481", "54982", "60007", "60103", "60187", "60188", "71244", "90210"};       
```
A parallel array has also been created containing 10 delivery charges that differ for each zip code. 
```cs
double[] prices = {2.40, 3.00, 3.50, 4.00, 4.50, 5.00, 5.25, 5.75, 6.10, 10.00};
```
Prompt a user to enter a zip code, and then display either a message indicating the price of delivery to that zip code or a message indicating that the company does not deliver to the requested zip code.

For example, if the zip code is in the delivery area, such as **90210**, output **Delivery to 90210 ok.  Delivery charge is $10.00**.

If the zip code is not in the delivery area, such as **85205**, output **Sorry - no delivery to 85205**.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
