using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class waypoints : MonoBehaviour
{
    private NavMeshAgent _navAgent;
    
    [SerializeField] private List<Transform> _waypoints;
    private int _target;
    void Start()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        if (_waypoints.Count > 1 && !(_waypoints[0])) { _navAgent.SetDestination(_waypoints[0].position); }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Waypoint"))
        {
            _target++;
            if(_target == _waypoints.Count)
            {
                _waypoints.Reverse();
                _target = 1;
            }

            if (!(_waypoints[_target]))
            {
                _navAgent.SetDestination(_waypoints[_target].position);
            }

        }
    }
}
