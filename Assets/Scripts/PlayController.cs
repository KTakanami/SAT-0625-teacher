using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    // ボール
    [SerializeField]
    private Rigidbody ball;

    // バー
    [SerializeField]
    private Rigidbody bar;

    // ボールの移動量
    [SerializeField]
    private float ballShotValue;

    // バーの移動量
    [SerializeField]
    private float barMoveValue;

    // 発射フラグ
    private bool isShot;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーを押した時にボール発射
        if (Input.GetKeyDown(KeyCode.Space) && isShot == false)
        {
            isShot = true;
            ball.velocity = Vector3.up * ballShotValue;
        }

        // バーを移動する
        var dir = Input.GetAxis("Horizontal");
        bar.velocity = dir * Vector3.right * barMoveValue;
    }
}
