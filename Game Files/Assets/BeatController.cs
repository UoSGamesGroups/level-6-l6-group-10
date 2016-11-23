using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Beat {
	public float offset;
	public float interval;

	public Beat (float offset, float interval) {
		this.offset = offset;
		this.interval = Mathf.Abs(interval);
	}

	public float position (float time) {
		return (time + offset) % interval;
	}
}

public class BeatController : MonoBehaviour {

	public GameObject beatPrefab; //Set the sprite object
	public Transform beatTransform; //Set gameobject position

	private GameObject beatObject; //
	private Beat beat; //

	// Use this for initialization
	void Start () {
		beat = new Beat (0, 2); //Beat is equal to 
		beatObject = Instantiate(beatPrefab); //Create new gameobject
	}
	
	// Update is called once per frame
	void Update () {
		var m = beatObject.GetComponent(typeof(Transform)) as Transform;
		var p = beat.position (Time.time);
		m.position = new Vector2 (p, 0);
	}
}