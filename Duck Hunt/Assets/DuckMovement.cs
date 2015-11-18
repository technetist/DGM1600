using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {
	public float speed;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		RandomDirection();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.position = transform.position + (direction * speed);
	}

	public void RandomDirection()
	{
		direction = new Vector3 (Random.Range (-1f, 1f), Random.Range (.2f, 1f), 0);
	}

	public void DirectionChanger(Vector3 _dir)
	{
		direction = new Vector3(direction.x * _dir.x, direction.y * _dir.y, 0);
	}
}
