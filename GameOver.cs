using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public static bool isGameOver;
    public GameObject gameOverMenuUI;

    // Update is called once per frame
    void Update () {
        if (isGameOver)
        {
            setGameOver();
        }
    }

    private void Start()
    {
        isGameOver = false;
        gameOverMenuUI.SetActive(false);
    }

    public void setGameOver()
    {
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGameOver = true;
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}
