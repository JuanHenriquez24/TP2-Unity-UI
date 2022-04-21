using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniausuario;
    public Text ingresousuario;
    public GameObject cartelitoMsj;
    public Text textomsj;
    // Start is called before the first frame update
    void Start()
    {
        cartelitoMsj.SetActive(false);
        contraseniacorrecta = "12345";   
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContraseña()
    {
        contraseniausuario = ingresousuario.text;
        if (contraseniausuario == contraseniacorrecta)
        {
            cartelitoMsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
