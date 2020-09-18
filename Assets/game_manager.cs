using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameOverCanvas;

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }
}
