using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2To3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene("Room3", LoadSceneMode.Additive);
        transform.position = new Vector3(10000000f, 10000000f, 10000000f);
    }

}
