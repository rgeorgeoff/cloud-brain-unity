using UnityEngine;
using System.Collections;

public class MoveRight : MonoBehaviour {

	float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (Time.deltaTime*speed, 0, 0);
	}


}
