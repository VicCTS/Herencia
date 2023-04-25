using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : BasePlayer
{
    // Start is called before the first frame update
    void Start()
    {
        //Asignamos el character controller a su variable
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();

        //Con esto podemos esconder el icono del raton para que no moleste
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        Jump();

        if(Input.GetKeyDown(KeyCode.F))
        {
            LevantarPiedras();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }

    void LevantarPiedras()
    {
        Debug.Log("Levantando piedra");
    }

    public override void Attack()
    {
        base.Attack();

        Debug.Log("Con un palo");
    }
}
