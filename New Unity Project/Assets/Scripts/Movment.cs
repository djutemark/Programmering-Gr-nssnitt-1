using UnityEngine;
using System.Collections;

public class Movment : MonoBehaviour {
	public float speed = 3f;
	public float jump = 300f;

	[HideInInspector]
	public HealthBar health;

	[HideInInspector]
	public int score;
	// Use this for initialization
	void Start () {
		health.maxHealth = 100;
		health.curHealth = 100;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (Vector3.down * speed * Time.deltaTime);



	}



	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			score++;
			health.curHealth = health.curHealth - 1;
			Destroy(coll.gameObject);
		}
	}


	void OnGUI () {
		GUI.Label(new Rect(10, 40, 100, 25), "Score: " + score);
	}

}
