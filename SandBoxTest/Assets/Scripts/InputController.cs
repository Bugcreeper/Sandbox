using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public GameObject buildmode;
    private bool buildmodeon = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            if(buildmodeon == true) 
            {
                buildmodeon = false;
            }
            if (buildmodeon == false)
            {
                buildmodeon = true;
            }
            buildmode.SetActive(buildmodeon);
        }       
    }
}
