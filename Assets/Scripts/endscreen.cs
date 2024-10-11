using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class endscreen : MonoBehaviour
{

    public GameObject DistanceTrackerGO;
    public PointCount DistanceScript;

    public TextMeshProUGUI Distancetext;
    // Start is called before the first frame update
    void Start()
    {
        DistanceTrackerGO = GameObject.FindGameObjectWithTag("Points");
        DistanceScript = DistanceTrackerGO.GetComponent<PointCount>();
        Distancetext.text = "Score: " + DistanceScript.Point.ToString() + "!";
    }

}
