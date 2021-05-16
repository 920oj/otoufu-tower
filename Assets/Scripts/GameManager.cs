using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    // score スコアを記憶するグローバルな変数
    public static int score;
    // time 残り時間を記憶するグローバルな変数
    public static int time;
    // game_flg ゲーム中かどうかを判定するフラグ変数
    public static bool game_flg;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
