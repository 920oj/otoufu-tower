using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainText : MonoBehaviour
{
    public Text MainScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MainScore.text = string.Format("Score: {0}個", GameManager.score);
    }
}
