using UnityEngine;
using System;
using System.Collections.Generic;

public class ConfiguratorSystem : MonoBehaviour {

    void OnEnable()
    {
       InitializerSystem.UiInitialization += ConfigureGraphics;
    }

    void ConfigureGraphics()
    {
        var cfg = Pool<GraphicsConfig>.First.data;

        cfg.TargetFramerate.OnChanged += x => Application.targetFrameRate = x; 
    }
}
