using System;
public class Program {
  public static void Main (string[] args) {
    /* We are declaring the string var str to be a place holder for the unit test 1 */
    string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id semper risus in hendrerit. Viverra mauris in aliquam sem. Arcu felis bibendum ut tristique et egestas quis. Pretium fusce id velit ut tortor pretium viverra suspendisse. Arcu cursus vitae congue mauris rhoncus aenean vel elit. In nisl nisi scelerisque eu ultrices. Mattis enim ut tellus elementum sagittis vitae et leo duis. In massa tempor nec feugiat. Feugiat nibh sed pulvinar proin. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Scelerisque eu ultrices vitae auctor eu augue ut. Ac turpis egestas integer eget aliquet nibh praesent tristique. Viverra suspendisse potenti nullam ac tortor. Tortor id aliquet lectus proin. Dictum non consectetur a erat nam at lectus urna duis. Dui vivamus arcu felis bibendum ut tristique et egestas.";

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