using UnityEngine;

public class PorteSortie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Player"))
        {
            Destroy(autre.gameObject);
            Debug.Log("MISSION RÉUSSIE !");
            return;
        }
        // TODO 2 : afficher le message de réussite.
        // TODO 3 : faire disparaître le joueur.
    }

    /*
     * BANQUE DE LIGNES — À REPLACER DANS LE BON ORDRE
     *
     * Destroy(autre.gameObject);
     * Debug.Log("MISSION RÉUSSIE !");
     * if (!autre.CompareTag("Player"))
     * return;
     */
}

