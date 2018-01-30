using System;
using UnityEngine;

[Serializable]
public class CellData {

    public int X;
    public int Y;
    public Vector3 WorldPosition;

    public bool IsValid = true;

    public CellData() {

    }

    public CellData(int _xPos, int _yPos, Vector3 _worldPosition) {
        X = _xPos;
        Y = _yPos;
        WorldPosition = _worldPosition;
    }

    public void SetValidity(bool _isValid) {
        IsValid = _isValid;
    }

}

