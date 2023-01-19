using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
public class Bypass : MonoBehaviour
{
	void Start(){
	        try
	        {
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		WebClient webClient = new WebClient();
		webClient.DownloadFile(new Uri("https://github.com/DeftSolutions-dev/DesireProRust/raw/main/FuckYou/bypass.json"), 
		Path.Combine(Path.GetTempPath(), "bypass.json"));
		}catch{}
	        values = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(Path.Combine(Environment.ExpandEnvironmentVariables("%temp%"), "bypass.json")));
		foreach (KeyValuePair<string, string> keyValuePair in values)
		{
			if (keyValuePair.Key.Contains("UInt8"))
			UInt8 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("UInt32"))
			UInt32 = Int32.Parse(values.Values.ToString());
			if (keyValuePair.Key.Contains("GetОSNаmе"))
			GetОSNаmе = cfg.Setting._hwid.ToString() + values.Values.ToString();
		} 
	}
        public static int UInt8 = 228U;
	public static int UInt32 = 2042U;
	public static string GetОSNаmе = "";
	public static Dictionary<string, string> values = new Dictionary<string, string>();
}
