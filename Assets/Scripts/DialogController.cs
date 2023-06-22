using System.Collections;
using TMPro;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private string[] textos;
    [SerializeField] private float tempoEntreDialogos;
    [SerializeField] private Transform _camera;
    [SerializeField] private Transform _texto;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private Collider _boxColliderTrigger;
    [SerializeField] private Vector3 _tamanhoTrigger;

    // Update is called once per frame
    private void Start()
    {
        _boxColliderTrigger = GetComponent<Collider>();
    }
    void Update()
    {
        _texto.rotation = _camera.rotation;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Jogador"))
            MostrarDialogos();   
    }

    private void MostrarDialogos()
    {
        StartCoroutine(ContarTempo());
    }

    private IEnumerator ContarTempo()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            text.SetText(textos[i]);
            yield return new WaitForSeconds(tempoEntreDialogos);
        }
        _gameObject.SetActive(false);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(_texto.position,new Vector3(1,1,1));
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(transform.position, _tamanhoTrigger);
    }
}
