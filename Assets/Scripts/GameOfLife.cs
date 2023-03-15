using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLife : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray selectionRay = Camera.main.ScreenPointToRay(
                Input.mousePosition
            );
            RaycastHit selection;
            if(Physics.Raycast(selectionRay, out selection))
            {
                Debug.Log(selection.transform.gameObject.name);
            }
        }
    }
}
