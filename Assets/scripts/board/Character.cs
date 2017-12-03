using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterEngine
{
	public class Character : MonoBehaviour
	{
		private int healthPoints, actionpoints, initiative;
		private int healthPointsMax, actionpointsMax;
		private bool isAlive = true;
		public Character(int hp, int ap, int init)
		{
			healthPointsMax = hp;
			actionpointsMax = ap;
			healthPoints = hp;
			actionpointsMax = ap;
			initiative = init;
		}
		public bool Alive()
		{
			return isAlive;
		}
		public void updateAp(int a)
		{
			actionpoints = a;
		}
		public void updateAp()
		{
			actionpoints = actionpointsMax;
		}
		public void heal(int a)
		{
			healthPoints += a;
			if (healthPoints > healthPointsMax)
				healthPoints = healthPointsMax;
		}
		public void damage(int a)
		{
			healthPoints -= a;
			if (healthPoints <= 0)
				isAlive = false;
		}
		public int getMaxHp()
		{
			return healthPointsMax;
		}
		public int getHp()
		{
			return healthPoints;
		}
		public int getApMax()
		{
			return actionpointsMax;
		}
		public int getAp()
		{
			return actionpoints;
		}
		public int getInit()
		{
			return initiative;
		}
	}
}