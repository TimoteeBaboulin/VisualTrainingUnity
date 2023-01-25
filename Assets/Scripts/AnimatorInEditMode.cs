using UnityEngine;

[ExecuteInEditMode]
public class AnimatorInEditMode : MonoBehaviour{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _delta;
    
    private void Update(){
        if (_animator == null) return;
        
        _animator.Update(_delta);
    }
}
