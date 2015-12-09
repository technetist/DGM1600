using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {
	public GameObject[] bullets;
	//public Sprites[] ducks;
	public Text score;

	// Use this for initialization
	void Start () {
		GameManager.OnSpawnDucks += ResetBullets;
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}

	public void DisableBullet(int index)
	{
		if (index >= 0 && index < bullets.Length) 
		{
			bullets [index].SetActive (false);
		}
	}

	void ResetBullets()
	{
		foreach (GameObject bul in bullets) {
			bul.SetActive (true);
		}
	}
}
