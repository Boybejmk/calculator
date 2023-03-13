class calculator
{
	static void main(string[]args)
	{
		int a = 10;
		int b = 20;
		
		console.writeline("hasil penambahan: {0} + {1} = {2}",a, b, penambahan (a,b));
		console.writeline("hasil pembagian: {0} / {1} = {2}",a, b, pembagian (a,b));
		console.writeline("hasil pengurangan: {0} + {1} = {2}",a, b, pengurangan (a,b));
		
		console.writeline("\ntekan sembarang untuk keluar");
		console.readkey();
	}
	static int penambahan (int a, int b)
	{
		return a+b
	}
	static int pengurangan (int a, int b)
	{
		return a-b
	}
	static int pembagian (int a, int b)
	{
		return a/b
	}
	
}