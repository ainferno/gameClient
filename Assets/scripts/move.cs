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
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
		   this.transform.Translate(new Vector3(-1,0,0));
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)) {
            this.transform.Translate(new Vector3(1,0,0));
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
            this.transform.Translate(new Vector3(0,1,0));
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)) {
            this.transform.Translate(new Vector3(0,-1,0));
		}
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
