using System;

class Teste
{

	static void Main(string[] args)
	{
		int tst;
		int lnth;
		string name = new string(new char[10100]);
		string tempVar = Console.ReadLine();
		if (tempVar != null)
		{
			tst = int.Parse(tempVar);


			while ((tst--) != 0)
			{
				string[] tempVar2 = Console.ReadLine().Split();
				if (tempVar2 != null)
				{
					name = tempVar2[0];
				}
				lnth = name.Length;
				Console.Write("{0:f2}\n", lnth * .01);
			}
		}
	}

}