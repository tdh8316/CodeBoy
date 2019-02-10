using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartButton : MonoBehaviour {

    private void Start()
    {
        Screen.SetResolution(720, 620, false, 30);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Easy");
    }
}
