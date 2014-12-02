using UnityEngine;
using System.Collections;

public class MonsterHandler : MonoBehaviour {

	public float spawnTime;
	private float time;
	public GameObject[] monsterTypes;

	void Start () {
		time = 0;
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time >= spawnTime) {
			Instantiate(monsterTypes[Random.Range(0, monsterTypes.Length - 1)], new Vector2(Random.Range(-8f, 8f), Random.Range(-8f, 8f)), new Quaternion(0, 0, 0, 0));
			time = 0;
		}
	}

	void OnGUI () {
		GUI.Label (new Rect (10, 10, 125, 25), "Time: " + time);
	}

}
