using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Variável para controlar a velocidade.
    [SerializeField] private float velocidadeRotacao = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Multiplicamos o vetor pela velocidade configurada
        transform.Rotate(new Vector3(15, 30, 45) * velocidadeRotacao * Time.deltaTime);
    }
}