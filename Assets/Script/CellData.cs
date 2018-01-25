using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CellData  {

    public int X;
    public int Y;
    public Vector3 WorldPosition;

    public bool IsValid = true;

    public CellData() { }

    public CellData(int _xPos, int _yPos, Vector3 _worldPos){
        X = _xPos;
        Y = _yPos;
        WorldPosition = _worldPos;
    }

    public void SetValidity(bool _isValid)
    {
        IsValid = _isValid;
    }
}
