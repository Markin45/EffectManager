using UnityEngine;
using Zenject;

namespace Foundation
{
	public class Effect_std : AbstractEffect
	{
		public override void OnDespawned()
		{
			pool = null;
		}

		public override void OnSpawned(IMemoryPool pool)
		{
			this.pool = pool;
		}

		// для того чтобы в фабрику не передавать Vector3 
		public override void Show(Vector3 pos)
		{
			gameObject.transform.position = pos;

			Invoke(nameof(Hide), 10f);
		}

		void Hide()
		{
			pool.Despawn(this);
		}


	}

}