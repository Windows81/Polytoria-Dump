using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Seat : Part
	{
		[SyncVar]
		private Player occupant;

		private float timeUntilCanSitAgain;

		public LuaEvent Sat;

		public LuaEvent Vacated;

		protected NetworkBehaviourSyncVar ___occupantNetId;

		public Player Occupant => null;

		public Player Networkoccupant
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		[MoonSharpHidden]
		public event Action<Player> _Sat
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[MoonSharpHidden]
		public event Action<Player> _Vacated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnCollisionEnter(Collision collision)
		{
		}

		protected override void OnTriggerEnter(Collider other)
		{
		}

		[MoonSharpHidden]
		public void SetOccupant(Player player)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
