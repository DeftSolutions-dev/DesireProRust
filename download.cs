using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
public class Bypass : MonoBehaviour
{
	void Start(){
		var fileName = Path.Combine(Environment.ExpandEnvironmentVariables("%appdata%"), "bypass.json");
                var address = "https://github.com/DeftSolutions-dev/DesireProRust/raw/main/bypass.json";
                if (File.Exists(fileName))
                    File.Delete(fileName);
	        using (WebClient wc = new WebClient())
                {
                      wc.DownloadFileAsync(new System.Uri(address),fileName);
                }
	        values = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(fileName));
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
