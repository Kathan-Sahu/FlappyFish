using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(-speed,0f);
    }

    // Update is called once per frame
    void Update()
    {
        DestroyObs();
    }

    void DestroyObs()
    {
        if(transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }
}
