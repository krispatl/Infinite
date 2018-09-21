using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Update()
    {
        StartCoroutine("Loader");

    }
    IEnumerator Loader()
    {
        yield return new WaitForSeconds(25);
        SceneManager.LoadScene("LWRP Main");
    }
}