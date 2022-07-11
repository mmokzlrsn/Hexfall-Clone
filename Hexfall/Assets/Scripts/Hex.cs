using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex : MonoBehaviour
{
    public int colorIndex;
    public Vector2Int mapIndex;
    public Vector2Int[] neighbourIndices;

    public void ChangeHexColor(Sprite sprite, int colorIndex)
    {
        transform.GetComponent<SpriteRenderer>().sprite = sprite;
        this.colorIndex = colorIndex;
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalculateNeighbour()
    {
        Vector2Int[] cornerNeighbourIndex = new Vector2Int[6];
        cornerNeighbourIndex[0] = new Vector2Int(mapIndex.x, mapIndex.y + 1);    // Top
        cornerNeighbourIndex[1] = new Vector2Int(mapIndex.x, mapIndex.y - 1);    // Bottom

        if (mapIndex.x % 2 == 0)
        {
            cornerNeighbourIndex[2] = new Vector2Int(mapIndex.x - 1, mapIndex.y);    // Top Left
            cornerNeighbourIndex[3] = new Vector2Int(mapIndex.x + 1, mapIndex.y);    // Top Right
            cornerNeighbourIndex[4] = new Vector2Int(mapIndex.x - 1, mapIndex.y - 1);    // Bottom Left
            cornerNeighbourIndex[5] = new Vector2Int(mapIndex.x + 1, mapIndex.y - 1);    // Bottom Right
        }
        else
        {
            cornerNeighbourIndex[2] = new Vector2Int(mapIndex.x - 1, mapIndex.y + 1);    // Top Left
            cornerNeighbourIndex[3] = new Vector2Int(mapIndex.x + 1, mapIndex.y + 1);    // Top Right
            cornerNeighbourIndex[4] = new Vector2Int(mapIndex.x - 1, mapIndex.y);    // Bottom Left
            cornerNeighbourIndex[5] = new Vector2Int(mapIndex.x + 1, mapIndex.y);    // Bottom Right
        }

        neighbourIndices = cornerNeighbourIndex;
    }

}
