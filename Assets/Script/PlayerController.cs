using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour {

    public GridController gridController;
    public bool isPlaying;
    public string name;
    public int XPos;
    public int YPos;
    public int moves;
    private bool IsMoving;
    int XPos_old;
    int YPos_old;

    // Use this for initialization
    void Start () {
        transform.position = gridController.GetWorldPosition(XPos, YPos);
        moves = 0;
        IsMoving = true;
    }
	
	// Update is called once per frame
	void Update () {
        XPos_old = XPos;
        YPos_old = YPos;
        EndMovement();

        if (IsMoving == true && name.Equals("P1"))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                // sx
                XPos--;
                move();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                XPos++;
                move();
                // dx
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                // up
                YPos++;
                move();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                // down
                YPos--;
                move();
            }
        }
    }

    void move() {
        if (name.Equals("P1"))
        {
            if (gridController.IsValidPosition(XPos, YPos))
            {
                transform.DOMove(gridController.GetWorldPosition(XPos, YPos), 0.6f).SetEase(Ease.Linear);
                moves = moves + 1;
                CustomLogger.Log("Mi muovo in (0):(1)", XPos, YPos);
            }
            else
            {
                XPos = XPos_old;
                YPos = YPos_old;
            }
        }
            
    }

    void EndMovement()
    {
        if(moves >= 4)
        {
            IsMoving = false;
        }
    }
}
