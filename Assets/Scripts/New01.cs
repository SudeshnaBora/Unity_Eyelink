using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class New01 : MonoBehaviour
{

    [DllImport ("eyelink_core.dll")]
    private static extern int open_eyelink_connection(int x);
    // Start is called before the first frame update

    [DllImport("eyelink_core.dll")]
    private static extern uint do_tracker_setup();

    void Start()
    {
        int result = open_eyelink_connection(1);
        Debug.Log(result);
        // Debug.Log(open_eyelink_connection(0));
    }

    // Update is called once per frame
    void Update()
    {
        //int result = open_eyelink_connection(1);
        
    }
}
