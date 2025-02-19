using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Way
{
    private Node _nodeDestiny;
    private float _cost;
    private float _aCUMulatedCost;
    private Node _nodeParent;
    public Node NodeDestiny { get => _nodeDestiny; set { _nodeDestiny = value;} }
    public float Cost { get => _cost; set { _cost = value; } }
    public float ACUMulatedCost { get => _aCUMulatedCost; set { _aCUMulatedCost = value; } }
    public Node NodeParent { get=>_nodeParent; set => _nodeParent = value; }
    public Way(Node node, float cost)
    {
        _nodeDestiny = node;
        _cost = cost;
    }

    public Way(Node node, float cost, float cumCost, Node parent)
    {
        _nodeDestiny = node;
        _cost = cost;
        _aCUMulatedCost= cumCost;
        _nodeParent = parent;
    }
}
