using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveUp : MonoBehaviour
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
        BlockScript.script.Add(BlockScript.UP);
        textObj = GameObject.Find("scriptText");
        textObj.GetComponent<Text>().text += BlockScript.S_MOVEUP;
        Destroy(EventSystem.current.currentSelectedGameObject);
    }
}
