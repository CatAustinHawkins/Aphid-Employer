using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        StartCoroutine(EnemySpawnPause());
    }

    IEnumerator EnemySpawnPause()
    {
        yield return new WaitForSecondsRealtime(Random.Range(12f,45f));
        Instantiate(Enemy, transform.position, transform.rotation);
        StartCoroutine(EnemySpawnPause());
    }
}
