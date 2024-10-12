using System.Collections;
using UnityEngine;

public class AphidHealth : MonoBehaviour
{
    public float Health;

    public bool LadybugInRange;
    public bool MushroomInRange;

    public SpriteRenderer AphidSprite;

    public bool DamageDone;
    public bool DamageDone2;
    public PointCount PointScript;

    public AudioSource Hurt;

    public void Start()
    {
        AphidSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Health <= 0 )
        {
            Destroy(gameObject);
            PointScript.PointDecrease();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ladybug" && !DamageDone)
        {
            StartCoroutine(DamageDelay());
            DamageDone = true;
            LadybugInRange = true;

        }

        if (other.tag == "DamageAura" && !DamageDone2)
        {
            StartCoroutine(DamageDelay());
            DamageDone2 = true;
            MushroomInRange = true;
        }
    }



    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ladybug")
        {
            LadybugInRange = false;
        }

        if (other.tag == "DamageAura")
        {
            MushroomInRange = false;
        }
    }


    IEnumerator DamageDelay()
    {
        Hurt.Play();
        Health = Health - 0.25f;
        AphidSprite.color = Color.red;
        StartCoroutine(ColourDelay());
        yield return new WaitForSecondsRealtime(2f);
        DamageDone = false;
        DamageDone2 = false;
        if(LadybugInRange || MushroomInRange)
        {
            StartCoroutine(DamageDelay());
        }

    }

    IEnumerator ColourDelay()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        AphidSprite.color = Color.white;
    }
}
