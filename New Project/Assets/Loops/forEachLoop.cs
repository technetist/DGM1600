using UnityEngine;
using System.Collections;

public class forEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		string[] strings = {"Steve", "Adam", "Joe"};



		
	foreach (string item in strings) {
			print  (item);
		}
	}
}