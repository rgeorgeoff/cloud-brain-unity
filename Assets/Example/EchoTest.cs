using UnityEngine;
using System.Collections;
using System;

public class EchoTest : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		
		//WebSocket w = new WebSocket(new Uri("ws://echo.websocket.org"));
		WebSocket w = new WebSocket(new Uri("ws://node6.getcloudbrain.com:31415/rt-stream/websocket"));
		ConnectionConfig c = new ConnectionConfig ("subscription", "openbci", "teddy", "eeg");
		CloudBrainDataStreamParse cbdsp = new CloudBrainDataStreamParse ();
		GameObject.FindGameObjectWithTag ("Sphere").GetComponent<SphereFollowGraph> ().setCloudBrainDataStreamParse (cbdsp);
		//WebSocket w = new WebSocket(new Uri("ws://node6.getcloudbrain.com:31415/rt-stream"));
		yield return StartCoroutine(w.Connect());

		w.SendString(c.GetConnectionString());
		while (true)
		{
			string reply = w.RecvString();
			if (reply != null)
			{
				//Debug.Log ("Received: "+reply);
				cbdsp.ParseNewData(reply);
			}
			if (w.error != null)
			{
				Debug.LogError ("Error: "+w.error);
				break;
			}
			yield return 0;
		}
		w.Close();
	}
}
