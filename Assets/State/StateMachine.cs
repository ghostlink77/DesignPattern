using UnityEngine;

public class StateMachine
{
    public IState CurrentState { get; private set; }

    public StateOpen stateOpen;
    public StateClose stateClose;

    public StateMachine(Door door)
    {
        stateOpen = new StateOpen(door);
        stateClose = new StateClose(door);
        CurrentState = stateClose;
    }

    public void Initialize(IState initialState)
    {
        CurrentState = initialState;
        CurrentState.Enter();
    }
    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        CurrentState.Enter();
    }
    
    public void Update()
    {
        CurrentState.Update();
    }
}
