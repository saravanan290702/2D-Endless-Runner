using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private TrailRenderer trilRenderer;

    [SerializeField] private AudioSource jumpSoundEffect;

    public GameObject restartBO;

    private GameObject player;
    public GameObject endScreen;

    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    bool isAlive = true;
    float score;

    public Text ScoreTxt;
    public Text HighScoreTxt;

   int HighScore;


    [SerializeField] private float jumpingPower = 6f;


    private void Start()
    {
         
        trilRenderer = GetComponentInChildren<TrailRenderer>();
        score = 0;
        HighScoreTxt.text = "HIGHSCORE: " + PlayerPrefs.GetInt("score").ToString();
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        if (isAlive)
        {
            score += Time.deltaTime * 5;
            HighScore = (int)score;
            ScoreTxt.text = "SCORE: " + HighScore.ToString();

            if(PlayerPrefs.GetInt("score") <=HighScore)
            {
                PlayerPrefs.SetInt("score", HighScore);
                HighScoreTxt.text = "HIGHSCORE: " + PlayerPrefs.GetInt("score").ToString();

            }
        }
       
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            

            if (trilRenderer != null)
            {
                trilRenderer.emitting = true;
                trilRenderer.time = Time.deltaTime;
            }
            jumpSoundEffect.Play();
        }

        if (context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
            jumpSoundEffect.Play();
        }
        

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spike"))
        {
            
            Time.timeScale = 0;
            restartBO.SetActive(true);
            endScreen.SetActive(true);
            

        }
      
       
            if (collision.gameObject.CompareTag("Player"))
            {
            Debug.Log("FIN!!!!!!!");
            Destroy(player.gameObject);
                
               
            }
        

    }
    
}