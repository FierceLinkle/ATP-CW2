using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class EnemyEncounter : MonoBehaviour
{
    public FirstPersonController fps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            fps.m_MouseLook.SetCursorLock(false);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
