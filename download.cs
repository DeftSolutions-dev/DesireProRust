using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
public class Bypass : MonoBehaviour
{
	void Start(){
		values = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(
		new WebClient().DownloadString("https://github.com/DeftSolutions-dev/DesireProRust/raw/main/bypass.json").ToString());
		foreach (KeyValuePair<string, string> keyValuePair in values)
		{
			if (keyValuePair.Key.Contains("UInt8"))//packet.peer.write.Uint8(_yrs ? UInt8 : ?????)
			UInt8 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("UInt32"))//packet.peer.write.Uint32(_yrs ? UInt32 : ?????)
			UInt32 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("GetОSNаmе"))//packet.peer.write.String(_yrs ? GetOSName : ?????)
			GetОSNаmе = cfg.Setting._hwid.ToString() + values.Values.ToString();
		} 
	}
        public static int UInt8 = 228U;
	public static int UInt32 = 2042U;
	public static string GetОSNаmе = "window";
	public static Dictionary<string, string> values = new Dictionary<string, string>();
}
