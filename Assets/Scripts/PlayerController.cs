

using UnityEngine;

public class PlayerController
{
    private PlayerView _view;
    private PlayerModel _model;

    public PlayerController(PlayerView view)
    {
        _view = view;
        _view.ONHit = Dead;
        _view.ONTap = Jump;
        _model = new PlayerModel();
        
    }

    public void Jump()
    {
        _view.Rb.AddForce(new Vector2(1,1), ForceMode2D.Impulse);
        _view.Rb.AddTorque(10f);
    }

    public void Dead()
    {
        _view.Rb.simulated = false;
        Debug.Log("Öldüm");
    }
}