using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    
    char direction = 's';
    /* 13(x) by 11(y) */
    short[,] map = new short[,] {
        { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        { 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0 },
        { 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0 },
        { 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0 }};
    short x = 0;
    short y = 5;
    void Update ()
    {
		if(Input.GetKeyDown (KeyCode.RightArrow)) //right
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
        else if (Input.GetKeyDown(KeyCode.LeftArrow))//left
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
