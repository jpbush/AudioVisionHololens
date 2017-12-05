using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridManager : MonoBehaviour
{
    // cursor prefab
    public GameObject cursor;
    // fov
    public float angularWidth;
    public float angularHeight;
    // angular division between grid points
    public float angularStep;

    // fov bounds
    private float leftAngle;
    private float rightAngle;
    private float topAngle;
    private float bottomAngle;
    // cursors
    private int gridWidth;
    private int gridHeight;
    private int gridSize;

    // Use this for initialization
    void Start ()
    {
        // calculate bounds
        rightAngle = (angularWidth / 2);
        leftAngle = -rightAngle;
        topAngle = (angularHeight / 2);
        bottomAngle = -topAngle;

        gridWidth = Convert.ToInt32(Math.Round(angularWidth / angularStep));
        gridHeight = Convert.ToInt32(Math.Round(angularHeight / angularStep));
        gridSize = gridHeight * gridWidth;

        for (int v = 0; v < gridHeight; v++)
        {
            float vA = leftAngle + (v * angularStep);
            for (int h = 0; h < gridWidth; h++)
            {
                float hA = bottomAngle + (h * angularStep);
                GameObject c = Instantiate(cursor, new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);
                GridCursor cursorScript = c.GetComponent<GridCursor>();
                cursorScript.direction = new Vector3((0.1f * hA), (0.1f * vA), 1.0f);
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
    }
}
