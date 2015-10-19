using UnityEngine;
using System.Collections;

public class ClassandStuff : MonoBehaviour {

	public class Military
	{
		public int army;
		public int navy;
		public int airforce;

		public Military(int ar, int na, int ai)
		{
			army = ar;
			navy = na;
			airforce = ai;
		}

		public Military()
		{
			army = 10;
			navy = 5;
			airforce = 2;
		}
	}

	Military playerMil = new Military (6,7,1);

	void Start () {
		string temp = "0";

		Test (playerMil, temp);
		//Debug.Log(Military.ar);
		Debug.Log(playerMil.airforce);
		Debug.Log(temp);
	}
	

	void Test(Military mil, string num)
	{
		mil.airforce = 100;
		num = "hello";
	}
}

