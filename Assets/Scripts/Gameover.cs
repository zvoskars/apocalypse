using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
    public void MainMenu(){
        SceneManager.LoadScene(0);

    }

    public void Restart(){
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){

        Application.Quit();
    }

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
 
}
