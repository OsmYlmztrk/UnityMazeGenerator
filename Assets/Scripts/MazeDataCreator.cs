using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeDataCreator : MonoBehaviour
{

}

public class Cell
{
    public Vector2 position;
    public bool isVisited;

    private Cell _rightCell;
    private Cell _leftCell;
    private Cell _downCell;
    private Cell _upCell;

    public void SetNeighbours(Grid grid)
    {

    }
}

public class Grid
{
    public Vector2 maxGridSize = new Vector2(5, 5);

}


