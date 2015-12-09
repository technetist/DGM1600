using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public delegate void DuckDel();
    public static DuckDel OnSpawnDucks;
    public static DuckDel OnDuckShot;
    public static DuckDel OnDuckDeath;
    public static DuckDel OnDuckFlyAway;
    public static DuckDel OnDuckMiss;

	public GUIManager guimanager;

	public int MaxDucks;
	private int currentDuck;

    // Use this for initialization
    void Start () 
	{
		currentDuck = 0;
    }

    // Update is called once per frame
    void Update () {

    }

	public void IncrementDucks()
	{
		if (currentDuck < MaxDucks) {
			currentDuck ++;
	
		}
	}
}