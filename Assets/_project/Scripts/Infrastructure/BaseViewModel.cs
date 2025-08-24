using R3;

namespace Demo
{
    public abstract class BaseViewModel
    {
        protected readonly CompositeDisposable _disposables = new CompositeDisposable();

        protected BaseViewModel(BaseModel model)
        {
            Model = model;
        }

        protected BaseModel Model { get; }

        public virtual void Dispose()
        {
            _disposables?.Dispose();
        }
    }
}