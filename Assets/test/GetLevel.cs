using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GetLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("获取信息")]
    public void OnClick()
    {
        var clider = gameObject.GetComponent<TilemapCollider2D>();
        var tileMap = gameObject.GetComponent<Tilemap>();
        tileMap.CompressBounds();
        Debug.LogError(tileMap.size);
        var size = tileMap.cellBounds;
        var max = size.max;
        max.z = 0;
        max.x -= 1;
        max.y -= 1;
        var tileMin = tileMap.GetTile(size.min);
        var tileMax = tileMap.GetTile(max);
    }

}
