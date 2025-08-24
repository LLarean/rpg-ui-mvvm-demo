using System;
using UnityEngine;

namespace Demo
{
    public abstract class BaseView : MonoBehaviour
    {
        public BaseViewModel ViewModel { get; protected set; }

        public virtual void Initialize(BaseViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        protected virtual void OnDestroy()
        {
            (ViewModel as IDisposable)?.Dispose();
        }
    }
}