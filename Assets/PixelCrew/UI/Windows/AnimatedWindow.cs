using UnityEngine;

namespace PixelCrew.UI.Windows
{
    public class AnimatedWindow: MonoBehaviour
    {
        private Animator _animator;
        private static readonly int Show = Animator.StringToHash("Show");
        private static readonly int Hide = Animator.StringToHash("Hide");

        protected virtual void Start()
        {
            Debug.Log($"Hello from: {name}");
            _animator = GetComponent<Animator>();
            
            _animator.SetTrigger(Show);
        }

        public void Close()
        {
            _animator.SetTrigger(Hide);
        }

        public virtual void OnCloseAnimationComplete()
        {
            Destroy(gameObject); //после того, как мы закрылись, мы можем уничтожить наше окно
        }

        
    }
}