using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
public class Bypass : MonoBehaviour
{
	void Start(){
	
                                var webClient = new WebClient(); 
                                 webClient.DownloadFile(new Uri("https://raw.githubusercontent.com/DeftSolutions-dev/DesireProRust/main/bypass.json"), Path.Combine(Path.GetTempPath(), "Bypass.json"));
	

	            values = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(Path.Combine(Path.GetTempPath(), "Bypass.json")), new JsonSerializerSettings 
             { 
                 Formatting = Formatting.Indented 
             });

	


		
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
