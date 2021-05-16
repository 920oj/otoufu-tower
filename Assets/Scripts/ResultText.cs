using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    public Text ResultScore;
    // Start is called before the first frame update
    void Start()
    {
        ResultScore.text = string.Format("{0}", GameManager.score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
