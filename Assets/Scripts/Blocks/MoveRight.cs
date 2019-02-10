using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveRight : MonoBehaviour
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
        BlockScript.script.Add(BlockScript.RIGHT);
        textObj = GameObject.Find("scriptText");
        textObj.GetComponent<Text>().text += BlockScript.S_MOVERIGHT;
        Destroy(EventSystem.current.currentSelectedGameObject);
    }
}
