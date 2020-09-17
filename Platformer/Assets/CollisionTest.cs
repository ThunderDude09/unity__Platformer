using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTest : MonoBehaviour
{
    /*[SerializeField]
    float count = 3;

    [SerializeField]
    int goToLevel = 0;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        count = count - 1;

        Debug.Log(count);

        if(count == 0)
        {
            SceneManager.LoadScene(goToLevel);
            GameManager.instance.AddScore(goToLevel + 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Trigger");

        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Out of trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying in trigger");
    }*/
}
