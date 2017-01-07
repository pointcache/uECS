﻿using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

public class SystemsExecutor : MonoBehaviour
{
    void OnEnable()
    {
        sendMessageRecursive("orderedOnEnable", transform);
    }
    void FixedUpdate()
    {
        if(Pool<InternalConfig>.First.data.UpdateAllowed)
            sendMessageRecursive("orderedFixedUpdate", transform);
    }

    void Update()
    {
        if(Pool<InternalConfig>.First.data.UpdateAllowed)
            sendMessageRecursive("orderedUpdate", transform);
    }

    void sendMessageRecursive(string message, Transform tr)
    {
        int count = tr.childCount;
        for (int i = 0; i < count; i++)
        {
            tr.GetChild(i).SendMessage(message, SendMessageOptions.DontRequireReceiver);
            if (count > 0)
                sendMessageRecursive(message, tr.GetChild(i));
        }
    }
}


