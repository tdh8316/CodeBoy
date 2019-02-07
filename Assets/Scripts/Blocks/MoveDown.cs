using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveDown : MonoBehaviour
{
    private GameObject textObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToScript()
    {
        BlockScript.script.Add(BlockScript.DOWN);
        textObj = GameObject.Find("scriptText");
        textObj.GetComponent<Text>().text += "MoveDown > ";
        Destroy(EventSystem.current.currentSelectedGameObject);
    }
}
