using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine(FoodDespawn());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ladybug")
        {
            gameObject.SetActive(false);

        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ladybug")
        {
            gameObject.SetActive(false);

        }
    }

    IEnumerator FoodDespawn()
    {
        yield return new WaitForSecondsRealtime(5f);
        gameObject.SetActive(false);
    }
}
