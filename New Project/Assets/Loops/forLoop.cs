using UnityEngine;
using System.Collections;

public class forLoop : MonoBehaviour {
		
	int peeps = 0;

	void Start () {
		for(int i = 6; i > peeps; i--)
		{
			Debug.Log("There are " + i + " people in front of you.");
		}
	}
}
