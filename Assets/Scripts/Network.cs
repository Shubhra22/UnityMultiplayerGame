using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

[RequireComponent(typeof(SocketIOComponent))]
public class Network : MonoBehaviour
{
    private SocketIOComponent _socket;
    // Start is called before the first frame update
    void Start()
    {
        _socket = GetComponent<SocketIOComponent>();
        _socket.On("open",Callback);
    }

    private void Callback(SocketIOEvent obj)
    {
        Debug.Log("connected");
        _socket.Emit("move");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
