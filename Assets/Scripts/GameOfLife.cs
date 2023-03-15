using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLife : MonoBehaviour
{
    [SerializeField]
    private TextAsset _stageTextAsset;

    void Start()
    {
        string[] lines = _stageTextAsset.text.Split("\n");
        foreach(string line in lines)
        {
            string[] words = line.Split(",");
            foreach(string word in words)
            {
                Debug.Log(word);
            }
        }
    }

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
