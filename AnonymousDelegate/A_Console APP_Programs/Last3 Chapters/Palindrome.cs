string strRev,strReal = null;  
Console.WriteLine("Enter the string..");  
strReal = Console.ReadLine();  
char[] tmpChar = strReal.ToCharArray();  
Array.Reverse(tmpChar);  
strRev=new string(tmpChar);  
if(strReal.Equals(strRev, StringComparison.OrdinalIgnoreCase))  
{  
    Console.WriteLine("The string is pallindrome");  
}  
else  
{  
    Console.WriteLine("The string is not pallindrome");  
}  
    Console.ReadLine();  
