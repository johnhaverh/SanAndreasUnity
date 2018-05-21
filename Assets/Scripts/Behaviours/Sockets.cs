﻿using SanAndreasAPI;
using System.Diagnostics;
using System.IO;
using System.Net;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Sockets : MonoBehaviour
{
    private static SocketClient client;

    private static bool available = false,
                        startCApp;

    // Use this for initialization
    private void Start()
    {
#if UNITY_EDITOR
        startCApp = true;
#else
        var p = new FluentCommandLineParser();

        p.Setup<bool>('c', "console").Callback(x => startCApp = x);

        p.Parse(Environment.GetCommandLineArgs());
#endif

        string consoleApp = Path.Combine(Application.streamingAssetsPath, "SanAndreasConsole.exe");

        //Debug.LogFormat("Exists Console App: {0}", File.Exists(consoleApp));

        if (startCApp && File.Exists(consoleApp))
        {
            Process.Start(consoleApp);

            client = new SocketClient(SocketExtensions.GetLocalIPAddress(), SocketServer.DefPort); //192.168.1.38

            client.OnConnectedCallback = () =>
            {
                Debug.Log("San Andreas Unity Sockets connected sucesfully!");
                available = true;
            };

            client.DoConnection();
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }

    // From console
    public static void SendLog(ConsoleLog log)
    {
        client.Send(SocketGlobals.SocketManager.SendObject(log, client.Id));
    }
}