using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateBoxes : MonoBehaviour
{

    public GameObject target;
    public double x;
    public double speed;

    // Start is called before the first frame update
    void Start()
    {
        x = 0.0;
        speed = 0.1;
        GameManager.time = 30;
        GameManager.score = 0;
        GameManager.game_flg = true;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.game_flg)
        {
            SceneManager.LoadScene("Result");
        }
        // Debug.Log("x: " + x + "speed: " + speed);
        // x方向が5以上になったらspeedをマイナスに、5以下になったらプラスにする
        if (x >= 5)
        {
            speed = -0.1;
        }
        else if (x <= -5)
        {
            speed = 0.1;
        }
        // speedをxの位置に反映させる
        x = x + speed;

        // MoveCube(表示用Cubeの位置を変更する)
        GameObject.Find("MoveCube").transform.position = new Vector3((float)x, 3.0f, 0.0f);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(target, new Vector3((float)x, 3.0f, 0.0f), Quaternion.identity);
            GameManager.score += 1;
            Debug.Log(GameManager.score);
        }
    }
}
