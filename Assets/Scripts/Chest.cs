using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Animator ChestAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        ChestAnim.SetBool("Open", true);
        StartCoroutine(CloseChest());
    }

    IEnumerator CloseChest()
    {
        yield return new WaitForSeconds(5f);
        ChestAnim.SetBool("Open", false);
    }
}
