using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterButton : MonoBehaviour
{

    public void StartLevel1()

    {
        //EnterButton-painiketta painettu valikossa
        SceneManager.LoadScene("Level1Copy");
    }

}
