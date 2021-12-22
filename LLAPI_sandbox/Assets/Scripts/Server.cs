using UnityEngine;
using UnityEngine.Networking;

public class Server : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        Init();
    }

    public void Init()
    {
        NetworkTransport.Init();
    }
}
