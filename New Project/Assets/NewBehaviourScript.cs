using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	int myInt = 6;
	
	void Start () {
		myInt = multiplyByTwo (myInt);
		Debug.Log (myInt);
	}
	
	int multiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
