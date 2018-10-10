﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    //Variable declaration
    public SpriteRenderer bomb;
    public TextMesh number;
    private int numBombs;
    private bool hasBomb;
    private bool gameOver;

	// Use this for initialization
	void Start ()
    {
        number.text = "";
        bomb.enabled = false;
        gameOver = false;
	}

    //Setters
    public void SetText(int num)
    {
        number.text = num.ToString();
    }

    public void SetBomb(bool dead)
    {
        hasBomb = dead;
    }

    public void SetNumBombs(int num)
    {
        numBombs = num;
    }

    //Getters
    public int GetNumBombs()
    {
        return numBombs;
    }

    public bool GetBomb()
    {
        return hasBomb;
    }

    private void OnMouseDown()
    {
        //Turn off the renderer to the tile
        MeshRenderer m = GetComponent<MeshRenderer>();
        m.enabled = false;

        //Check if this tile has a bomb or not
        if (!hasBomb)
        {
            SetText(numBombs);
        }
        else
        {
            bomb.enabled = true;
            gameOver = true;
        }
    }
}
