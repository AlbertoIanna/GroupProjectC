using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GridController gridController;
    public int XPos;
    public int YPos;
    public int XPos_old;
    public int YPos_old;
	// Use this for initialization
	void Start () {
        transform.position = gridController.GetWorldPosition(XPos, YPos); 
	}
	
	// Update is called once per frame
	void Update () {
        XPos_old = XPos;
        YPos_old = YPos;

		if(Input.GetKeyDown(KeyCode.A))
        {
            XPos--;
            move();
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            XPos++;
            move();

        }else if(Input.GetKeyDown(KeyCode.W))
        {
            YPos++;
            move();
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            YPos--;
            move();
        }
	}

    void move()
    {
        if (gridController.IsValidPosition(XPos, YPos))
        transform.position = gridController.GetWorldPosition(XPos, YPos);
        else
        {
            XPos = XPos_old;
            YPos = YPos_old;
        }
    }
}
