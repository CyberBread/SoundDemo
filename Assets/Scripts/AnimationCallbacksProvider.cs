using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimationCallbacksProvider 
{
    public event Action OnShootAnimationEnd;
    public event Action OnReloadAnimationStart;


    static private AnimationCallbacksProvider _instance;
    public static AnimationCallbacksProvider Instance => _instance;

    static AnimationCallbacksProvider()
    {
        _instance = new AnimationCallbacksProvider();
    }
}
