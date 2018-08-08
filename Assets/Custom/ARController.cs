using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARController : MonoBehaviour {

    private bool bFirstUpdate = true;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if(bFirstUpdate) {
            Invoke("StartVuforia", 2);
            bFirstUpdate = false;
        }
    }

    void StartVuforia() {
        Debug.Log("START VUFORIA");
        VuforiaConfiguration.Instance.Vuforia.DelayedInitialization = false;
        GetComponent<VuforiaBehaviour>().enabled = true;
        VuforiaRuntime.Instance.InitVuforia();
    }
}
