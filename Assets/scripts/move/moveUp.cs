using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour {
	public GameObject character;

	private move Move;
	// Use this for initialization
	void Start () {
		Move = character.GetComponent<move>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		if(Move.positionY <= 0)
			return;
		Move.positionY--;
		character.transform.Translate(new Vector3(0,1,0));
		Move.OnMouseDown();
	}
}
