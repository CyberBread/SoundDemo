using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventsHandler : MonoBehaviour
{
    public event Action OnShootAnimationEnd;

    public void ShootAnimationEndCallback(int _)
    {
        Debug.Log("End");
        OnShootAnimationEnd?.Invoke();
    }
}
