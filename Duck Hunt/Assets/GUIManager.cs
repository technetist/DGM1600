using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {
	public GameObject[] bullets;
	public Image[] DUCKS;
	public Text score;

	// Use this for initialization
	void Start () {
		GameManager.OnSpawnDucks += ResetBullets;
        GameManager.OnFinish += ResetDucks;
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
    
    public void ChangeDuck(int index)
    {
        if(index >= 0 && index < DUCKS.Length)
        {
            DUCKS[index].color = Color.red;
        }
    }

    private void ResetDucks()
    {
        foreach (Image d in DUCKS)
        {
            d.color = Color.white;
        }
    }

    public void SetScore(int _score)
    {
        score.text = _score.ToString();
    }
}
