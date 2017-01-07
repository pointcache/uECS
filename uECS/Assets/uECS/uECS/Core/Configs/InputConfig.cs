using UnityEngine;
using System;
using System.Collections.Generic;

public class InputConfig : ComponentBase {

    public Data data;
    [Serializable]
    public class Data : ComponentData
    {
        public r_KeyCode debugMode = new r_KeyCode(KeyCode.F1);
    }

    public override void OnEnable()
    {
        base.OnEnable();
    }

    public override void OnDisable()
    {
        base.OnDisable();
    }
}
