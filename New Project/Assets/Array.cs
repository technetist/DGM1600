using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour 
{
	public GameObject[] Shape;

	void Start(){
		Shape = GameObject.FindGameObjectsWithTag("Shape");

		for (int i = 0; i < Shape.Length; i++) {
			Debug.Log("Shape "+i+" is named "+Shape[i].name);
		}
	}

	/*public int[] myArray = new int[3];
	void Start () 
	{
		myArray [0] = 23;
		myArray [1] = 67;
		myArray [2] = 78;

		Debug.Log (myArray [2]);
	}

	int[] myArraySecond = {32, 45, 67};*/
		
}


