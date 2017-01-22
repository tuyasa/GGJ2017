using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disablesControl : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
    


        void Update()
    {
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
    }
}
