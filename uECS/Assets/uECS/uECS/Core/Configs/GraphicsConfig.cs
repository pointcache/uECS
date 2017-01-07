using UnityEngine;
using System;
using System.Collections.Generic;
using FullSerializer;

[ECSConfig]
public class GraphicsConfig : ComponentBase
{

    public Data data;
    [Serializable]
    public class Data : ComponentData
    {
        public r_int TargetFramerate = new r_int(300);
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