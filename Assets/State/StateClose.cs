using UnityEngine;

public class StateClose : IState
{
    private Door door;

    public StateClose(Door door)
    {
        this.door = door;
    }
    public void Enter()
    {
        Debug.Log("StateClose: Close the Door");
    }
    public void Update()
    {
        if (door.isInteracting)
        {
            door.Open();
            door.stateMachine.TransitionTo(door.stateMachine.stateOpen);
            door.isInteracting = false;
        }
    }
    public void Exit()
    {
        Debug.Log("StateClose: Exit");
    }
}