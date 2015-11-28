using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour {
	public GameObject duck;

	// Use this for initialization
	void Start () {
        GameManager.OnSpawnDucks += SpawnDuck;
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}

	public void SpawnDuck()
	{
		Debug.Log("Spawn Duck");
		Instantiate (duck, transform.position, Quaternion.identity);
	}
}
