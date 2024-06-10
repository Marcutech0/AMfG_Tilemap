using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int width, height;
    public GameObject tilePrefab;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void AssignMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("Tile");
        foreach (var t in tiles) 
        {
            t.GetComponent<Renderer>().material = material; 
        }
    }

    public void ClearGrid()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in tiles) 
        {
            DestroyImmediate(tile);
        }
    }
    public void GenerateGrid()
    {
        if(tilePrefab == null)
        {
            Debug.LogError("No tilePrefab Assigned");
            return;
        }
        //Loop through grid pos
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++) 
            {
                //calculate pos for each cube
                Vector3 position = new Vector3(x, 0, y);
                //Instantiate the cube at the calculated pos
                GameObject newTile = Instantiate(tilePrefab, position,Quaternion.identity);
                newTile.transform.parent = transform;
                newTile.tag = "Tile";
            }
        }
    }
}
