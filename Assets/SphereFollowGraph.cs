using UnityEngine;
using System.Collections;

public class SphereFollowGraph : MonoBehaviour {

	CloudBrainDataStreamParse x;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition = new Vector3 (this.transform.localPosition.z, x.signal1, this.transform.localPosition.z);
	}

	public void setCloudBrainDataStreamParse(CloudBrainDataStreamParse _x)
	{
		x = _x;
	}
}
