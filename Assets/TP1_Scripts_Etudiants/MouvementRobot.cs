using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MouvementRobot : MonoBehaviour
{
    [SerializeField] private float vitesse = 5f;

    private Rigidbody2D corps;
    private Vector2 direction;

    private void Awake()
    {
        corps = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        direction = new Vector2(horizontal, vertical).normalized;
    }

    private void FixedUpdate()
    {
        corps.MovePosition(corps.position + direction * vitesse * Time.fixedDeltaTime);
    }

    /*
     * BANQUE DE LIGNES — À REPLACER DANS LE BON ORDRE
     *
     * float vertical = Input.GetAxisRaw("Vertical");
     * corps.MovePosition(corps.position + direction * vitesse * Time.fixedDeltaTime);
     * direction = new Vector2(horizontal, vertical).normalized;
     * float horizontal = Input.GetAxisRaw("Horizontal");
     */
}

