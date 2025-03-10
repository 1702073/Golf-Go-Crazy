using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node cameFrom;
    public List<Node> Connections;

    public float gScore;
    public float hScore;

    public float FScore()
    {
        return gScore + hScore;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        if (Connections.Count > 0)
        {
            for (int i = 0; i < Connections.Count;)
            {
                Gizmos.DrawLine(transform.position, Connections[i].transform.position);
            }
        }
    }

}
