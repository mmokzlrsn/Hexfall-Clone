using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static Map Instance;

    [Header("Hex Sprite")]
    public Sprite hexPrefab;
    public Sprite bombSprite;


    [Header("Map Size")]
    public int width = 8;
    public int height = 9;
    public Vector3 hexScale = new Vector3(1, 1, 1);

    [Header("Map Settings")]
    public int bombScore = 1000;

    [Header("Colors")]
    public Color[] PieceColors = new Color[5] 
    { Color.red, Color.blue, Color.green, Color.yellow, Color.cyan };




    private float xOffSet = 0.56f;
    private float yOffSetStart = -0.65f;
    private float yOffSet = 0.65f;

    void Start()
    {
         

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GenerateGrid()
    {
        if (!Application.isPlaying)
        {
            Map.Instance = this;
        }

        transform.position = new Vector3((-((width - 1) * hexScale.x * 0.725f) / 2), (-((height) * hexScale.y) / 2));

        

    }
}
