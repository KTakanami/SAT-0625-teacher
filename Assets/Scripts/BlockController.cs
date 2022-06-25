using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    // ブロックのプレハブ格納先
    [SerializeField]
    private GameObject blockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // 複数個ブロック作成
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                // グリッド上にプレハブ生成(BlockParentが親)
                // transform：このスクリプトがアタッチされているオブジェクトのTransform
                var block = Instantiate(blockPrefab, transform).transform;

                // 座標を合わせる
                block.localPosition = new Vector3(-5f + 5f * j, -2f + 2f * i, 0f);
            }
        }
    }
}
