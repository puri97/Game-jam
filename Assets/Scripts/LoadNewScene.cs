using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    [SerializeField] private Transform mainCamera;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(mainCamera.position.y == 100)
        {
            Debug.Log("Finally");
            SceneManager.LoadScene("Assets/Scenes/Ending.unity");
        }
    }
}
