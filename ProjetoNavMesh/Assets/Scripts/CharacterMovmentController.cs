using UnityEngine;
using System.Collections;

public class CharacterMovmentController : MonoBehaviour {

    //Inspector Variable
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float speed;


    //Private Variables
    private float verticalInput;
    private float horizontalInput;
    private Vector3 lookingPosition;
    private NavMeshAgent navMeshAgent;


    protected virtual void Awake()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;

        navMeshAgent = GetComponent<NavMeshAgent>();
    }
	protected virtual void Update ()
    {
        DetectInput();
        MoveCharacter();
        LookPointer();	
	}

    private void LookPointer()
    {
		Quaternion LookRotation = Quaternion.LookRotation(lookingPosition - transform.position, transform.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, speed * Time.deltaTime);
    }

    private void MoveCharacter()
    {
        Vector3 targetPosition = new Vector3(horizontalInput * speed, 0, verticalInput * speed);
        navMeshAgent.Move(targetPosition * Time.deltaTime);
    }

    private void DetectInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        Ray cameraToGround = mainCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
       if(Physics.Raycast(cameraToGround, out hit, 50.0f, groundMask))

            lookingPosition = hit.point;
    }
}
