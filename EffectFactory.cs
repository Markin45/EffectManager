using System;
using Zenject;

namespace Foundation
{
	public enum TypeEffect
	{
		Wolna = 10,
		Boom = 20,
	}

	[Serializable]
	public struct EffectSablon
	{
		public TypeEffect typeEffect;
		public AbstractEffect prefabEffect;
		public int poolSize;
	}

	public class EffectFactory : MonoInstaller
	{
		public EffectSablon[] effectSablonS = null;

		public override void InstallBindings()
		{

			foreach (var effectSablon in effectSablonS)
			{
				Container.BindFactory<AbstractEffect, AbstractEffect.Factory>()
					.WithId(effectSablon.typeEffect.ToString())
					.FromMonoPoolableMemoryPool(opts => opts
						.WithInitialSize(effectSablon.poolSize)
						.FromComponentInNewPrefab(effectSablon.prefabEffect)
						.UnderTransform(transform));
			}

		}
	}

}


