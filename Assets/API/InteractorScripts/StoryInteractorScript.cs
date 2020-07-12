using UnityEngine;

namespace API.InteractorScripts
{
    public class StoryInteractorScript : MonoBehaviour
    {
        public static bool IsRunningAnimation;
        public Animator OwnAnimator;
        private static readonly int Play1 = Animator.StringToHash("Play");

        public void Play()
        {
            if (IsRunningAnimation) return;
            
            IsRunningAnimation = true;
            this.OwnAnimator.SetTrigger(Play1);
        }
        
        public void Play(string key)
        {
            if (IsRunningAnimation) return;
            
            IsRunningAnimation = true;
            this.OwnAnimator.SetTrigger(key);
        }

        public void OnAnimationDone()
        {
            IsRunningAnimation = false;
        }
    }
}