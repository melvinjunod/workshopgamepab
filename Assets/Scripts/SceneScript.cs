using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit() {
        Application.Quit();
    }

    void Update() {
        if(Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Q)) {
            Exit();
        }
    }
}
