using UnityEngine;
using Zenject;

namespace Foundation
{
    public class EffectManager : AbstractService<IEffectManager>, IEffectManager
    {
        [Inject(Id = "Wolna")] AbstractEffect.Factory WolnaFactory = null;
        [Inject(Id = "Boom")] AbstractEffect.Factory BoomFactory = null;

        public void Show(TypeEffect typeEffect, Vector3 pos)
        {
            switch (typeEffect)
            {
                case TypeEffect.Wolna:
                    WolnaFactory.Create().Show(pos);
                    break;

                case TypeEffect.Boom:
                    BoomFactory.Create().Show(pos);
                    break;
            }
        }
    }

}


