using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpSpeed;
    Audios audios;
    
    // Start is called before the first frame update
    void Awake()
    {
        audios = FindObjectOfType<Audios>();
        
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            
            audios.PlayJumpClip();
            rb.velocity = new Vector2(0,jumpSpeed);
        }
    }
}
