using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        other.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
