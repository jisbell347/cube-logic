using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public float sizeModifier = 2.5f;
    public string newName = "Cubey";
    public bool isRotated = false;

    // Used for initialization.
    void Start (){
        transform.name = ImproveName(newName);

        if ("cats" == "dogs"){
            Debug.Log("We're here!");
        }

        if ("cats" != "dogs")
        {
            Debug.Log("We're there!");
        }
    }

    // Called once per frame.
    void Update(){
        transform.localScale = Vector3.one * sizeModifier;
    }

    string ImproveName(string originalString){
        return "-[" + originalString + "]-";
    }

}
