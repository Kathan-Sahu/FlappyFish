using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
        
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Score")
        {
            score++;
            print("Score "+score);
        }
    }
    public int GetScore()
    {
        return score;
    }

}
