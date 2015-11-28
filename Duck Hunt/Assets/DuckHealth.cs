using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour {
    Animator anim;

    bool isInvincible;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        GameManager.OnDuckMiss += MakeInvincible;
        GameManager.OnDuckShot += MakeInvincible;
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "KillZone")
		{
            GameManager.OnDuckDeath();
			Destroy(this.gameObject);
		}
        if (hit.tag == "FlyZone")
        {
            GameManager.OnDuckFlyAway();
            Destroy(this.gameObject);
        }
    }

    public void KillDuck()
    {
        if(isInvincible == false)
        {
            anim.Play("DuckDead");
            GameManager.OnDuckShot();
        }
    }

    public void MakeInvincible()
    {
        isInvincible = true;
    }
}
