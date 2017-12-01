using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardCreation;

public class GameScript : MonoBehaviour
{
	public GameObject[] tile;
	Board brd;
	// Use this for initialization
	void Start()
	{
		brd = new Board(tile);
	}

	// Update is called once per frame
	void Update()
	{

	}


//	void OnApplicationQuit()
//	{
//		brd.finish();
//	}
}
