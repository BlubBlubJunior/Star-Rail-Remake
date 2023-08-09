using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;
using UnityEngine.iOS;

public class EnemySpawn : MonoBehaviour
{
    public List<GameObject> SpawnPointEnemies = new List<GameObject>();
    public List<GameObject> Enemy = new List<GameObject>();
    public List<GameObject> SpawnPointAlly = new List<GameObject>();
    public List<GameObject> Ally = new List<GameObject>();
    public GameObject Game_Object;
    [SerializeField] private GameObject attackprefab;
    [SerializeField] private GameObject spawnpoint;

    public void Start()
    {
        for(int i = 0; i < Enemy.Count; i++)
        {
            Game_Object = Instantiate(Enemy[i]);
            Game_Object.transform.position = SpawnPointEnemies[i].transform.position; 
        }
        for(int i = 0; i < Ally.Count; i++)
        {
            Game_Object = Instantiate(Ally[i]);
            Game_Object.transform.position = SpawnPointAlly[i].transform.position; 
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            GameObject someobject = Enemy[0 - 1];
            Instantiate(attackprefab);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject someobject = Enemy[0 - 1];
            Instantiate(attackprefab);
        }

        if (Input.touchCount > 4)
        {
            //Enemy = Input.GetTouch(0);
        }
    }
}
