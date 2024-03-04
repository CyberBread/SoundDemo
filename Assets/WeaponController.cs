using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Animator _weaponAnimator;
    [SerializeField] private AnimationEventsHandler _animationEventsHandler;


    private bool _isShootAnimationEnd;

    private void OnEnable()
    {
        _weaponAnimator.Play("Armature|Take");
        _isShootAnimationEnd = true;
        _animationEventsHandler.OnShootAnimationEnd += OnShootAnimationEnd;
    }


    private void OnDisable()
    {
        _animationEventsHandler.OnShootAnimationEnd -= OnShootAnimationEnd;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && _isShootAnimationEnd)
        {
            Debug.Log("Shoot");
            _weaponAnimator.Play("Armature|Shoot");
        }
    }

    private void OnShootAnimationEnd()
    {
        _isShootAnimationEnd = true;
    }
}
