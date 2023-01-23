using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
public class Bypass : MonoBehaviour
{
        public static int UInt8 = 228U;
	public static int UInt32 = 2042U;
	public static string GetОSNаmе = "window";
	public static Dictionary<string, string> values = new Dictionary<string, string>();
//---------------------------------- method #1 -------------------------------------------------------------------------------------------//
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
	}
//---------------------------------- method #2 -------------------------------------------------------------------------------------------//

        void Start(){base.StartCoroutine("Test");}

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
//---------------------------------- method #3 -------------------------------------------------------------------------------------------//
        void Start(){
	        HttpWebRequest.DefaultWebProxy = new WebProxy();
                System.Net.WebClient wc = new System.Net.WebClient();
                var test = wc.DownloadString("https://github.com/DeftSolutions-dev/DesireProRust/raw/main/bypass.json");
                values = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(test); 
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
//---------------------------------- method #4 -------------------------------------------------------------------------------------------//
        void Start(){
	        base.StartCoroutine("Test1");
	}
    public static bool download = true;
    public IEnumerator Test1()
    {
        if (download)
        { 
            yield return new WaitForSeconds(0.5f);
            using (var client = new WebClient())
            {
                var uri = new Uri("https://github.com/DeftSolutions-dev/DesireProRust/raw/main/bypass.json"); 
                var txt = client.DownloadString(uri).ToString(); 
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
            } 
            download = false;
        }
    }
    
//---------------------------------- method #5 -------------------------------------------------------------------------------------------//
//tyt HOOK UIHUB
        public static bool download = true;
        private void Update()
	{
	    if (download)
            {  
                WebClient client = new WebClient();
                var uri = new Uri("https://github.com/DeftSolutions-dev/DesireProRust/raw/main/bypass.json"); 
                var txt = client.DownloadString(uri).ToString(); 
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
                download = false;
            }
	        var UI = GetCompanent<UIHUD>();
		var flag = UI.shouldShowHud && UI.visible;
		using (TimeWarning.New("Update Visibility", 0.1f))
		{
			UI.canvasGroup.alpha = ((!flag) ? 0f : 1f);
			UI.canvasGroup.interactable = flag;
			UI.canvasGroup.blocksRaycasts = flag;
		}
		if (GetCompanent.chatPanel && ConVar.Graphics.chat != UI.chatPanel.gameObject.activeSelf)
			UI.chatPanel.gameObject.SetActive(ConVar.Graphics.chat); 
		if (flag)
			using (TimeWarning.New("UpdateVitals", 0.1f))
				UI.UpdateVitals();
	}
}
