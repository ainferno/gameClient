using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour 
{
	public int positionX = 0, positionY = 0;
	bool moveStance = false;
	public GameObject moveShow;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	public void OnMouseDown()
	{
		if (!moveStance)
		{
			moveStance = true;
			moveShow.SetActive(true);
		}
		else
		{
			moveStance = false;
			moveShow.SetActive(false);
		}
	}
}
