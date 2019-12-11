using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velDir, velRot;
    public static float posX, posY, posZ;
    public GameObject tiro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        MovimentarPlayer();
        
        Atirar();
    }

    public void MovimentarPlayer()
    {
        if(Input.GetAxis("Horizontal") > 0)
             {
                 transform.Rotate(Vector3.up * velRot * Time.deltaTime);
             }

            if(Input.GetAxis("Horizontal") < 0)
            {
               transform.Rotate(Vector3.up * -velRot * Time.deltaTime);
            }

            if(Input.GetAxis("Vertical") > 0)
            {
                transform.Translate(Vector3.forward * velDir * Time.deltaTime);
            }

            if(Input.GetAxis("Vertical") < 0)
            {
                transform.Translate(Vector3.back * velDir * Time.deltaTime);
            }
    }

    public void Atirar()
    {
        if (Input.GetMouseButtonDown(1))
        {
           Instantiate(this.tiro, new Vector3(PlayerController.posX, PlayerController.posY, PlayerController.posZ), Quaternion.identity);
        }
    }
}
