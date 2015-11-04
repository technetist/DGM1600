using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	public int age = 13;

	// Use this for initialization
	void Start () {
		switch (age) {
		case 13:
			print ("I am 13");
			break;
		case 12:
			print ("I'm 12");
			break;
		case 2:
			print ("I'm really young");
			break;
		default:
			print ("I don't know my age");
			break;
		}
	}

}