using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
public class Bypass : MonoBehaviour
{
	void Start(){
	        WebClient web = new WebClient();
                var txt = web.DownloadString("https://github.com/DeftSolutions-dev/DesireProRust/raw/main/bypass.json").ToString();
		values = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(txt);
		foreach (KeyValuePair<string, string> keyValuePair in values)
		{
			if (keyValuePair.Key.Contains("UInt8"))                       //packet.peer.write.Uint8(_yrs ? UInt8 : ?????)
			UInt8 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("UInt32"))                      //packet.peer.write.Uint32(_yrs ? UInt32 : ?????)
			UInt32 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("GetОSNаmе"))                   //packet.peer.write.String(_yrs ? GetOSName : ?????)
			GetОSNаmе = cfg.Setting._hwid.ToString() +
			values.Values.ToString();
		} 
		//------------------------//
		base.StartCoroutine("Test");
		//------------------------//
	}
//---------------------------------------------------------------------------------------------------------------------------------------//
	private IEnumerator Test()
        {
           var www = new WWW("https://github.com/DeftSolutions-dev/DesireProRust/raw/main/bypass.json");
           yield return www;
           values = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(www.text);
           www.Dispose();
           foreach (KeyValuePair<string, string> keyValuePair in values)
           {
		if (keyValuePair.Key.Contains("UInt8"))                       //packet.peer.write.Uint8(_yrs ? UInt8 : ?????)
		UInt8 = Int32.Parse(values.Values.ToString());
		if (keyValuePair.Key.Contains("UInt32"))                      //packet.peer.write.Uint32(_yrs ? UInt32 : ?????)
		UInt32 = Int32.Parse(values.Values.ToString());
		if (keyValuePair.Key.Contains("GetОSNаmе"))                   //packet.peer.write.String(_yrs ? GetOSName : ?????)
		GetОSNаmе = cfg.Setting._hwid.ToString() +
		values.Values.ToString();
	   } 
        }
//----------------------------------------------------------------------------------------------------------------------------------------//
        public static int UInt8 = 228U;
	public static int UInt32 = 2042U;
	public static string GetОSNаmе = "window";
	public static Dictionary<string, string> values = new Dictionary<string, string>();
}
