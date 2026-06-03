

// decimal is similar to a double, but it is more precise. stores values up to 28 digits long. so they are used where precision is important (banks, spaceflight, ...)


// Int32 - 000000000 000000000 000000000 000000001 (1 as an int)


decimal bankAccountBalance;

//bankAccountBalance = 2.34; // this is a double
bankAccountBalance = 2.34M; // this is a decimal, the M is only needed when you are assigning it a value. if it's retrieved from a database it's not needed

Console.WriteLine(bankAccountBalance);