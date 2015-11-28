﻿using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{
    RaycastHit hit;

    private int bulletAmt;
    public int maxBullets;

	// Use this for initialization
	void Start ()
    {
        GameManager.OnSpawnDucks += ResetBullets;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            bulletAmt--;

            if(bulletAmt <= 0)
            {
                GameManager.OnDuckMiss();
                Debug.Log("No more ammo");
            }

            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.transform.position.z;

            if(Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
            {
                if(hit.transform.tag == "Duck")
                {
                    //use getcompoenet in hit to get duck health script. Using that, call the kill duck function in the duck health script
                    hit.collider.gameObject.GetComponent<DuckHealth>().KillDuck();
                }
            }
        }
	}
    public void ResetBullets()
    {
        bulletAmt = maxBullets;
    }
}