using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Tile : MonoBehaviour
{
    public List<Vector3> neighbourDirections = new List<Vector3>();
    public List<Transform> Neighbours = new List<Transform>();

    void Awake()
    {

    }

    private void GetNeighbours()
    {
        for (int i = 0; i < neighbourDirections.Count; i++)
        {
            var direction = neighbourDirections[i];
        }
    }
}
