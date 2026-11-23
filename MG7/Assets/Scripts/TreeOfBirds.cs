using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds: MonoBehaviour {

    [SerializeField] private GameObject[] _sparrows;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _interactDistance;

   private void Update() {
    float distance = Vector3.Distance(_playerTransform.position,transform.position);

    if (distance <= _interactDistance) {
        for (int i = 0; i < _sparrows.Length; i++) {
            _sparrows[i].SetActive(true);
            }
        }
    }
}