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
    public static DuckDel OnFinish;

    public GUIManager guimanager;

	public int MaxDucks;
	private int currentDuck;

    public int scoreAmt;
    private int score;

	public static GameObject duckie;

    // Use this for initialization
    void Start () 
	{
        score = 0;

        SetScore();

        OnDuckShot += IncrementScore;
        OnDuckShot += SetScore;
		currentDuck = -1;
        OnSpawnDucks += IncrementDucks;
        OnDuckShot += ChangeDuckColor;
    }

    // Update is called once per frame
    void Update () {

    }

	private void IncrementDucks()
	{
		if (currentDuck < MaxDucks -1) {
			currentDuck ++;
		}
        else if(currentDuck >= MaxDucks -1)
        {
            currentDuck = -1;
            OnFinish();
            
        }
	}

    private void ChangeDuckColor()
    {
        guimanager.ChangeDuck(currentDuck);
    }

    private void IncrementScore()
    {
        score += scoreAmt;
    }

    private void SetScore()
    {
        guimanager.SetScore(score);
    }
}