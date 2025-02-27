using UnityEngine;

public class ControlodaorGarrafa : MonoBehaviour
{
    public ControladorFase geral;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
            geral.Comparar();
    }
}
