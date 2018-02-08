using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : PhaseManager {

    private ArrayList playerList = new ArrayList();


    private void Awake()
    {
        for (int i = 0; i <= 3; i++)
        {
            GameObject _player = GameObject.FindGameObjectWithTag("Player");
            playerList.Add(_player);
            Debug.LogFormat("Sono il Player numero (1)", i+1);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
