using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadOnClick : MonoBehaviour
{

    public void LoadByName(string sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }
}
