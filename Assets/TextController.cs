using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Caveman is an state-based text adventure. it uses enum to keep track of the different states the player is in.
/// </summary>

public class TextController : MonoBehaviour {

    //Declare variables overhere
    public Text text;

    private enum States { Woods, Cave, Cave2, Cave_W1, Cave_W2, Cave_W3, Stone, Spear, Murals, Passage_0, Great_Cave, People, Pillar, Passage_1 };
    private States myState;


    // Use this for initialization
    void Start () {
        myState = States.Woods;
	}
	
	
	// Update is called once per frame
	void Update () {

        //if/elif/ state to trigger the proper methods according to their different states

        if (myState == States.Woods)
        {
            state_woods();
        }
        else if (myState == States.Cave)
        {
            state_cave();
        }else if(myState == States.Murals)
        {
            state_Murals();
        }
        else if (myState == States.Cave_W1)
        {
            state_Cave_W1();
        }else if (myState == States.Cave_W2)
        {
            state_Cave_W2();
        }else if (myState == States.Cave_W3)
        {
            state_Cave_W3();
        }else if (myState == States.Cave2)
        {
            state_Cave2();
        }else if (myState == States.Passage_0)
        {
            state_Passage0();
        }

		
	}

   /// void switch_State(enum Currentstate,string choice)
      // {
      //    
      //  
      // }


    //State methods, used to display the proper message to the screen and used for the actions.

    void state_woods()
    {
        text.text = "You're taking a stroll in the woods..." +
                    "Suddenly you hear something rustle in the bushes," +
                    "As you start walking towards them, a creatures jumps out " +
                    "of the bushes and start attacking you." +
                    "You try to fight back, but the creature is..just...to...strong\n\n" +
                    "Press space to continue";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myState = States.Cave;
        }
    }

    void state_cave()
    {
        text.text = "When you wake up, you take a looksy around. It seems you're in a cave. As your eyes roll over the walls, " +
                    "you notice all sorts of murals being drawn on them. " +
                    "There is a stone, a spear and a passage.\n\n " +
                    "To inspect the murals press M, to take the stone press S, to take the spear press W or B to take both! to walk trough the passage press P";

        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.Murals;
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.Cave_W1;
        }else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Cave_W2;
        }else if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.Cave_W3;
        }else if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.Passage_0;
        }
               
        

     
    }

    void state_Murals()
    {
        text.text = "Placeholder\n\n" +
                    "Press R to return";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.Cave;
        }
    }
    void state_Cave_W1()
    {
        text.text = "It's a stone. you can take it with you.\n\n" +
                    "Press T to continue your path..";

        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.Cave2;
        }
    }
    void state_Cave_W2()
    {
        text.text = "You can use the spear to hunt and kill\n\n" +
                    " Press T to Continue your path";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.Cave2;
        }

    }
    void state_Cave_W3()
    {
        text.text = "Now you've got the stone and the spear. Lets check what else we can do.\n\n" +
                    "Press T to Continue" ;
            if (Input.GetKeyDown(KeyCode.T))
            {
            myState = States.Cave2;
            }
    }
    void state_Cave2()
    {
        text.text = "You've got a weapon, let's see what's beyond that dark passage...\n\n" +
                    "Press T to coninue trough the passage..";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.Passage_0;
        }
    }
    void state_Passage0()
    {
        text.text = "TO be continued. \n\n " +
                    "press spacebar to run again.";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myState = States.Woods;
        }
    }
}

