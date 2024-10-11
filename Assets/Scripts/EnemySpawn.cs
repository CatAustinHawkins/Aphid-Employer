using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawnPause());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemySpawnPause()
    {
        yield return new WaitForSecondsRealtime(Random.Range(12f,45f));
        Instantiate(Enemy, transform.position, transform.rotation);
        StartCoroutine(EnemySpawnPause());
    }
}
