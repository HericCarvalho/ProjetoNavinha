using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Recomeçar : MonoBehaviour
{

    public void restart()
    {
        StartCoroutine(RestartScene());
    }
   IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
