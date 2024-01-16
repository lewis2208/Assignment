using UnityEngine;
//i also used unity forums to help me make this

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector2 movement = new Vector2(horizontalInput, verticalInput);


        transform.Translate(movement * speed * Time.deltaTime);}}