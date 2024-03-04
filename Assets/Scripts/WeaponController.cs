using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Animator _weaponAnimator;
    [SerializeField] private AnimationEventsHandler _animationEventsHandler;
    [SerializeField] private ParticleSystem _shootVFX;


    private bool _isCanShoot;

    private void OnEnable()
    {
        _weaponAnimator.Play("Armature|Take");
        _isCanShoot = true;
        _animationEventsHandler.OnShootAnimationEnd += SetShootAvailavleState;
        _animationEventsHandler.OnReloadAnimationEnd += SetShootAvailavleState;
    }


    private void OnDisable()
    {
        _animationEventsHandler.OnShootAnimationEnd -= SetShootAvailavleState;
        _animationEventsHandler.OnReloadAnimationEnd -= SetShootAvailavleState;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _isCanShoot)
        {
            Debug.Log("Shoot");
            _shootVFX.Play();
            _weaponAnimator.Play("Armature|Shoot");
        }
        else if(Input.GetKeyDown(KeyCode.R) && _isCanShoot)
        {
            _weaponAnimator.Play("Armature|Reload");
        }
    }

    private void SetShootAvailavleState()
    {
        _isCanShoot = true;
    }
}
