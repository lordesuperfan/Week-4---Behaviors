using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.GetComponent<MoveObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
        objectToActivate.GetComponent<MoveObject>().enabled = true;

    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger!");
        objectToActivate.GetComponent<MoveObject>().enabled = true;

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger off!");
        objectToActivate.GetComponent<MoveObject>().enabled = false;

    }
}
