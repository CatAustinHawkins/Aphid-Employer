using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float barvalue = 1;
    public Slider healthslider;

    public PointCount PointScript;

    public GameObject[] AphidCheck;

    public AudioSource Eat;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HealthGoDown());
    }

    // Update is called once per frame
    void Update()
    {
        AphidCheck = GameObject.FindGameObjectsWithTag("Aphid");


        if (barvalue > 1 )
        {
            barvalue = 1;
            healthslider.value = barvalue;
        }

        if (barvalue <= 0)
        {
            SceneManager.LoadScene("GameFinish");
        }
    }

    IEnumerator HealthGoDown()
    {
        barvalue = barvalue - 0.025f;
        healthslider.value = barvalue;
        yield return new WaitForSecondsRealtime(0.5f);
        StartCoroutine(HealthGoDown());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Eat.Play();
            PointScript.PointIncrease();
            barvalue = barvalue + 0.25f;
            healthslider.value = barvalue;
            other.gameObject.SetActive(false);
        }
    }
}