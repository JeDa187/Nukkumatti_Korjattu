using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{

    public void LoadIntro()
    {
        // Kun klikataan Play-painiketta menussa -> Siirryt��n pelin introon, eli Cutscene-skeneen. 
        SceneManager.LoadScene("Cutscene");

    }


    public void Save()
    {
        // T�m� ajetaan menusta, kun painetaan Save painiketta
        // -> Kutsutaan GameManagerin Save funktiota.
        GameManager.manager.Save();

    }

    public void Load()
    {
        // Sama kuin yll�, mutta Load
        GameManager.manager.Load();


    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
