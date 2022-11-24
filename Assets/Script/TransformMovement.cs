using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    public float speedMovement = 5;

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
    
        transform.position += Vector3.forward * z * speedMovement * Time.deltaTime;
        transform.position += Vector3.right * x * speedMovement * Time.deltaTime;
    }
}


//El nombre la funcion se tiene que llamar como el archivo
//Poner todas las variables como public - Speedmovement se podrá mover desde el inspector
//Update es un metodo propio de Unity. Se ejecutará tantas veces como frames por segundo haya.
//vector3 x z (le hemos asignado vertical) x speedmovement x deltatime(compensa el número de frames)