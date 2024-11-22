using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayCas : MonoBehaviour

{
    public Text cuentaAtrasTexto;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
    }

    void Raycast(){ 
        if(Input.GetButtonDown("Fire1")){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.transform.tag == "Scene1")
                {
                    StartCoroutine(CuentaAtras());
                    IEnumerator CuentaAtras()
                 {
                    cuentaAtrasTexto.text = "5";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "4";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "3";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "2";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "1";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "0";
                    yield return new WaitForSeconds(1);
                 }
                    SceneManager.LoadScene("Scene1 1");
                }
                if(hit.transform.tag == "Scene2")
                {
                    StartCoroutine(CuentaAtras());
                     IEnumerator CuentaAtras()
                 {
                    cuentaAtrasTexto.text = "5";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "4";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "3";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "2";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "1";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "0";
                    yield return new WaitForSeconds(1);
                 }
                    SceneManager.LoadScene("Scene1 2");
                }
                 if(hit.transform.tag == "Scene3")
                {
                    StartCoroutine(CuentaAtras());
                     IEnumerator CuentaAtras()
                 {
                    cuentaAtrasTexto.text = "5";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "4";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "3";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "2";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "1";
                    yield return new WaitForSeconds(1);
                    cuentaAtrasTexto.text = "0";
                    yield return new WaitForSeconds(1);
                 }
                    SceneManager.LoadScene("Scene1 3");
                }
            }
        }

    }
}


