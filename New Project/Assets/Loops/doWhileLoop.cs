using UnityEngine;
using System.Collections;

public class doWhileLoop : MonoBehaviour {
	int a = 10;
	// Use this for initialization
	void Start () {
		do {
			print ("value: " + a);
			a--;
		} while (a > 0);
	}
}


