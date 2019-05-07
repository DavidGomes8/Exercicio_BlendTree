using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Animator an;
    [Range(0,5)]
    public int velocidade = 2;

    public static int ponto;

    public GameObject portal;
	
	void Start () {
        an = GetComponent<Animator>();
	}
	
	
	void Update () {
        //an.SetFloat("Blend", 1);

        transform.Translate(Vector3.forward*Time.deltaTime*Input.GetAxis("Vertical")*velocidade);

        an.SetFloat("Blend", Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.LeftShift))
        {
            an.speed = 2;
            velocidade = 4;
        }
        else
        {
            an.speed = 1;
            velocidade = 2;
        }

        transform.Rotate(0, Input.GetAxis("Horizontal")*velocidade, 0, Space.Self);

        if (ponto>=4)
        {
            portal.gameObject.SetActive(true);
        }
	}
}
