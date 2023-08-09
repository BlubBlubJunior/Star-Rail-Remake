using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    Rigidbody Move_Rigidbody;

    [SerializeField] private float moveSpeed = 2f;
    
    void Start()
    {
        Move_Rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 Move_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Move_Rigidbody.MovePosition(transform.position + Move_Input * Time.deltaTime * moveSpeed);
        
    }
}
