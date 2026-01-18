using UnityEngine;

public abstract class PlayerState
{
    protected Player player;
    protected Animator anim;

    public PlayerState (Player player)
    {
        this.player = player;
        anim = player.anim;
    }

    public virtual void Enter() { }
    public virtual void Exit() { }

    public virtual void Update() { }
    public virtual void FixedUpdate() { }
}