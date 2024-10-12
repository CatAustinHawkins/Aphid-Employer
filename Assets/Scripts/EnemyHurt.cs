using UnityEngine;

public class EnemyHurt : MonoBehaviour
{
    public bool MushroomInRange;
    public bool LadybugInRange;

    public GameObject Mushroom;
    public GameObject Ladybug;

    public PointCount PointScript;

    private void Update()
    {
        if(MushroomInRange && Input.GetKey(KeyCode.E))
        {
            Destroy(Mushroom);
            PointScript.PointIncrease();
            MushroomInRange = false;
        }

        if (LadybugInRange && Input.GetKey(KeyCode.E))
        {
            Destroy(Ladybug);
            PointScript.PointIncrease();
            LadybugInRange = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ladybug")
        {
            LadybugInRange = true;
            Ladybug = other.gameObject;
        }

        if (other.tag == "Mushroom")
        {
            MushroomInRange = true;
            Mushroom = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ladybug")
        {
            LadybugInRange = false;
        }

        if (other.tag == "Mushroom")
        {
            MushroomInRange = false;
        }
    }
}
