using UnityEngine;

public class Cell : MonoBehaviour
{
    public int x;
    public int z;
    public GameObject liveCell;
    private GameObject spawnedCube;

    void OnMouseDown()
    {
        if (spawnedCube == null)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            spawnedCube = Instantiate(liveCell, spawnPosition, Quaternion.identity);
            // spawnedCube.AddComponent<Cell>();
        }
    }
}