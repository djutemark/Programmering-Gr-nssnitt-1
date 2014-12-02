using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public int curHealth, maxHealth;
	public GameObject bar;

	// Update is called once per frame
	void Update () {
		if (maxHealth <= 0) maxHealth = 1;

		if (curHealth <= 0) {
		//	Dead();
		}
		if (Input.GetKey(KeyCode.R)) curHealth--;

		bar.transform.localScale = new Vector2 (bar.transform.localScale.x * curHealth / maxHealth , bar.transform.localScale.y);

	}

	void Dead () {
		// Do what will happen when you die!!!
		if (gameObject.tag != "player")
						Destroy (gameObject);
				else if (gameObject.tag == "player")
						Application.LoadLevel ("Game Over");
	}
}
