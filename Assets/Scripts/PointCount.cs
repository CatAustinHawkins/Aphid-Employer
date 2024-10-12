using UnityEngine;
using TMPro;

public class PointCount : MonoBehaviour
{
    public int Point;
    public TextMeshProUGUI PointText;

    public void PointIncrease()
    {
        Point = Point + 10;
        PointText.text = Point.ToString();
    }

   public void PointDecrease()
    {
        Point = Point - 10;
        PointText.text = Point.ToString();

   }

    private void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Points");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
