using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    
    [SerializeField] private GameObject AttackPrefab;
    [SerializeField] private Transform playerCharacter;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            if (playerCharacter != null)
            {
                Vector3 playerForward = playerCharacter.forward;
                
                Quaternion rotation = Quaternion.LookRotation(playerForward);
                
                Instantiate(AttackPrefab, playerCharacter.position + (playerForward * 1.5f), rotation);
            }
            else
            {
                Debug.LogError("Player character is not assigned in the inspector.");
            }
        }
    }
}
