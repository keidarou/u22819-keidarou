using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStages : MonoBehaviour {

	public GameObject CodeVs;
	int stgNum=CreateButton.sendStageNum;

	string[] mapCode={
		"None",//stage0<-これはない
		"1dayo",//stage1
		"",
		"",
		"",
		"",//stage5
		"",
		"",
		"",
		"",
		"",//stage10
		"",
		"",
		"",
		"",
		"15dayo",//stage15
	};

	// Start前フレームに実行
	void Awake () {
		Debug.Log (stgNum);
		CodeVs.GetComponent<codevisualizer>().strcode = mapCode [stgNum];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
