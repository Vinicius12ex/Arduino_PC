using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class Arduino_Controller : MonoBehaviour
{
    private SerialPort arduinoSerialPort;
    public string port = "COM3";
    public int baudRate = 9600;

    //Cereal nescau = Arduino
    private void Awake()
    {
        try
        {
            arduinoSerialPort = new SerialPort(port, baudRate)
            {
                ReadTimeout = 100
            };

            arduinoSerialPort.Open();

            StartCoroutine(ProcessData());
        }
        catch (Exception e)
        {
            Debug.LogError("Erro ao abrir a porta." + e);
        }
    }

    private IEnumerator ProcessData()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();
            try
            {
                string result = arduinoSerialPort.ReadLine();
                //Debug.Log("Leitura Arduino" + result);

                string[] resultData = result.Split(';');

                string firstButton = resultData[0];
                Debug.Log("Primeiro botão" + firstButton);
            }
            catch (Exception e)
            {
                //Debug.LogError("Erro ao processar dados" + e);
            }
        }
    }
}