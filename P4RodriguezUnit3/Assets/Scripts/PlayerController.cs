using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRB = GetComponent<Rigidbody>();
        playerRB.AddForce(Vector3.up * 1000);
    }
}
