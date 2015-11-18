using UnityEngine;
using System.Collections;

public class DirectionChanger : MonoBehaviour {
	public enum Changer {Horizontal, Vertical}
	public Changer changer;
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}

	void OnCollisionEnter(Collision hit)
	{
		if (hit.transform.tag == "Duck") 
		{
			DuckMovement movement = hit.gameObject.GetComponent<DuckMovement>();

			if(changer == Changer.Horizontal)
			{
				movement.DirectionChanger(new Vector3(-1, 1, 0));
			}
			else if(changer == Changer.Vertical)
			{
				movement.DirectionChanger(new Vector3(1, -1, 0));
			}
		}
	}
}
