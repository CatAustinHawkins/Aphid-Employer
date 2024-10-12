using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject[] Aphids;
    public float step;


    // Start is called before the first frame update
    void Start()
    {
        Aphids = GameObject.FindGameObjectsWithTag("Aphid");
        StartCoroutine(MoveDelay());
        StartCoroutine(ChangeTarget());
    }


    IEnumerator ChangeTarget()
    {
        yield return new WaitForSecondsRealtime(10f);
        Aphids = GameObject.FindGameObjectsWithTag("Aphid");
        StartCoroutine(MoveDelay());
        StartCoroutine(ChangeTarget());
    }


    IEnumerator MoveDelay()
    {
        yield return new WaitForSecondsRealtime(1f);
        transform.position = Vector2.MoveTowards(transform.position, Aphids[0].transform.position, step);
        StartCoroutine(MoveDelay());
    }
}