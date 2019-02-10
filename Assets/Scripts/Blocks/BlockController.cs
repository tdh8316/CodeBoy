using System.IO.Ports;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BlockController : MonoBehaviour
{
    SerialPort _serialPort = new 
        SerialPort("COM256");
    private int focus = 1;
    public int numOfBlocks = 0;

    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(GameObject.Find(focus.ToString()), null);
        _serialPort.BaudRate = 115200;
        _serialPort.Parity = Parity.None;
        _serialPort.StopBits = StopBits.One;
        _serialPort.DataBits = 8;
        _serialPort.Handshake = Handshake.None;
        // _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        _serialPort.Open();

        Debug.Log("Serial tango");
    }

    // Update is called once per frame
    void Update()
    {
        EventSystem.current.SetSelectedGameObject(
            ProcessSerial(_serialPort.ReadExisting()
            ), null);
        System.Threading.Thread.Sleep(100);
    }

    private GameObject ProcessSerial(string indata)
    {
        indata = indata.Trim();

        if (indata == "RIGHT" || Input.GetKeyUp(KeyCode.RightArrow))
        {
            for (int i = focus; i <= numOfBlocks; i++)
            {
                if (GameObject.Find(i.ToString()) != null && focus != i)
                {
                    focus = i;
                    break;
                }
            }
        }
        else if (indata == "LEFT" || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            for (int i = focus; i > 0; i--)
            {
                if (GameObject.Find(i.ToString()) != null && focus != i)
                {
                    focus = i;
                    break;
                }
            }
        }
        else if (indata == "SEL")
        {
            GameObject.Find(focus.ToString()).GetComponent<Button>().onClick.Invoke();
            for (int i = focus; i > 0; i--)
            {
                if (GameObject.Find(i.ToString()) != null && focus != i)
                {
                    focus = i;
                    break;
                }
            }
        }
        else if (indata == "RUN")
        {
            Debug.Log("RUN");
            StartCoroutine(PlayerMove.Move());
        }
        else { Debug.Log("Invalid value"); }

        Debug.Log("focus is " + focus.ToString());

        if (GameObject.Find(focus.ToString()) == null)
        {
            Debug.Log("ERROR NULL" + focus.ToString());
        }

        return GameObject.Find(focus.ToString());
    }

    private static void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
    {
        SerialPort sp = (SerialPort)sender;
        string indata = sp.ReadExisting();
        Debug.Log("Data Received:");
        Debug.Log(indata);
    }
}
