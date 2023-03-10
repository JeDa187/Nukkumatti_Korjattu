using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{

    public void LoadIntro()
    {
        // Kun klikataan Play-painiketta menussa -> Siirrytään pelin introon, eli Cutscene-skeneen. 
        SceneManager.LoadScene("Cutscene");

    }


    public void Save()
    {
        // Tämä ajetaan menusta, kun painetaan Save painiketta
        // -> Kutsutaan GameManagerin Save funktiota.
        GameManager.manager.Save();

    }

    public void Load()
    {
        // Sama kuin yllä, mutta Load
        GameManager.manager.Load();


    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
