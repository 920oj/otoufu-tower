using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBoxes : MonoBehaviour
{
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(myTransform.position.y < -6) {
            GameManager.game_flg = false;
        }   
    }
}
