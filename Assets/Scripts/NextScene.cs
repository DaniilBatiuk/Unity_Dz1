using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public int index = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Car>() != null)
        {
            SceneManager.LoadScene(index);
        }
    }
}
