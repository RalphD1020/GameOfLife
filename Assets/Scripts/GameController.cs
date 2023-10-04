using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameController : MonoBehaviour
{
    private int[,] _cells;
    private Vector3[,] _cellPositions;
    
    public int width = 36;          // Number of cubes in the X axis
    public int height = 24;         // Number of cubes in the Z axis
    public float spacing = 1.1f;    // Space between each cube
    public GameObject deadCell;

    public GameObject liveCell;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateBoard();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void InstantiateBoard()
    {
        _cells = new int[width, height];

        for (var x = 0; x < width; x++)
        {
            for (var z = 0; z < height; z++)
            {
                Vector3 position = new Vector3(x * spacing, 0, z * spacing);
                GameObject cubeInstance = Instantiate(deadCell, position, Quaternion.identity);
                cubeInstance.transform.parent = this.transform; // Set grid as parent
                cubeInstance.AddComponent<Cell>(); // Add click behavior
            }
        }
    }
}
