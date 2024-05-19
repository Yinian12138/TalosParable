using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleResultDebug : SimpleResult
{
    [HelpBox("Debug",HelpBoxType.Info)]
    [SerializeField]
    string debugInfo;
    protected override void FuncSimpleResult(bool satisfied = false, Action endCall = null)
    {
        if(!satisfied)
            return;
        Debug.Log(name + " "+ debugInfo + " (Triggered)");
        endCall?.Invoke();
    }
}
