using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState { PLAY, WAIT} //initialized 2 game state to control player inputs

public enum HexRotation { CLOCKWISE, COUNTERCLOCKWISE } //there will be 2 type of rotation

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    
    public GameState state;
    public GameObject hexSelector;
    public Vector2Int selectedCornerIndex;
    public Canvas canvas;

    public int score;
    public int matchHexCount;

    private Vector2 previousInputPosition;
    private Vector2 currentInputPosition;

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.PLAY;

    }
    private void Awake()
    {
        Instance = this;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.WAIT) //player waits here to other task execute EX: rotation
            return;
    }
}
