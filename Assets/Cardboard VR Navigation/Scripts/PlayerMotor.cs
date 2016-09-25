/* © 2015 Studio Pepwuper http://www.pepwuper.com */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class PlayerMotor : MonoBehaviour {

    public GameObject Cursor; // Google Cardboard SDK: Cursor / GazePointer from CardboardMain Prefab
    private Vector3 goal;
    private NavMeshAgent agent;
    public GameObject Chair;
    public GameObject Table;
    public GameObject Toilet;
    public GameObject Cup;
    public GameObject Bed;
    public GameObject Bookshelf;
    public GameObject Door;
    public GameObject Lamp;
    public GameObject MessageCanvas;
    public Text Msg;
    private int key;
    private bool foundKey, finished;

    void Start() {
        this.agent = GetComponent<NavMeshAgent>();
        this.goal = new Vector3(0f, 0f, 0f);

        reStart();
    }


    //Set navigation destination to the position of the cursor
    //Ex. Call this from an event trigger on the floor object
    public void SetDestinationToCursor(int objnum) {
        switch (objnum) {
            case 0:
                goal = Chair.transform.position;
                goal.x -= 1.5f;
                break;
            case 1:
                goal = Table.transform.position;
                goal.x -= 1.5f;
                break;
            case 2:
                goal = Toilet.transform.position;
                goal.x -= 1.5f;
                goal.z -= 1.5f;
                break;
            case 3:
                goal = Cup.transform.position;
                goal.x -= 1.5f;
                break;
            case 4:
                goal = Bed.transform.position;
                goal.x += 1.5f;
                break;
            case 5:
                goal = Bookshelf.transform.position;
                goal.z -= 1.5f;
                break;
            case 6:
                goal = Lamp.transform.position;
                break;
            case 7:
                goal = Door.transform.position;
                goal.z += 2.5f;

                if (foundKey)
                {
                    Msg.text = "Congratulations!";
                    finished = true;
                    MoveToDestination();
                }
                else {
                    Msg.text = "You have to find the key first!";
                    MessageCanvas.SetActive(true);
                }

                return;
        }

        if (objnum == key)
        {
            if (foundKey) {
                Msg.text = "You've found the key";
                MessageCanvas.SetActive(true);
                return;
            }

            Msg.text = "You found the key!\nLet's get out of here";
            foundKey = true;
        }
        else {
            Msg.text = "Nothing here... ";
        }

        MoveToDestination();
    }

    void MoveToDestination() {
        this.agent.destination = goal;

        MessageCanvas.SetActive(true);
    }

    public bool isFinished() {
        Msg.text = "call";
        MessageCanvas.SetActive(true);
        return finished;
    }

    public void reStart() {
        this.transform.position = new Vector3(0f, 1f, 0f);

        System.Random rnd = new System.Random();
        key = rnd.Next(0, 7);
        foundKey = false;
        finished = false;
        Msg.text = "Reset";
        MessageCanvas.SetActive(true);
    }
}