﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour {
    char direction = 's';
    void Update () {
		if(Input.GetKeyDown (KeyCode.RightArrow)) //left
        {
            switch(direction)
            {
                case 's':
                    Camera.main.transform.eulerAngles = (new Vector3(0, 0, 0));
                    direction = 'w';
                    break;
                case 'n':
                    Camera.main.transform.eulerAngles = (new Vector3(0, 180, 0));
                    direction = 'e';
                    break;
                case 'w':
                    Camera.main.transform.eulerAngles = (new Vector3(0, 90, 0));
                    direction = 'n';
                    break;
                case 'e':
                    Camera.main.transform.eulerAngles = (new Vector3(0, -90, 0));
                    direction = 's';
                    break;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))//right
        {
            switch (direction)
            {
                case 'n':
                    Camera.main.transform.eulerAngles = (new Vector3(0, 0, 0));
                    direction = 'w';
                    break;
                case 's':
                    Camera.main.transform.eulerAngles = (new Vector3(0, 180, 0));
                    direction = 'e';
                    break;
                case 'e':
                    Camera.main.transform.eulerAngles = (new Vector3(0, 90, 0));
                    direction = 'n';
                    break;
                case 'w':
                    Camera.main.transform.eulerAngles = (new Vector3(0, -90, 0));
                    direction = 's';
                    break;
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))//forward
        {
          transform.Translate(Vector3.forward);
        }       
    }
}
