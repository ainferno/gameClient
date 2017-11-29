using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour {
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
		if(Move.positionX >= 7)
			return;
		Move.positionX++;
		character.transform.Translate(new Vector3(1, 0, 0));
		Move.OnMouseDown();
	}
}
