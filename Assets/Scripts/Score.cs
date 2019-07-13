using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    //public Float playerScore = 0;

    // Update is called once per frame
    void Update()
    {
       // Float playerScore = player.position.z / 10;

       scoreText.text= player.position.z.ToString("Score: 0");
    }
}
