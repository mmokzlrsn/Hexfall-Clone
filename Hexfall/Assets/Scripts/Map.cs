using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static Map Instance;


    private float xOffSet = 0.56f;
    //private float yOffSetStart = -0.65f;
    private float yOffSet = 0.65f;

    public GameObject mapHolder; //starting point for map
    public GameObject cornerHolder;
    private Hex[,] hexArray; //2d hex array
    private Transform[,] cornerArray; //2d corner array


    [Header("Hex Sprite")]
    public GameObject hexPrefab;
    public Sprite[] hexSprite;
    public GameObject bombPrefab;
    public Sprite[] bombSprite;
    public GameObject cornerPrefab;
     
    [Header("Map Size")]
    public int width = 8;
    public int height = 9;
    public Vector3 hexScale = new Vector3(0.35f, 0.35f, 1); // Z is not that important bcs im working on 2D game

    [Header("Map Settings")]
    public int bombScore = 1000;

    [Header("Colors")] //must be editable on the editor
    public Color[] PieceColors = new Color[] 
    { Color.red, Color.blue, Color.green, Color.yellow, Color.cyan }; 

    public 

    void Start()
    {
        Instance = this;

        InitializeMap(); //starts function chain to create hexs
    }

    public void InitializeMap() //creates the visual hex map 
    {

        hexArray = new Hex[width, height];
        cornerArray = new Transform[width, height];

        HexPlacement();
        CreateMap(width, height, PieceColors.Length);

    }

    private void CreateMap(int width, int height, int length) //creates hex piece colors
    {
        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                CreateHex(new Vector2Int(x, y), UnityEngine.Random.Range(0, length)); //length is the count of colors
            }
        }
    }

    public void CreateHex(Vector2Int mapPosition, int colorIndex) //creates the hexs
    {
        var hex = Instantiate(hexPrefab);
        hex.GetComponent<Hex>().mapIndex = mapPosition;
        hex.GetComponent<Hex>().CalculateNeighbour();
        hex.GetComponent<Hex>().ChangeHexColor(hexSprite[colorIndex], colorIndex);
        hex.transform.position = new Vector3(mapPosition.x, mapPosition.y , 0); // convert to function 
        hex.transform.parent = mapHolder.transform;
        hex.name = "Hex" + mapPosition.x + "," + mapPosition.y;

        if (hexArray[mapPosition.x, mapPosition.y] != null)
            Destroy(hexArray[mapPosition.x, mapPosition.y].gameObject);

        hexArray[mapPosition.x, mapPosition.y] = hex.GetComponent<Hex>();
    }

    void HexPlacement() //TO DO write this statement better
    {
        xOffSet += xOffSet;

        yOffSet += yOffSet;
    }


    

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GenerateMap()
    {
        if (!Application.isPlaying)
        {
            Map.Instance = this;
        }

        //transform.position = new Vector3();
        //scale the hex according to the placement of hexs

        

    }
}
