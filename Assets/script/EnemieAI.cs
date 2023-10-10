using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class EnemieAI : MonoBehaviour
{
    public List<GameObject> Waypoints;
    public float moveSpeed;
    int Index = 0;
    public Transform player; 
    public float Range = 10.0f;
    public float stopDistance = 0.5f;
    [SerializeField] private GameObject AttackPrefab;
    public float rotationSpeed;
    public float attackTimer, setAttackTimer;
    
    void Update()
    {
        attackTimer -= Time.deltaTime;
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        
        if (distanceToPlayer <= Range)
        {
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            
            if (distanceToPlayer > stopDistance)
            {
                transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
            }
            else
            {
                if (attackTimer <= 0)
                {
                    attackTimer = setAttackTimer;
                    Instantiate(AttackPrefab, transform.position + (transform.forward * 1.5f), transform.rotation);
                }
                
            }
        }
        else
        {
            Vector3 Destination = Waypoints[Index].transform.position;
            Vector3 NewPos = Vector3.MoveTowards(transform.position, Destination, moveSpeed * Time.deltaTime);
            transform.position = NewPos;

            float distance = Vector3.Distance(transform.position, Destination);
            if(distance <= 0.5)
            {
                if(Index < Waypoints.Count-1) 
                {
                    Index++;
                }
                else
                {
                    Index = 0;
                }
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
