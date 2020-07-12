using UnityEngine;

namespace API.InteractorScripts
{
    public class StoryInteractorScript : MonoBehaviour
    {
        public Animator OwnAnimator;
        private static readonly int Play1 = Animator.StringToHash("Play");

        public void Play()
        {
            this.OwnAnimator.SetTrigger(Play1);
        }
        
        public void Play(string key)
        {
            this.OwnAnimator.SetTrigger(key);
        }
    }
}