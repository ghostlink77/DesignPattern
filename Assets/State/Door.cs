using UnityEngine;

public class Door : MonoBehaviour
{
    public StateMachine stateMachine;
    public bool isInteracting = false;

    void Start()
    {
        stateMachine = new StateMachine(this);
    }

    void Update()
    {
        stateMachine.Update();
        if (Input.GetMouseButtonDown(0))
        {
            isInteracting = true;
        }
    }

    public void Open()
    {
        Debug.Log("Door is opened");
    }
    public void Close()
    {
        Debug.Log("Door is closed");
    }
}
