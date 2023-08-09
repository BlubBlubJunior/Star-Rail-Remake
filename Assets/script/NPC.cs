using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
    public List<GameObject> thomie = new List<GameObject>();
    public EnemySpawn thomas;
    void Start()
    {
        thomas.Enemy.Add(thomie[0]);
        DontDestroyOnLoad(this.gameObject); 
    }

    // Update is called once per frame
    public void Update()
    {
        
        
        
    }
}
