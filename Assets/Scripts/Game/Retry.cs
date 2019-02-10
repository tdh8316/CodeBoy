using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void ReloadScene()
    {
        BlockScript.script = new List<int>();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
