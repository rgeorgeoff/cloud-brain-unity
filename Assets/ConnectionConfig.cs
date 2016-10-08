using UnityEngine;
using System.Collections;
using System.IO;

public class ConnectionConfig : ScriptableObject{

	public string type;
	public string deviceName;
	public string deviceId;
	public string metric;

	public ConnectionConfig(string _type, string _deviceName, string _deviceId, string _metric)
	{
		this.type = _type;
		this.deviceId = _deviceId;
		this.deviceName = _deviceName;
		this.metric = _metric;
	}
	

	public string GetConnectionString()
	{
//		Debug.Log (JsonUtility.ToJson(this));
		return JsonUtility.ToJson (this);
	}
}
