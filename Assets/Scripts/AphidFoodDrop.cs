using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AphidFoodDrop : MonoBehaviour
{

    public bool FoodReady;

    public Animator AphidAnims;

    public GameObject Food;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FoodDropDelay());
        AphidAnims = gameObject.GetComponent<Animator>();
    }


    IEnumerator FoodDropDelay()
    {
        yield return new WaitForSecondsRealtime(Random.Range(3f,12f));
        FoodReady = true;
        AphidAnims.Play("aphidfull");
        StartCoroutine(FoodDrop());

    }

    IEnumerator FoodDrop()
    {
        yield return new WaitForSecondsRealtime(Random.Range(2f,5f));
        Food.SetActive(true);
        AphidAnims.Play("aphid");
        StartCoroutine(FoodDropDelay());
    }
}
