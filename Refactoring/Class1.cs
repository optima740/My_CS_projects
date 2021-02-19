using System;

public class Program
{
	static void Main()
	{
		Console.WriteLine(ShouldFire1(true, "boss", 101));
	}

	//ниже приведен пример рефакторинга кода. 
	//ShouldFire1 - первоначальный вариант. 
	//ShouldFire2 - результат оптимизации, используя единственный оператор return
	static bool ShouldFire1(bool enemyInFront, string enemyName, int robotHealth)
	{
		bool shouldFire = true;
		if (enemyInFront == true)
		{
			if (enemyName == "boss")
			{
				if (robotHealth < 50) shouldFire = false;
				if (robotHealth > 100) shouldFire = true;
			}
		}
		else
		{
			return false;
		}
		return shouldFire;
	}

	static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
	{
		return ((enemyInFront) && ((enemyName == "boss") && ((robotHealth > 49))) || ((enemyInFront) && (enemyName != "boss"));
	}
}
