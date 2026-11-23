using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] private Transform weapon;
    [SerializeField] private ParticleSystem projectileParticles;
    [SerializeField] private float range = 15f;
    private Transform target;
    private Enemy[] enemies;

    // Update is called once per frame
    void Update()
    {
        enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.InstanceID);
        projectileParticles.tag = gameObject.tag;

        if (enemies.Length > 0)
        {
            FindClosestTarget();
            AimWeapon();
        }
        else
        {
            var _projectileEmission = projectileParticles.emission;
            _projectileEmission.enabled = false;
        }
        
    }

    void FindClosestTarget()
    {
        
        Transform _closestTarget = null;
        float _maxDistance = Mathf.Infinity;

        foreach(Enemy _enemy in enemies)
        {
            float _targetDistance = Vector3.Distance(transform.position, _enemy.transform.position);

            if(_targetDistance < _maxDistance)
            {
                _closestTarget = _enemy.transform;
                _maxDistance = _targetDistance;
            }
        }

        target = _closestTarget;
    }

    void AimWeapon()
    {
        float _targetDistance = Vector3.Distance(transform.position, target.position);

        weapon.LookAt(target);

        if(_targetDistance < range)
        {
            Attack(true);
            
        }
        else
        {
            Attack(false);
        }
    }

    void Attack(bool isActive)
    {
        var _emissionModule = projectileParticles.emission;
        _emissionModule.enabled = isActive;
    }
}
