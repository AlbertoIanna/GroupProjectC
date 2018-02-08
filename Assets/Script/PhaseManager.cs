using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseManager : MonoBehaviour {

    public PlayerController playerController;

    public enum State
    {
        Setup,
        TilePlacing,
        Movement,
        Spell,
        End,
    }

    public State CurrentState
    {
        get{
            return _currentState;
        }
        set
        { if (CeckStateChange(value) == true) {
                OnStateEnd(_currentState);
                _currentState = value;
                OnStateStart(_currentState);
            }
            else{
                Debug.Log("Non è possibile passare da" + _currentState + "a" + value);
            }
        }
    }

     bool CeckStateChange(State NewState)
    {
        switch (NewState)
        {
            case State.Setup:
            case State.TilePlacing:
                if (CurrentState != State.Setup)
                    return false;
                return true;
                break;
            case State.Movement:
                if (CurrentState != State.TilePlacing)
                    return false;
                return true;
                break;
            case State.Spell:
                if (CurrentState != State.Movement)
                    return false;
                return true;
                break;
            case State.End:
                if (CurrentState != State.Spell)
                    return false;
                return true;
                break;
            default:
                return false;
                break;
        }
    }

    private State _currentState;
	// Use this for initialization
	void Start () {
        CurrentState = State.Setup;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentState = State.Setup;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentState = State.TilePlacing;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentState = State.Movement;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CurrentState = State.Spell;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
            CurrentState = State.End;
        OnStateUpdate();
    }

    void OnStateStart(State newState)
    {
        switch (newState)
        {
            case State.Setup:
                Debug.Log("Sono entrato nello stato di " + newState);
                break;
            case State.TilePlacing:
                Debug.Log("Sono entrato nello stato di " + newState);
                break;
            case State.Movement:
                Debug.Log("Sono entrato nello stato di " + newState);
                break;
            case State.Spell:
                Debug.Log("Sono entrato nello stato di " + newState);
                break;
            case State.End:
                Debug.Log("Sono entrato nello stato di " + newState);
                break;
            default:
                break;
        }

    }

    void OnStateUpdate()
    {
        switch (CurrentState)
        {
            case State.Setup:
                Debug.Log("Sono nello stato di " + CurrentState);
                break;
            case State.TilePlacing:
                Debug.Log("Sono nello stato di " + CurrentState);
                break;
            case State.Movement:
                Debug.Log("Sono nello stato di " + CurrentState);
                break;
            case State.Spell:
                Debug.Log("Sono nello stato di " + CurrentState);
                break;
            case State.End:
                Debug.Log("Sono nello stato di " + CurrentState);
                break;
            default:
                Debug.Log("Sono nello stato di " + CurrentState);
                break;
        }
    }

    void OnStateEnd(State OldState)
    {
        switch (OldState)
        {
            case State.Setup:
                Debug.Log("Sto uscendo dallo stato di " + OldState);
                break;
            case State.TilePlacing:
                Debug.Log("Sto uscendo dallo stato di " + OldState);
                break;
            case State.Movement:
                Debug.Log("Sto uscendo dallo stato di " + OldState);
                break;
            case State.Spell:
                Debug.Log("Sto uscendo dallo stato di " + OldState);
                break;
            case State.End:
                Debug.Log("Sto uscendo dallo stato di " + OldState);
                break;
            default:
                break;
        }

    }
}
