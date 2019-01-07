using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{	
	[CreateAssetMenu(menuName = "Conditions/Monitor Jump")]
	public class MonitorJump : Condition {

		public StateActions onTrueAction;
		public override bool CheckCondition(StateManager state)
		{
			bool result = state.isJumping;
			if(state.isJumping)
			{
				state.isJumping = false;
				if(onTrueAction != null)
				{
					onTrueAction.Execute(state);
				}
			}
			return result;
		}
	}
}
