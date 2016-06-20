using System;
     
public class Test
{
	public static void Main()
	{
		string str=Console.ReadLine();
                string[] splitedNames = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(splitedNames[0]);
                Console.WriteLine(splitedNames[1]);
                Console.WriteLine(splitedNames[2]);
                Console.WriteLine(splitedNames[3]);
	}
}
