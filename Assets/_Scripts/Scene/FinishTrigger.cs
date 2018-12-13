using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour {

    public GameObject SceneLoader;

    private void OnTriggerStay(Collider other)
    {
        SceneLoader.SetActive(true);
    }

}
