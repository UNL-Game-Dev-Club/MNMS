﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float horizAxis;
    float vertAxis;

    float moveDist;

    bool sprint;


    // Start is called before the first frame update
    void Start()
    {
        moveDist = 5.0f;
        sprint = false;
    }

    // Update is called once per frame
    void Update()
    {
        sprint = Input.GetButton("XboxX");
        Translate();
        vertAxis = Input.GetAxisRaw("Vertical");
        horizAxis = Input.GetAxisRaw("Horizontal");
 
        
        
    }

    void Translate()
    {
        //TODO
        if (sprint)
        {
            moveDist = 10.0f;
        }
        else
        {
            moveDist = 5.0f;
        }
        //Go Up+Left
        if (vertAxis > 0 && horizAxis < 0)
        {
            this.transform.Translate(((Vector2.up * vertAxis) + (Vector2.left * -horizAxis)) * moveDist * Time.deltaTime);
        }

        //Go Up+Right
        else if(vertAxis > 0 && horizAxis > 0)
        {
            this.transform.Translate(((Vector2.up * vertAxis) + (Vector2.right * horizAxis)) * moveDist * Time.deltaTime); 
        }

        //Go Down+Left
        else if(vertAxis < 0 && horizAxis < 0)
        {
            this.transform.Translate(((Vector2.down * -vertAxis) + (Vector2.left * -horizAxis)) * moveDist * Time.deltaTime);
        }

        //Go Down+Right
        else if (vertAxis < 0 && horizAxis > 0)
        {
            this.transform.Translate(((Vector2.down * -vertAxis) + (Vector2.right * horizAxis)) * moveDist * Time.deltaTime);
        }
        //Go Up
        else if(vertAxis > 0)
        {
            this.transform.Translate(((Vector2.up * vertAxis) * vertAxis) * moveDist * Time.deltaTime);
        }

        //Go Down
        else if(vertAxis < 0)
        {
            this.transform.Translate((Vector2.down * -vertAxis) * moveDist * Time.deltaTime);
        }

        //Go Left
        else if(horizAxis < 0)
        {
            this.transform.Translate((Vector2.left * -horizAxis) * moveDist * Time.deltaTime);
        }

        //Go Right
        else if(horizAxis > 0)
        {
            this.transform.Translate((Vector2.right * horizAxis) * moveDist * Time.deltaTime);
        }
    }
}
