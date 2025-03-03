using Fusion;
using Fusion.Sockets;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    [SerializeField] private NetworkRunner _runnerPrefab;
    private NetworkRunner _runner;

    private async void Start()
    {
        _runner = Instantiate(_runnerPrefab);
        await _runner.StartGame(new StartGameArgs()
        {
            GameMode = GameMode.Host,
            SessionName = "MyGameRoom",
            PlayerCount = 10,
        });
    }
}

