using UnityEngine;
using TMPro;
public class endscreen : MonoBehaviour
{

    public GameObject DistanceTrackerGO;
    public PointCount DistanceScript;

    public TextMeshProUGUI Distancetext;

    void Start()
    {
        DistanceTrackerGO = GameObject.FindGameObjectWithTag("Points");
        DistanceScript = DistanceTrackerGO.GetComponent<PointCount>();
        Distancetext.text = "Score: " + DistanceScript.Point.ToString() + "!";
    }

}
