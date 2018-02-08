using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenLoggerVisuaizer : MonoBehaviour {
    public TextMeshProUGUI TextArea; 
    private void Update()
    {
        TextArea.text = CustomLogger.currentLogString;
    }
}
