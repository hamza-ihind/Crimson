using UnityEngine;

public class PlayerIdleState : PlayerState
{

    public PlayerIdleState(Player player) : base(player) 
    {
        
    }

    public override void Enter()
    {
        anim.SetBool("isIdle", true);
    }

    public override void Update()
    {
        base.Update();

        if (JumpPressed)
        {
            JumpPressed = false;
            player.ChangeState(player.jumpState);
        }
    }

    public override void Exit()
    {
        anim.SetBool("isIdle", false);
    }
}
