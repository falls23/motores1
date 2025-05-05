using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int numero;

    public float velocidade = 40;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numero = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(numero);

        //numero = numero + 1;

    }
    
}
If (Input.GetKey(KeyCode.A));
{
    GameObject.transform.position += new Vector3(velocidade* Time.deltaTime, 0, 0);
}

{
    if(Input.GetKey(KeyCode.D));
}

    GameObject.transform.position += new Vector3(-velocidade * Time.deltaTime,0, 0);