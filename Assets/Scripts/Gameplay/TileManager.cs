using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public List<Tile> tiles = new List<Tile>();
    Tile[] foundTiles;
    // Start is called before the first frame update
    void Start()
    {
        foundTiles = FindObjectsOfType<Tile>();

        foreach(Tile tile in foundTiles)
        {
            tiles.Add(tile);
        }
    }
}
