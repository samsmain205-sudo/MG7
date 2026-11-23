using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds: MonoBehaviour {

    [SerializeField] private GameObject[] _sparrows;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _interactDistance;

   private void Update() {
    for (int i = 0; i < _sparrows.Length; i++) {
        float distance = Vector3.Distance(_playerTransform.position, _sparrows[i].transform.position);
        if (distance <= _interactDistance) {
            _sparrows[i].SetActive(true);
        }
        else {
            _sparrows[i].SetActive(false);
        }
    }
   }
}