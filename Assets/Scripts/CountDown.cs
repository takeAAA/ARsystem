using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	public float MAX_TIME = 5;
	float timeCount ;

	// Use this for initialization
	void Start () {
		timeCount = MAX_TIME;
		GetComponent<TextMesh>().text = ((int)timeCount).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("UserDefinedTarget-1") != null){
			timeCount -= Time.deltaTime;
			GetComponent<TextMesh>().text = ((int)timeCount).ToString();
			if (timeCount <= 1) {
				GetComponent<TextMesh>().text = "時間です";
			}
		}			
	}
}
