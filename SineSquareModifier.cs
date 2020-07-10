﻿using UnityEngine;

namespace dninosores.UnityAnimationModifiers
{
	class SineSquareModifier : PeriodicModifier
	{
		protected override float GetRawModifiedValue()
		{
			return amplitude * 2 * (Mathf.Pow(Mathf.Sin(time * frequency * Mathf.PI * 2 + phaseShift * Mathf.PI * 2), 2) - 0.5f) + verticalShift;
		}
	}
}
