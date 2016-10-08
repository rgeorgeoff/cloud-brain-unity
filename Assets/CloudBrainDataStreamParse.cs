using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloudBrainDataStreamParse {

	public float signal1 = 0;

	public void ParseNewData(string input)
	{
		//THIS PARSING NEEDS TO BE CLEANED.... SO IGNORE IT FOR NOW!
		Debug.Log (input);
		string[] myStrings = input.Split(new char[1]{','});
		foreach (string s in myStrings) {
			//Debug.Log (s);
			if (s.Contains ("channel_1")) {
				signal1 = float.Parse(s.Split(new char[1]{':'})[1]);
			}
		}
	}
	/*
	float channel_5 = 7.197029498454579;
	"channel_4":7.197029498454579,
	"channel_7":7.197029498454579,
	"channel_6":7.197029498454579,
	"channel_1":7.197029498454579,
	"channel_0":7.197029498454579,
	"channel_3":7.197029498454579,
	"channel_2":7.197029498454579,
	"timestamp":1139164000,
	"metric":"eeg",
	"device_name":"openbci",
	"device_id":"teddy"
	*/
}
