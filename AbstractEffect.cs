using UnityEngine;
using Zenject;

namespace Foundation
{
    public abstract class AbstractEffect : AbstractBehaviour, IPoolable<IMemoryPool>
    {
        // IPoolable
        public sealed class Factory : PlaceholderFactory<AbstractEffect> { }
        protected IMemoryPool pool;

        public abstract void OnDespawned();
        public abstract void OnSpawned(IMemoryPool pool);


        // my
        public abstract void Show(Vector3 pos);
    }
}
