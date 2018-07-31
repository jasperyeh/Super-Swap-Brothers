using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public Transform[] playerspawns;
        public Transform player1spawn;
        public Transform player2spawn;
        public Transform player3spawn;
        public Transform player4spawn;
        public GameObject player1;
        public GameObject player2;
        public GameObject Bullet;

        public Text p1lives;
        //public Text p2lives;
        public Text p3lives;
        //public Text p4lives;

        public Text victory;

        public Image p1life1;
        public Image p1life2;
        public Image p1life3;
        public Image p1life4;
        public Image p1life5;

        //public Image p2life1;
        //public Image p2life2;
        //public Image p2life3;
        //public Image p2life4;
        //public Image p2life5;

        public Image p3life1;
        public Image p3life2;
        public Image p3life3;
        public Image p3life4;
        public Image p3life5;

        //public Image p4life1;
        //public Image p4life2;
        //public Image p4life3;
        //public Image p4life4;
        //public Image p4life5;

        public float player1lives = 5f;
        //public float player2lives = 5f;
        public float player3lives = 5f;
        //public float player4lives = 5f;

        private void Start()
        {
            SetP1Lives();
            //SetP2Lives();
            SetP3Lives();
            //SetP4Lives();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            // player1
            if (other.tag == "player1")
            {
                player1lives = player1lives - 1;
                print("Player 1 has " + player1lives + " lives left.");
                if(player1lives > 0)
                {
                    other.transform.position = playerspawns[UnityEngine.Random.Range(0, playerspawns.Length)].position;
                    
                }
                else
                {
                    print("player1 GAME OVER");
                }
            }

            //// player2
            //if (other.tag == "player2")
            //{
            //    player2lives = player2lives - 1;
            //    print("Player 2 has " + player2lives + " lives left.");
            //    if (player2lives > 0)
            //    {
            //        other.transform.position = playerspawns[UnityEngine.Random.Range(0, playerspawns.Length)].position;
            //    }
            //    else
            //    {
            //        print("player2 GAME OVER");
            //    }
            //}

            // player3
            if (other.tag == "player3")
            {
                player3lives = player3lives - 1;
                print("Player 2 has " + player3lives + " lives left.");
                if (player3lives > 0)
                {
                    other.transform.position = playerspawns[UnityEngine.Random.Range(0, playerspawns.Length)].position;
                }
                else
                {
                    print("player2 GAME OVER");
                }
            }

            ////player4
            //if (other.tag == "player4")
            //{
            //    player4lives = player4lives - 1;
            //    print("Player 4 has " + player4lives + " lives left.");
            //    if (player4lives > 0)
            //    {
            //        other.transform.position = playerspawns[UnityEngine.Random.Range(0, playerspawns.Length)].position;
            //    }
            //    else
            //    {
            //        print("player4 GAME OVER");
            //    }
            //}
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }

            if (player1lives == 4)
            {
                p1life5.enabled = false;
            }
            if (player1lives == 3)
            {
                p1life4.enabled = false;
            }
            if (player1lives == 2)
            {
                p1life3.enabled = false;
            }
            if (player1lives == 1)
            {
                p1life2.enabled = false;
            }
            if (player1lives == 0)
            {
                p1life1.enabled = false;
            }

            //if (player2lives == 4)
            //{
            //    p2life5.enabled = false;
            //}
            //if (player2lives == 3)
            //{
            //    p2life4.enabled = false;
            //}
            //if (player2lives == 2)
            //{
            //    p2life3.enabled = false;
            //}
            //if (player2lives == 1)
            //{
            //    p2life2.enabled = false;
            //}
            //if (player2lives == 0)
            //{
            //    p2life1.enabled = false;
            //}

            if (player3lives == 4)
            {
                p3life5.enabled = false;
            }
            if (player3lives == 3)
            {
                p3life4.enabled = false;
            }
            if (player3lives == 2)
            {
                p3life3.enabled = false;
            }
            if (player3lives == 1)
            {
                p3life2.enabled = false;
            }
            if (player3lives == 0)
            {
                p3life1.enabled = false;
            }

            //if (player4lives == 4)
            //{
            //    p4life5.enabled = false;
            //}
            //if (player4lives == 3)
            //{
            //    p4life4.enabled = false;
            //}
            //if (player4lives == 2)
            //{
            //    p4life3.enabled = false;
            //}
            //if (player4lives == 1)
            //{
            //    p4life2.enabled = false;
            //}
            //if (player4lives == 0)
            //{
            //    p4life1.enabled = false;
            //}

            if (player1lives > 0 && player3lives == 0)
            {
                print("PLAYER 1 WINS");
                victory.text = "PLAYER 1 WINS: Press SPACE to restart";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
            //if (player2lives > 0 && player1lives == 0 && player3lives == 0 && player4lives == 0)
            //{
            //    print("PLAYER 2 WINS");
            //    victory.text = "PLAYER 2 WINS: Press SPACE to restart";
            //    if (Input.GetKeyDown(KeyCode.Space))
            //    {
            //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //    }
            //}
            if (player3lives > 0 && player1lives == 0)
            {
                print("PLAYER 2 WINS");
                victory.text = "PLAYER 2 WINS: Press SPACE to restart";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
            //if (player4lives > 0 && player1lives == 0 && player2lives == 0 && player3lives == 0)
            //{
            //    print("PLAYER 4 WINS");
            //    victory.text = "PLAYER 4 WINS: Press SPACE to restart";

            //    if (Input.GetKeyDown(KeyCode.Space)){
            //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //    }
            //}
        }

        void SetP1Lives()
        {
            p1lives.text = "P1 Lives: " + player1lives.ToString();
        }
        //void SetP2Lives()
        //{
        //    p2lives.text = "P2 Lives: " + player2lives.ToString();
        //}
        void SetP3Lives()
        {
            p3lives.text = "P3 Lives: " + player3lives.ToString();
        }
        //void SetP4Lives()
        //{
        //    p4lives.text = "P4 Lives: " + player4lives.ToString();
        //}
    }
}
