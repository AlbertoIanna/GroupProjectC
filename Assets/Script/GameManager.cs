using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerController playerController;
    private ArrayList playerList = new ArrayList();


    private void Awake()
    {
        for (int i = 0; i <= 3; i++)
        {
            GameObject _player = GameObject.FindGameObjectWithTag("Player");
            playerList.Add(_player);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
