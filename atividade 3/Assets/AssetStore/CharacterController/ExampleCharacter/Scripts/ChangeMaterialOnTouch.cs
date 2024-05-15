using UnityEngine;

public class ChangeMaterialOnTouch : MonoBehaviour
{
    public Material newMaterial;
    public MeshRenderer OLDMATERIAL;
    public MeshRenderer oldMAterial2;

    // Este método é chamado quando algo colide com o objeto.
    private void OnTriggerEnter(Collider collision)
    {
        // Verifique se o jogador é quem está colidindo.
        if (collision.CompareTag("inimigo"))
        {
            // Muda o material do objeto.
            OLDMATERIAL.material =  newMaterial;
            oldMAterial2.material = newMaterial;
        }
    }
    
}
