using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;

public class GroundSpwaner : MonoBehaviour
{
    public Transform tile;
    public Transform Player;
    public float InnerRadius = 30;
    public float OuterRadius = 40;

    private float step;
    private List<Transform> tileOutline;
    private List<Transform> tiles;
    private Renderer TileRenderer;
    private Transform closestTile;

    private float tileExtend;
    
    // Start is called before the first frame update
    void Start()
    {
        TileRenderer = tile.GetComponent<Renderer>();
        step = TileRenderer.bounds.extents.z * 2;
        for (int z = 0; z < InnerRadius; z++)
        {
            for (int x = 0; x < OuterRadius; x++)
            {
                Transform temp = Instantiate(tile, Player.position + new Vector3(x, 0, z), Quaternion.identity, transform);
                tiles.Add(temp);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetClosestTile();
    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(Player.position, new Vector3(InnerRadius, InnerRadius,InnerRadius));
        Gizmos.DrawWireCube(Player.position,  new Vector3(OuterRadius, OuterRadius, OuterRadius));
    }

    void GetClosestTile()
    {
        closestTile = tiles.OrderBy(h => Math.Abs((h.transform.position - Player.transform.position).magnitude)).First();
    }
}
