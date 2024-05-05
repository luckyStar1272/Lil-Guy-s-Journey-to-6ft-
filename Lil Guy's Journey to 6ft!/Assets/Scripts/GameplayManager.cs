using UnityEngine;
using TMPro;

public class GameplayManager : MonoBehaviour
{
    // possible turn phases.
    public enum PhaseType {main, combat};

    // possible gameplay turns. (whose turn is it?)
    public enum PlayerTurn {player, enemy};

    // current turn.
    PlayerTurn curTurn;

    // current lv.
    int curLv = 1;

    // UI text.
    public TMP_Text curTurnTxt, curPhaseTxt, curLvTxt, curCoinsTxt, curMPTxt;

    // Start is called before the first frame update.
    void Start()
    {
        // determines who takes the first turn and displays it.
        float randTurn = Random.Range(0.0f, 1.0f);
        curTurn = randTurn <= 0.5f ? PlayerTurn.player : PlayerTurn.enemy;

        // displays UI text.
        DisplayTurn(curTurn);
        DisplayPhase(PhaseType.main);
        curLvTxt.text = "Level #" + curLv.ToString(); // HARD CODED; FIX LATER!
        curCoinsTxt.text = "Coins: " + 0.ToString(); // HARD CODED; FIX LATER!
        curMPTxt.text = "MP: " + 15.ToString(); // HARD CODED; FIX LATER!
    }

    // displays/sets player turn text.
    public void DisplayTurn(PlayerTurn turn) {
        switch(turn) {
            case PlayerTurn.player:
                curTurnTxt.text = "Player's Turn";
                curTurnTxt.color = new Color(0f, 255f, 0f);
                break;
            case PlayerTurn.enemy:
                curTurnTxt.text = "Enemy's Turn";
                curTurnTxt.color = new Color(255f, 0f, 0f);
                break;
        }
    }

    // displays/sets phase text.
    public void DisplayPhase(PhaseType phase) {
        switch(phase) {
            case PhaseType.main:
                curPhaseTxt.text = "Main Phase";
                curPhaseTxt.color = new Color(0f, 255f, 255f);
                break;
            case PhaseType.combat:
                curPhaseTxt.text = "Combat Phase";
                curPhaseTxt.color = new Color(255f, 0f, 255f);
                break;
        }
    }

}
