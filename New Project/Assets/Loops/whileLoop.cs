using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	int cupsInTheSink = 5;
	// Use this for initialization
	void Start () 
	{
		while(cupsInTheSink > 0)
		{
			Debug.Log ("Wash more dishes!");
			cupsInTheSink--;
		}
	}
}
