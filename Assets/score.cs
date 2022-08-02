using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int theScore = 0;

    void Start()
    {
        theScore = 0;
    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = theScore.ToString();
    }
}
