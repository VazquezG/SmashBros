using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValoresAnimaciones : MonoBehaviour
{
    Animator anim;
    float movimientoLateral;
    float speed;
    void Start()
    {
        anim = GetComponent<Animator>();
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        movimientoLateral = Input.GetAxis("Horizontal");
        if (movimientoLateral != 0)
        {
            anim.SetBool("CaminandoB", true);
            if(movimientoLateral > 0)
            {
                transform.localEulerAngles = new Vector3(0, 90, 0);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            else
            {
                transform.localEulerAngles = new Vector3(0,270,0);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
        }
        else
        {
            anim.SetBool("CaminandoB", false);
        }
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("GolpeT");
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("JumpT");
        }
    }

    IEnumerable timerGolpe()
    {
        yield return new WaitForSeconds(2);
    }

}
