﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float horizAxis;
    float vertAxis;

    float moveDist;

    // Start is called before the first frame update
    void Start()
    {
        moveDist = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Translate();
        vertAxis = Input.GetAxisRaw("Vertical");
        horizAxis = Input.GetAxisRaw("Horizontal");
        
    }

    void Translate()
    {
        //TODO
        //Go Up+Left
        if(vertAxis > 0 && horizAxis < 0)
        {
            this.transform.Translate((Vector2.up + Vector2.left) * moveDist * Time.deltaTime);
        }

        //Go Up+Right
        else if(vertAxis > 0 && horizAxis > 0)
        {
            this.transform.Translate((Vector2.up + Vector2.right) * moveDist * Time.deltaTime); 
        }

        //Go Down+Left
        else if(vertAxis < 0 && horizAxis < 0)
        {
            this.transform.Translate((Vector2.down + Vector2.left) * moveDist * Time.deltaTime);
        }

        //Go Down+Right
        else if (vertAxis < 0 && horizAxis > 0)
        {
            this.transform.Translate((Vector2.down + Vector2.right) * moveDist * Time.deltaTime);
        }
        //Go Up
        else if(vertAxis > 0)
        {
            this.transform.Translate(Vector2.up * moveDist * Time.deltaTime);
        }

        //Go Down
        else if(vertAxis < 0)
        {
            this.transform.Translate(Vector2.down * moveDist * Time.deltaTime);
        }

        //Go Left
        else if(horizAxis < 0)
        {
            this.transform.Translate(Vector2.left * moveDist * Time.deltaTime);
        }

        //Go Right
        else if(horizAxis > 0)
        {
            this.transform.Translate(Vector2.right * moveDist * Time.deltaTime);
        }
    }
}
