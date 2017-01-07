using UnityEngine;
using System;
using System.Collections.Generic;

[ECSConfig]
public class InternalConfig : ComponentBase
{

    public Data data;
    [Serializable]
    public class Data : ComponentData
    {
        public bool UpdateAllowed;
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