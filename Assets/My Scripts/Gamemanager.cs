using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    public enum GameState {PLAY, PAUSE, GAMEOVER }
    public GameState state;
    public bool hasChangedState = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameState.PLAY;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (state)
            {
                case GameState.PLAY:
                    state = GameState.PAUSE;
                    break;

                case GameState.PAUSE:
                    state = GameState.PLAY;
                    break;
            }
            hasChangedState = true;
        }
    }

    private void LateUpdate()
    {
        if (hasChangedState)
        {
            hasChangedState = false;
        }
        switch (state)
        {
            case GameState.PLAY:
                Time.timeScale = 1.0f;
                break;

            case GameState.PAUSE:
                Time.timeScale = 0.0f;
                break;
        }
    }
}
