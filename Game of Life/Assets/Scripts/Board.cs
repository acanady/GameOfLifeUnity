using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Board
{
    private static int size = 0;
    private static GameObject[,] board;
    private static Dictionary<GameObject,Renderer> renderers;
    private static bool created = false;

    public static void CreateBoard(int _size)
    {
        if (!created)
        {
            size = _size;
            board = new GameObject[size, size];
            renderers = new Dictionary<GameObject,Renderer>();
            created = true;
        }
        else
        {
            Debug.LogError("Game board already exists");
        }
        
    }

    public static void SetCell(int i, int j, GameObject cell)
    {
        try
        {
            board[i, j] = cell;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
        
    }

    public static void SetRend(GameObject cell, Renderer render)
    {
        try
        {
            renderers.Add(cell, render);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
    }

    //Returns the renderer of the given cell gameobject
    public static Renderer GetRend(GameObject cell)
    {
        try
        {
            return renderers[cell];
        }
        catch(Exception e)
        {
            Debug.LogException(e);
            return new Renderer();
        }
        
    }

    //Returns the cell gameobject at the given board location
    public static GameObject GetCell(int i, int j)
    {
        try
        {
            return board[i, j];
        }
        catch(Exception e)
        {
            Debug.LogException(e);
            return new GameObject();
        }
    }  

}
