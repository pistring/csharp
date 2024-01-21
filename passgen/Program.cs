var CharSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLM0123456789!@#$%&*+=";
Random rand = new Random();
var RandPass ="";
int size =13;
for (int i=1; i < size; i++)
{
	int x = rand.Next(CharSet.Length);
	RandPass = RandPass + CharSet[x];
}
Console.WriteLine("Temp Generated Pass : "+ RandPass);
