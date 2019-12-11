using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    public float velTiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     ControladorDoTipo();  
    }
    
    public void ControladorDoTipo()
    {
          transform.Translate(Vector3.forward * velTiro * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("TagParede"))
       {
           Destroy(gameObject);
       }
    }
}
