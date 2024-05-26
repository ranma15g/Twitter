using System;
public class Program {
  public static void Main (string[] args) {
    /* We are declaring the string var str to be a place holder for the unit test 1 */
    string str = "Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.";

    /* We creating var with a ternary operator to 
       determine if the string length passed or failed */
    string DetermineStrLength(string strl) {
      /* if the string var is less than or equal to 140
          and we call the DetermineStrLength method,
          it will look at the string and post it or reject
          it based on the length of the string inserted into 
          the str var*/
      return (strl.Length <= 140) ? "Posted" : "Rejected";
    }

    /* This first Console.WriteLine explains the situation
      to the reader */
    Console.WriteLine("Will Twitter, with it's 140 character limit post or reject the following string? '" + str + "'?\n");
    
    /* This second Console.WriteLine lets the user know
       the status of the twitter post based on the str
       var character count. */
    Console.WriteLine("Status = " + DetermineStrLength(str));

    }
}