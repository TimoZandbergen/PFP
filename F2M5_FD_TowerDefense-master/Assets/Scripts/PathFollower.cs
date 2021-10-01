using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Beweegt langs een Path
public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThreshold;

    private Path _path;
    private Waypoint _currentWaypoint;

    private void Start()
    {
        SetupPath();
    }

    private void Update()
    {
        float distanceToWaypoint = Vector3.Distance(transform.position, _currentWaypoint.GetPosition());

        if (distanceToWaypoint <= _arrivalThreshold)
        {
            if (_currentWaypoint == _path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.GetPosition());
            }
        }
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
        transform.LookAt(_currentWaypoint.GetPosition());
    }
    
    private void PathComplete()
    {
        print("Ik ben bij het eindpunt");
        _speed = 0;
    }
}
