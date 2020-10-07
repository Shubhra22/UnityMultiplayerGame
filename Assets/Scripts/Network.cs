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
        _socket.On("open",OnConnected);
        _socket.On("spawn",OnSpawn);
        //_socket.On("spawn",Callback);
    }

    private void OnSpawn(SocketIOEvent obj)
    {
        Debug.Log("spawned");
        GameObject.CreatePrimitive(PrimitiveType.Capsule);
    }

    private void OnConnected(SocketIOEvent obj)
    {
        Debug.Log("Client Connected");
        _socket.Emit("move");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
