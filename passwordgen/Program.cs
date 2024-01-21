using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Random res = new Random(); 
    var charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLM0123456789!@#$%&*+="; 
    int size = 13;
    // Initializing the empty string 
    var randPass = "";   
    for (int i = 1; i < size; i++) 
    {   
        // Selecting a index randomly 
        int x = res.Next(charSet.Length);   
        // Appending the character at the  
        // index to the random alphanumeric string. 
        randPass = randPass + charSet[x]; 
    }   
    Console.WriteLine("Random generated password: " + randPass);
    randPass = System.Text.Encoding.UTF8.GetBytes(randPass);
  return System.Convert.ToBase64String(randPass);

    