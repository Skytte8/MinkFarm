using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBuilder : MonoBehaviour
{
    public GameObject tilePrefab;
    public int xSize = 32;
    public int ySize = 32;

    private void Start()
    {
        for (int i = 1; i < xSize; i++)
        {
            for (int j = 1; j < ySize; j++)
            {
                GameObject go = Instantiate(tilePrefab, new Vector3(i * 0.5f, j * 0.5f, 1), Quaternion.identity);
                go.transform.parent = transform;
            }
        }
    }
}