using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
public class Bypass : MonoBehaviour
{
	void Start(){
		values = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(new WebClient().DownloadString("https://raw.githubusercontent.com/DeftSolutions-dev/DesireProRust/main/bypass.json").ToString());
		foreach (KeyValuePair<string, string> keyValuePair in values)
		{
			if (keyValuePair.Key.Contains("UInt8"))
			UInt8 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("UInt32"))
			UInt32 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("GetОSNаmе"))
			GetОSNаmе = cfg.Setting._hwid + values.Values.ToString();
		} 
	}
        public static int UInt8 = 228U;
	public static int UInt32 = 2042U;
	public static string GetОSNаmе = "";
	public static Dictionary<string, string> values = new Dictionary<string, string>();
}
