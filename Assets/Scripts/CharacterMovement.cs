using UnityEngine;

public class CarMovment : MonoBehaviour
{
    public float moveSpeed = 3f;  

    void Update()
    {
      
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
