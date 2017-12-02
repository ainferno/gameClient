using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardEngine;

public class EndTurnButton : MonoBehaviour {
	public int curId;
	private GameScript Script;
	public GameObject map;
	// Use this for initialization
	void Start () {
		Script = map.GetComponent<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (!Script.MyTurn(curId))
			return;
		Script.EndTurn();
	}
}
