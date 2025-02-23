using UnityEngine;

public class firstScript : MonoBehaviour
{
    

    public CarController controller;

    public GameObject player;

    public GameObject[] cameraPositions;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<CarController>();
        
    }

    private void FixedUpdate()
    {
        
        gameObject.transform.position = controller.cameraTarget.transform.GetChild(0).transform.position;
       
        gameObject.transform.LookAt(controller.cameraTarget.transform.GetChild(1).transform.position);
    }
}
