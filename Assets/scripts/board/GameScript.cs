using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardEngine;

public class GameScript : MonoBehaviour
{
	public GameObject[] tile;
	Board brd;
	int[] PlayerIds = new int[2];
	private double timeForTurn = 150;
	private double timeLeft;

	// Use this for initialization
	void Start()
	{
		PlayerIds[0] = 0;
		PlayerIds[1] = 1;
		timeLeft = timeForTurn;
		brd = new Board(tile,PlayerIds);
	}

	// Update is called once per frame
	void Update()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0)
			EndTurn();
		Debug.Log(brd.getCurPlayerId());
		//Debug.Log(timeLeft);
	}
	public bool MyTurn(int id)
	{
		return brd.getCurPlayerId() == id;
	}
	public void EndTurn()
	{
		timeLeft = timeForTurn;
		brd.changeTurn();
	}


//	void OnApplicationQuit()
//	{
//		brd.finish();
//	}
}
