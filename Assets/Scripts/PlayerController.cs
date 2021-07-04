

using System.Runtime.InteropServices;
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
        _view.ONStart = StartGame;
        _view.ONScore = NewScore;
        _model = new PlayerModel();
        _model.Velocity = _view.velocity;
        _model.StartPos = _view.transform.position;
    }

    public void Jump()
    {
            _view.Anim.SetTrigger("TapTrig");
            _view.Rb.velocity = Vector2.up * _model.Velocity;
    }

    public void Dead()
    {
        _view.Anim.ResetTrigger("TapTrig");
        _view.Rb.simulated = false;
        _view._platform.GetComponent<Animator>().enabled = false;
        _view.UIM.changeScene(PlayerModel.Scenes.EndGame);

        if (_model.currentScore > _model.BestScore)
        {
            _model.BestScore = _model.currentScore;
            _view.UIM._bestScore.text = _model.BestScore.ToString();
        }
        Debug.Log("Öldüm");

    }

    public void StartGame()
    {
        _view.transform.position = _model.StartPos;
        _model.currentScore = 0;
        WriteScore();
        _view.UIM.changeScene(PlayerModel.Scenes.InGame);
        _view.Rb.simulated = true;
    }

    public void NewScore()
    {
        _model.currentScore++;
        WriteScore();
    }

    private void WriteScore()
    {
        _view.UIM._currentScore.text = _model.currentScore.ToString();
    }
}