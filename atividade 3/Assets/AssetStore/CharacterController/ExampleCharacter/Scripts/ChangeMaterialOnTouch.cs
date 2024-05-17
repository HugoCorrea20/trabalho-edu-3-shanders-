using UnityEngine;

public class ChangeMaterialOnTouch : MonoBehaviour
{
    public Material congelamento ;
    public Material celEffects;
    public MeshRenderer OLDMATERIAL;
    public MeshRenderer oldMAterial2;

    // Este método é chamado quando algo colide com o objeto.
    private void OnTriggerEnter(Collider collision)
    {
        // Verifique se o jogador é quem está colidindo.
        if (collision.CompareTag("congelamento"))
        {
            // Muda o material do objeto.
            OLDMATERIAL.material =  congelamento;
            oldMAterial2.material = congelamento;
        }
        if(collision.CompareTag("celEffects"))
        {
            OLDMATERIAL.material = celEffects;
            oldMAterial2.material = celEffects;

        }
    }
    
}
