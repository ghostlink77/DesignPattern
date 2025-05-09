using UnityEngine;

public class StateOpen : IState
{
    private Door door;

    public StateOpen(Door door)
    {
        this.door = door;
    }
    public void Enter()
    {
        Debug.Log("StateOpen: Open the Door");
    }
    public void Update()
    {
        if(door.isInteracting)
        {
            door.Close();
            door.stateMachine.TransitionTo(door.stateMachine.stateClose);
            door.isInteracting = false;
        }
    }
    public void Exit()
    {
        Debug.Log("StateOpen: Exit");
    }
}