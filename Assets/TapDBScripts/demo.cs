using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class demo : MonoBehaviour {

	string gameserver = "";

	const int left = 90;
	const int height = 60;
	const int top = 60;
	int width = Screen.width - left * 2;
	const int step = 60;
	bool isPaused = false;

	void OnGUI() {
		
		int i = 0;
		GUI.Box(new Rect(10, 10, Screen.width - 20, Screen.height - 20), "Demo Menu");

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "On Start")) {
			TapDB.enableLog(true);
			TapDB.onStart("jnc4p3pekjcrhg22", "abc", "v1.0");
		}
		
		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Set User")) {
			var abc = Application.internetReachability;
			TapDB.setUser("uid123456");
		}
		
		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Set Level")) {
			TapDB.setLevel(100);
		}
		
		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Set Server")) {
			TapDB.setServer("S100");
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Set Name")) {
			TapDB.setName("testName");
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Charge Success")) {
			TapDB.onChargeSuccess("order03", "iap", 100, "CH", "Apple Pay");
		}
		
		if (GUI.Button(new Rect(left, top + step * i++, width, height), "On Event")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("abc", 123);
			properties.Add("def", "xyz");
			properties.Add("xyz", "中文");
			TapDB.onEvent("eventCode", properties);
		}
		
		if (GUI.Button(new Rect(left, top + step * i++, width, height), "Set Host")) {
			TapDB.setHost("https://e.tapdb.net/");
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "user initialize")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("abc", 123);
			TapDB.userInitialize(properties);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "user update")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("abc", 234);
			TapDB.userUpdate(properties);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "user add")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("abc", 2);
			TapDB.userAdd(properties);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "device initailize")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("xyz", 123);
			TapDB.deviceInitialize(properties);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "device update")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("xyz", 234);
			TapDB.deviceUpdate(properties);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "device add")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("xyz", 3);
			TapDB.deviceAdd(properties);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "注册静态属性")) {
			Dictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("static", "static");
			TapDB.registerStaticProperties(properties);
		}

		if (GUI.Button(new Rect(left, top + step * i++, width, height), "清除静态属性")) {
			TapDB.clearStaticProperties();
		}

	}
	
	void Start () {
		Debug.Log("start...!!!!!!!!!!");
		// TapDB.onStart("jnc4p3pekjcrhg22", "11111111111111", "v1.0");
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Escape)) {
			Application.Quit();
		}
	}

	void OnApplicationQuit() {
		Debug.Log("OnApplicationQuit");
	}

	void OnDestroy (){
		Debug.Log("onDestroy");
	}
	
	void Awake () {
		Debug.Log("Awake");
	}
	
	void OnEnable () {
		Debug.Log("OnEnable");
	}
	
	void OnDisable () {
		Debug.Log("OnDisable");
	}
}
