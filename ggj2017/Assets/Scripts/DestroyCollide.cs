using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollide : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter ( Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
