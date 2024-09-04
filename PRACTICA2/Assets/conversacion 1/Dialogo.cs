using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    [System.Serializable]
    public struct Charla
    {
        public string name;
        public string comentario;
        public Sprite imagen;
    }

    [SerializeField] List<Charla> charla;

    [SerializeField]TextMeshProUGUI nombre;

    [SerializeField] TextMeshProUGUI comentario;

    [SerializeField] Image foto;

    int contador = 0;
     void actualizarDialogo()
    {
        nombre.text = charla[contador].name;
        comentario.text = charla[contador].comentario;
        foto.sprite = charla[contador].imagen;
    }

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        actualizarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            contador++;
            contador %= charla.Count;
            actualizarDialogo();
        }
        
    }
}
