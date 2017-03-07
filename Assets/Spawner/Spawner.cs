using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject zombie;
    private Vector3 spawnPoint;
    private int zCord;
    private int xCord;
    public int step;
    public int gridSize;
    private int probability;
    public int probabilityRangeVal;
    // Use this for initialization
    void Start()
    {
        zCord = 0;
        xCord = 0;
        spawnPoint = new Vector3(xCord, 0, zCord);
        
        for (int x = 0; x < gridSize; x++)
        {
            for (int z = 0; z < gridSize; z++)
            {
                //Debug.Log("(" + xCord + "," + zCord + ")");
                xCord = step * x;
                zCord = step * z;
                spawnPoint = new Vector3(xCord, 0, zCord);
                probability = Random.Range(0, probabilityRangeVal);
                //Debug.Log(probability);
                if(probability == 0)
                {
                    Instantiate(zombie, spawnPoint, Quaternion.identity);
                }
            }
            xCord = 0;
        }
    }
}