using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerpaddle;
    public Paddle computerpaddle;
    public TextMeshProUGUI playerscoretext;
    public TextMeshProUGUI computerscoretext;
    private int _playerscore;
    private int _computerscore;
    
    public void Playerscore()
    {
        _playerscore++;
        this.playerscoretext.text = _playerscore.ToString();    
        ResetRound();   
    }

    public void Computerscore()
    {
        _computerscore++;
        this.computerscoretext.text = _computerscore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerpaddle.Resetposition();
        this.computerpaddle.Resetposition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
    
}
