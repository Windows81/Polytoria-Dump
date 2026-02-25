namespace UnityEngine;

[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000002")]
[UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	[Token(Token = "0x200000C")]
	internal struct ColorOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x1700002C")]
		public MinMaxGradient color
		{
			[Address(RVA = "0x19DCCD0", Offset = "0x19DBED0", Length = "0xF9")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000062")]
			 set { } //Length: 249
		}

		[NativeName("Color")]
		[Token(Token = "0x1700002D")]
		private MinMaxGradientBlittable colorBlittable
		{
			[Address(RVA = "0x19DCC80", Offset = "0x19DBE80", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000063")]
			private set { } //Length: 66
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000061")]
		internal ColorOverLifetimeModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x19DCCD0", Offset = "0x19DBED0", Length = "0xF9")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000062")]
		public void set_color(MinMaxGradient value) { }

		[Address(RVA = "0x19DCC80", Offset = "0x19DBE80", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000063")]
		private void set_colorBlittable(MinMaxGradientBlittable value) { }

		[Address(RVA = "0x19DCC30", Offset = "0x19DBE30", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000064")]
		private static void set_colorBlittable_Injected(ref ColorOverLifetimeModule _unity_self, in MinMaxGradientBlittable value) { }

	}

	[Token(Token = "0x2000004")]
	internal struct EmissionModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000002")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x1700001B")]
		public bool enabled
		{
			[Address(RVA = "0x19DCDD0", Offset = "0x19DBFD0", Length = "0x42")]
			[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000044")]
			 set { } //Length: 66
		}

		[Token(Token = "0x1700001C")]
		public MinMaxCurve rateOverTime
		{
			[Address(RVA = "0x19DCEC0", Offset = "0x19DC0C0", Length = "0x118")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000045")]
			 set { } //Length: 280
		}

		[NativeName("RateOverTime")]
		[Token(Token = "0x1700001D")]
		private MinMaxCurveBlittable rateOverTimeBlittable
		{
			[Address(RVA = "0x19DCE70", Offset = "0x19DC070", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000046")]
			private set { } //Length: 66
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		internal EmissionModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x19DCDD0", Offset = "0x19DBFD0", Length = "0x42")]
		[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000044")]
		public void set_enabled(bool value) { }

		[Address(RVA = "0x19DCEC0", Offset = "0x19DC0C0", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000045")]
		public void set_rateOverTime(MinMaxCurve value) { }

		[Address(RVA = "0x19DCE70", Offset = "0x19DC070", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000046")]
		private void set_rateOverTimeBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DCE20", Offset = "0x19DC020", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000047")]
		private static void set_rateOverTimeBlittable_Injected(ref EmissionModule _unity_self, in MinMaxCurveBlittable value) { }

	}

	[Token(Token = "0x200000B")]
	internal struct EmitParams
	{
		[FieldOffset(Offset = "0x0")]
		[NativeName("particle")]
		[Token(Token = "0x400002B")]
		private Particle m_Particle; //Field offset: 0x0
		[FieldOffset(Offset = "0x84")]
		[NativeName("positionSet")]
		[Token(Token = "0x400002C")]
		private bool m_PositionSet; //Field offset: 0x84
		[FieldOffset(Offset = "0x85")]
		[NativeName("velocitySet")]
		[Token(Token = "0x400002D")]
		private bool m_VelocitySet; //Field offset: 0x85
		[FieldOffset(Offset = "0x86")]
		[NativeName("axisOfRotationSet")]
		[Token(Token = "0x400002E")]
		private bool m_AxisOfRotationSet; //Field offset: 0x86
		[FieldOffset(Offset = "0x87")]
		[NativeName("rotationSet")]
		[Token(Token = "0x400002F")]
		private bool m_RotationSet; //Field offset: 0x87
		[FieldOffset(Offset = "0x88")]
		[NativeName("rotationalSpeedSet")]
		[Token(Token = "0x4000030")]
		private bool m_AngularVelocitySet; //Field offset: 0x88
		[FieldOffset(Offset = "0x89")]
		[NativeName("startSizeSet")]
		[Token(Token = "0x4000031")]
		private bool m_StartSizeSet; //Field offset: 0x89
		[FieldOffset(Offset = "0x8A")]
		[NativeName("startColorSet")]
		[Token(Token = "0x4000032")]
		private bool m_StartColorSet; //Field offset: 0x8A
		[FieldOffset(Offset = "0x8B")]
		[NativeName("randomSeedSet")]
		[Token(Token = "0x4000033")]
		private bool m_RandomSeedSet; //Field offset: 0x8B
		[FieldOffset(Offset = "0x8C")]
		[NativeName("startLifetimeSet")]
		[Token(Token = "0x4000034")]
		private bool m_StartLifetimeSet; //Field offset: 0x8C
		[FieldOffset(Offset = "0x8D")]
		[NativeName("meshIndexSet")]
		[Token(Token = "0x4000035")]
		private bool m_MeshIndexSet; //Field offset: 0x8D
		[FieldOffset(Offset = "0x8E")]
		[NativeName("applyShapeToPosition")]
		[Token(Token = "0x4000036")]
		private bool m_ApplyShapeToPosition; //Field offset: 0x8E

	}

	[Token(Token = "0x2000003")]
	internal struct MainModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000001")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x1700000D")]
		public float duration
		{
			[Address(RVA = "0x19DCFE0", Offset = "0x19DC1E0", Length = "0x43")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000030")]
			 set { } //Length: 67
		}

		[Token(Token = "0x17000017")]
		public MinMaxCurve gravityModifier
		{
			[Address(RVA = "0x19DD0D0", Offset = "0x19DC2D0", Length = "0x118")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x600003A")]
			 set { } //Length: 280
		}

		[NativeName("GravityModifier")]
		[Token(Token = "0x17000018")]
		private MinMaxCurveBlittable gravityModifierBlittable
		{
			[Address(RVA = "0x19DD080", Offset = "0x19DC280", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x600003B")]
			private set { } //Length: 66
		}

		[Token(Token = "0x1700000E")]
		public bool loop
		{
			[Address(RVA = "0x19DD1F0", Offset = "0x19DC3F0", Length = "0x42")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000031")]
			 set { } //Length: 66
		}

		[Token(Token = "0x1700001A")]
		public int maxParticles
		{
			[Address(RVA = "0x19DD240", Offset = "0x19DC440", Length = "0x40")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x600003D")]
			 set { } //Length: 64
		}

		[Token(Token = "0x17000019")]
		public ParticleSystemSimulationSpace simulationSpace
		{
			[Address(RVA = "0x19DD280", Offset = "0x19DC480", Length = "0x40")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.ParticleSimulationSpace"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x600003C")]
			 set { } //Length: 64
		}

		[Token(Token = "0x1700000F")]
		public MinMaxCurve startLifetime
		{
			[Address(RVA = "0x19DD360", Offset = "0x19DC560", Length = "0x118")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000032")]
			 set { } //Length: 280
		}

		[NativeName("StartLifetime")]
		[Token(Token = "0x17000010")]
		private MinMaxCurveBlittable startLifetimeBlittable
		{
			[Address(RVA = "0x19DD310", Offset = "0x19DC510", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000033")]
			private set { } //Length: 66
		}

		[Token(Token = "0x17000015")]
		public MinMaxCurve startRotation
		{
			[Address(RVA = "0x19DD520", Offset = "0x19DC720", Length = "0x118")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000038")]
			 set { } //Length: 280
		}

		[NativeName("StartRotationZ")]
		[Token(Token = "0x17000016")]
		private MinMaxCurveBlittable startRotationBlittable
		{
			[Address(RVA = "0x19DD4D0", Offset = "0x19DC6D0", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000039")]
			private set { } //Length: 66
		}

		[Token(Token = "0x17000013")]
		public MinMaxCurve startSize
		{
			[Address(RVA = "0x19DD6E0", Offset = "0x19DC8E0", Length = "0x118")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000036")]
			 set { } //Length: 280
		}

		[NativeName("StartSizeX")]
		[Token(Token = "0x17000014")]
		private MinMaxCurveBlittable startSizeBlittable
		{
			[Address(RVA = "0x19DD690", Offset = "0x19DC890", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000037")]
			private set { } //Length: 66
		}

		[Token(Token = "0x17000011")]
		public MinMaxCurve startSpeed
		{
			[Address(RVA = "0x19DD8A0", Offset = "0x19DCAA0", Length = "0x118")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000034")]
			 set { } //Length: 280
		}

		[NativeName("StartSpeed")]
		[Token(Token = "0x17000012")]
		private MinMaxCurveBlittable startSpeedBlittable
		{
			[Address(RVA = "0x19DD850", Offset = "0x19DCA50", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000035")]
			private set { } //Length: 66
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		internal MainModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x19DCFE0", Offset = "0x19DC1E0", Length = "0x43")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000030")]
		public void set_duration(float value) { }

		[Address(RVA = "0x19DD0D0", Offset = "0x19DC2D0", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003A")]
		public void set_gravityModifier(MinMaxCurve value) { }

		[Address(RVA = "0x19DD080", Offset = "0x19DC280", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x600003B")]
		private void set_gravityModifierBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD030", Offset = "0x19DC230", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000042")]
		private static void set_gravityModifierBlittable_Injected(ref MainModule _unity_self, in MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD1F0", Offset = "0x19DC3F0", Length = "0x42")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000031")]
		public void set_loop(bool value) { }

		[Address(RVA = "0x19DD240", Offset = "0x19DC440", Length = "0x40")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_MaxParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x600003D")]
		public void set_maxParticles(int value) { }

		[Address(RVA = "0x19DD280", Offset = "0x19DC480", Length = "0x40")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SimulationSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.ParticleSimulationSpace"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x600003C")]
		public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

		[Address(RVA = "0x19DD360", Offset = "0x19DC560", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000032")]
		public void set_startLifetime(MinMaxCurve value) { }

		[Address(RVA = "0x19DD310", Offset = "0x19DC510", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000033")]
		private void set_startLifetimeBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD2C0", Offset = "0x19DC4C0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003E")]
		private static void set_startLifetimeBlittable_Injected(ref MainModule _unity_self, in MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD520", Offset = "0x19DC720", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000038")]
		public void set_startRotation(MinMaxCurve value) { }

		[Address(RVA = "0x19DD4D0", Offset = "0x19DC6D0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000039")]
		private void set_startRotationBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD480", Offset = "0x19DC680", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000041")]
		private static void set_startRotationBlittable_Injected(ref MainModule _unity_self, in MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD6E0", Offset = "0x19DC8E0", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000036")]
		public void set_startSize(MinMaxCurve value) { }

		[Address(RVA = "0x19DD690", Offset = "0x19DC890", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000037")]
		private void set_startSizeBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD640", Offset = "0x19DC840", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000040")]
		private static void set_startSizeBlittable_Injected(ref MainModule _unity_self, in MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD8A0", Offset = "0x19DCAA0", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000034")]
		public void set_startSpeed(MinMaxCurve value) { }

		[Address(RVA = "0x19DD850", Offset = "0x19DCA50", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000035")]
		private void set_startSpeedBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DD800", Offset = "0x19DCA00", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003F")]
		private static void set_startSpeedBlittable_Injected(ref MainModule _unity_self, in MinMaxCurveBlittable value) { }

	}

	[Token(Token = "0x2000007")]
	internal struct MinMaxCurve
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000015")]
		internal ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x4000016")]
		internal float m_CurveMultiplier; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4000017")]
		internal AnimationCurve m_CurveMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000018")]
		internal AnimationCurve m_CurveMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000019")]
		internal float m_ConstantMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Token(Token = "0x400001A")]
		internal float m_ConstantMax; //Field offset: 0x1C

		[Address(RVA = "0x19DDB70", Offset = "0x19DCD70", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000058")]
		public MinMaxCurve(float constant) { }

		[Address(RVA = "0x19DDBC0", Offset = "0x19DCDC0", Length = "0x51")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000059")]
		public MinMaxCurve(float multiplier, AnimationCurve curve) { }

		[Address(RVA = "0x19DDB10", Offset = "0x19DCD10", Length = "0x60")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Lifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Speed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_StartRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600005A")]
		public MinMaxCurve(float min, float max) { }

		[Address(RVA = "0x19DDC20", Offset = "0x19DCE20", Length = "0x87")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_EmissionRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Gravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600005B")]
		public static MinMaxCurve op_Implicit(float constant) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	[Token(Token = "0x2000008")]
	public struct MinMaxCurveBlittable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001B")]
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400001C")]
		private float m_CurveMultiplier; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400001D")]
		private IntPtr m_CurveMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001E")]
		private IntPtr m_CurveMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001F")]
		internal float m_ConstantMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000020")]
		internal float m_ConstantMax; //Field offset: 0x1C

		[Address(RVA = "0x19DD9C0", Offset = "0x19DCBC0", Length = "0xA1")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600005D")]
		internal static MinMaxCurveBlittable FromMixMaxCurve(in MinMaxCurve minMaxCurve) { }

		[Address(RVA = "0x19DDA70", Offset = "0x19DCC70", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600005C")]
		public static MinMaxCurveBlittable op_Implicit(MinMaxCurve minMaxCurve) { }

	}

	[Token(Token = "0x2000009")]
	internal struct MinMaxGradient
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000021")]
		internal ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4000022")]
		internal Gradient m_GradientMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000023")]
		internal Gradient m_GradientMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000024")]
		internal Color m_ColorMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Token(Token = "0x4000025")]
		internal Color m_ColorMax; //Field offset: 0x28

		[Address(RVA = "0x19DDE00", Offset = "0x19DD000", Length = "0x54")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600005E")]
		public MinMaxGradient(Gradient gradient) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	[Token(Token = "0x200000A")]
	public struct MinMaxGradientBlittable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000026")]
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000027")]
		private IntPtr m_GradientMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000028")]
		private IntPtr m_GradientMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000029")]
		private Color m_ColorMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400002A")]
		private Color m_ColorMax; //Field offset: 0x28

		[Address(RVA = "0x19DDCB0", Offset = "0x19DCEB0", Length = "0xAA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000060")]
		internal static MinMaxGradientBlittable FromMixMaxGradient(in MinMaxGradient minMaxGradient) { }

		[Address(RVA = "0x19DDD60", Offset = "0x19DCF60", Length = "0x99")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600005F")]
		public static MinMaxGradientBlittable op_Implicit(MinMaxGradient minMaxGradient) { }

	}

	[RequiredByNativeCode("particleSystemParticle", Optional = True)]
	[Token(Token = "0x2000006")]
	internal struct Particle
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000004")]
		private Vector3 m_Position; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000005")]
		private Vector3 m_Velocity; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000006")]
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000007")]
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000008")]
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000009")]
		private Vector3 m_Rotation; //Field offset: 0x3C
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400000A")]
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x400000B")]
		private Vector3 m_StartSize; //Field offset: 0x54
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400000C")]
		private Color32 m_StartColor; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400000D")]
		private uint m_RandomSeed; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400000E")]
		private uint m_ParentRandomSeed; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400000F")]
		private float m_Lifetime; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000010")]
		private float m_StartLifetime; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000011")]
		private int m_MeshIndex; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000012")]
		private float m_EmitAccumulator0; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000013")]
		private float m_EmitAccumulator1; //Field offset: 0x7C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000014")]
		private uint m_Flags; //Field offset: 0x80

		[Token(Token = "0x1700002B")]
		public Vector3 angularVelocity3D
		{
			[Address(RVA = "0x19DF270", Offset = "0x19DE470", Length = "0x3F")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000057")]
			 set { } //Length: 63
		}

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
		[Token(Token = "0x17000022")]
		public float lifetime
		{
			[Address(RVA = "0x96ACC0", Offset = "0x969EC0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600004E")]
			 set { } //Length: 6
		}

		[Token(Token = "0x17000023")]
		public Vector3 position
		{
			[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600004F")]
			 set { } //Length: 15
		}

		[Token(Token = "0x17000028")]
		public uint randomSeed
		{
			[Address(RVA = "0x19DF2B0", Offset = "0x19DE4B0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000054")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000025")]
		public float remainingLifetime
		{
			[Address(RVA = "0x96ACC0", Offset = "0x969EC0", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000051")]
			 set { } //Length: 6
		}

		[Token(Token = "0x1700002A")]
		public Vector3 rotation3D
		{
			[Address(RVA = "0x19DF2C0", Offset = "0x19DE4C0", Length = "0x3F")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000056")]
			 set { } //Length: 63
		}

		[Token(Token = "0x17000027")]
		public Color32 startColor
		{
			[Address(RVA = "0x5ECD90", Offset = "0x5EBF90", Length = "0x4")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000053")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000026")]
		public float startLifetime
		{
			[Address(RVA = "0x19DF300", Offset = "0x19DE500", Length = "0x6")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000052")]
			 set { } //Length: 6
		}

		[Token(Token = "0x17000029")]
		public float startSize
		{
			[Address(RVA = "0x19DF310", Offset = "0x19DE510", Length = "0x11")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000055")]
			 set { } //Length: 17
		}

		[Token(Token = "0x17000024")]
		public Vector3 velocity
		{
			[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000050")]
			 set { } //Length: 16
		}

		[Address(RVA = "0x19DF270", Offset = "0x19DE470", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000057")]
		public void set_angularVelocity3D(Vector3 value) { }

		[Address(RVA = "0x96ACC0", Offset = "0x969EC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004E")]
		public void set_lifetime(float value) { }

		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		public void set_position(Vector3 value) { }

		[Address(RVA = "0x19DF2B0", Offset = "0x19DE4B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000054")]
		public void set_randomSeed(uint value) { }

		[Address(RVA = "0x96ACC0", Offset = "0x969EC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000051")]
		public void set_remainingLifetime(float value) { }

		[Address(RVA = "0x19DF2C0", Offset = "0x19DE4C0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000056")]
		public void set_rotation3D(Vector3 value) { }

		[Address(RVA = "0x5ECD90", Offset = "0x5EBF90", Length = "0x4")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000053")]
		public void set_startColor(Color32 value) { }

		[Address(RVA = "0x19DF300", Offset = "0x19DE500", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000052")]
		public void set_startLifetime(float value) { }

		[Address(RVA = "0x19DF310", Offset = "0x19DE510", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000055")]
		public void set_startSize(float value) { }

		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000050")]
		public void set_velocity(Vector3 value) { }

	}

	[Token(Token = "0x200000E")]
	internal struct RotationOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x17000030")]
		public MinMaxCurve z
		{
			[Address(RVA = "0x19DF3D0", Offset = "0x19DE5D0", Length = "0x118")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x600006A")]
			 set { } //Length: 280
		}

		[NativeName("Z")]
		[Token(Token = "0x17000031")]
		private MinMaxCurveBlittable zBlittable
		{
			[Address(RVA = "0x19DF380", Offset = "0x19DE580", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x600006B")]
			private set { } //Length: 66
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000069")]
		internal RotationOverLifetimeModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x19DF3D0", Offset = "0x19DE5D0", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006A")]
		public void set_z(MinMaxCurve value) { }

		[Address(RVA = "0x19DF380", Offset = "0x19DE580", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x600006B")]
		private void set_zBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DF330", Offset = "0x19DE530", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006C")]
		private static void set_zBlittable_Injected(ref RotationOverLifetimeModule _unity_self, in MinMaxCurveBlittable value) { }

	}

	[Token(Token = "0x2000005")]
	internal struct ShapeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000003")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x17000020")]
		public float angle
		{
			[Address(RVA = "0x19DF4F0", Offset = "0x19DE6F0", Length = "0x43")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x600004B")]
			 set { } //Length: 67
		}

		[Token(Token = "0x1700001F")]
		public float radius
		{
			[Address(RVA = "0x19DF540", Offset = "0x19DE740", Length = "0x43")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x600004A")]
			 set { } //Length: 67
		}

		[Token(Token = "0x17000021")]
		public Vector3 scale
		{
			[Address(RVA = "0x19DF5E0", Offset = "0x19DE7E0", Length = "0x42")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x600004C")]
			 set { } //Length: 66
		}

		[Token(Token = "0x1700001E")]
		public ParticleSystemShapeType shapeType
		{
			[Address(RVA = "0x19DF630", Offset = "0x19DE830", Length = "0x40")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000049")]
			 set { } //Length: 64
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000048")]
		internal ShapeModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x19DF4F0", Offset = "0x19DE6F0", Length = "0x43")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_ShapeAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x600004B")]
		public void set_angle(float value) { }

		[Address(RVA = "0x19DF540", Offset = "0x19DE740", Length = "0x43")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_ShapeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x600004A")]
		public void set_radius(float value) { }

		[Address(RVA = "0x19DF5E0", Offset = "0x19DE7E0", Length = "0x42")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_ShapeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x600004C")]
		public void set_scale(Vector3 value) { }

		[Address(RVA = "0x19DF590", Offset = "0x19DE790", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600004D")]
		private static void set_scale_Injected(ref ShapeModule _unity_self, in Vector3 value) { }

		[Address(RVA = "0x19DF630", Offset = "0x19DE830", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000049")]
		public void set_shapeType(ParticleSystemShapeType value) { }

	}

	[Token(Token = "0x200000D")]
	internal struct SizeOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x1700002E")]
		public MinMaxCurve size
		{
			[Address(RVA = "0x19DF710", Offset = "0x19DE910", Length = "0x168")]
			[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
			[CallsUnknownMethods(Count = 1)]
			[ContainsInvalidInstructions]
			[Token(Token = "0x6000066")]
			 set { } //Length: 360
		}

		[NativeName("X")]
		[Token(Token = "0x1700002F")]
		private MinMaxCurveBlittable sizeBlittable
		{
			[Address(RVA = "0x19DF6C0", Offset = "0x19DE8C0", Length = "0x42")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[CallsUnknownMethods(Count = 1)]
			[NativeThrows]
			[Token(Token = "0x6000067")]
			private set { } //Length: 66
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		internal SizeOverLifetimeModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x19DF710", Offset = "0x19DE910", Length = "0x168")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6000066")]
		public void set_size(MinMaxCurve value) { }

		[Address(RVA = "0x19DF6C0", Offset = "0x19DE8C0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeThrows]
		[Token(Token = "0x6000067")]
		private void set_sizeBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x19DF670", Offset = "0x19DE870", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000068")]
		private static void set_sizeBlittable_Injected(ref SizeOverLifetimeModule _unity_self, in MinMaxCurveBlittable value) { }

	}


	[Token(Token = "0x1700000A")]
	public ColorOverLifetimeModule colorOverLifetime
	{
		[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001D")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000008")]
	public EmissionModule emission
	{
		[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001B")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000003")]
	public bool isPaused
	{
		[Address(RVA = "0x19DEE30", Offset = "0x19DE030", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_IsPaused", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SyncJobs(false)->IsPaused")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000001")]
	public bool isPlaying
	{
		[Address(RVA = "0x19DEEF0", Offset = "0x19DE0F0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SyncJobs(false)->IsPlaying")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000002")]
	public bool isStopped
	{
		[Address(RVA = "0x19DEFB0", Offset = "0x19DE1B0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_IsStopped", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SyncJobs(false)->IsStopped")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000007")]
	public MainModule main
	{
		[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001A")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000004")]
	public int particleCount
	{
		[Address(RVA = "0x19DF070", Offset = "0x19DE270", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_ParticleCount", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SyncJobs(false)->GetParticleCount")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000C")]
	public RotationOverLifetimeModule rotationOverLifetime
	{
		[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001F")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000009")]
	public ShapeModule shape
	{
		[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700000B")]
	public SizeOverLifetimeModule sizeOverLifetime
	{
		[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000005")]
	public float time
	{
		[Address(RVA = "0x19DF130", Offset = "0x19DE330", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_Time", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SyncJobs(false)->GetSecPosition")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000006")]
	public float totalTime
	{
		[Address(RVA = "0x19DF1F0", Offset = "0x19DE3F0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_TotalTime", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SyncJobs(false)->GetTotalSecPosition")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000020")]
	public ParticleSystem() { }

	[Address(RVA = "0x19DE040", Offset = "0x19DD240", Length = "0x78")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "OnHide", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "UserCode_RpcClear", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "InvokeUserCode_RpcClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	public void Clear() { }

	[Address(RVA = "0x19DDFB0", Offset = "0x19DD1B0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	[Token(Token = "0x6000014")]
	public void Clear(bool withChildren) { }

	[Address(RVA = "0x19DDF60", Offset = "0x19DD160", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	private static void Clear_Injected(IntPtr _unity_self, bool withChildren) { }

	[Address(RVA = "0x19DE2D0", Offset = "0x19DD4D0", Length = "0x1EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	[Token(Token = "0x6000001")]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Address(RVA = "0x19DE4C0", Offset = "0x19DD6C0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	[Token(Token = "0x6000002")]
	public void Emit(Particle particle) { }

	[Address(RVA = "0x19DE550", Offset = "0x19DD750", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs()->EmitParticlesExternal")]
	[Token(Token = "0x6000018")]
	public void Emit(EmitParams emitParams, int count) { }

	[Address(RVA = "0x19DE240", Offset = "0x19DD440", Length = "0x83")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000016")]
	public void Emit(int count) { }

	[Address(RVA = "0x19DE1A0", Offset = "0x19DD3A0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	private static void Emit_Injected(IntPtr _unity_self, in EmitParams emitParams, int count) { }

	[Address(RVA = "0x19DE240", Offset = "0x19DD440", Length = "0x83")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeName("SyncJobs()->Emit")]
	[Token(Token = "0x6000017")]
	private void Emit_Internal(int count) { }

	[Address(RVA = "0x19DE200", Offset = "0x19DD400", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	private static void Emit_Internal_Injected(IntPtr _unity_self, int count) { }

	[Address(RVA = "0x19DE110", Offset = "0x19DD310", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs()->EmitParticleExternal")]
	[Token(Token = "0x6000019")]
	private void EmitOld_Internal(ref Particle particle) { }

	[Address(RVA = "0x19DE0C0", Offset = "0x19DD2C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	private static void EmitOld_Internal_Injected(IntPtr _unity_self, ref Particle particle) { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public ColorOverLifetimeModule get_colorOverLifetime() { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600001B")]
	public EmissionModule get_emission() { }

	[Address(RVA = "0x19DEE30", Offset = "0x19DE030", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_IsPaused", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs(false)->IsPaused")]
	[Token(Token = "0x6000005")]
	public bool get_isPaused() { }

	[Address(RVA = "0x19DEDF0", Offset = "0x19DDFF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000023")]
	private static bool get_isPaused_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19DEEF0", Offset = "0x19DE0F0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_IsPlaying", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs(false)->IsPlaying")]
	[Token(Token = "0x6000003")]
	public bool get_isPlaying() { }

	[Address(RVA = "0x19DEEB0", Offset = "0x19DE0B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19DEFB0", Offset = "0x19DE1B0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_IsStopped", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs(false)->IsStopped")]
	[Token(Token = "0x6000004")]
	public bool get_isStopped() { }

	[Address(RVA = "0x19DEF70", Offset = "0x19DE170", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	private static bool get_isStopped_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	public MainModule get_main() { }

	[Address(RVA = "0x19DF070", Offset = "0x19DE270", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_ParticleCount", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs(false)->GetParticleCount")]
	[Token(Token = "0x6000006")]
	public int get_particleCount() { }

	[Address(RVA = "0x19DF030", Offset = "0x19DE230", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	private static int get_particleCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public ShapeModule get_shape() { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600001E")]
	public SizeOverLifetimeModule get_sizeOverLifetime() { }

	[Address(RVA = "0x19DF130", Offset = "0x19DE330", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_Time", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs(false)->GetSecPosition")]
	[Token(Token = "0x6000007")]
	public float get_time() { }

	[Address(RVA = "0x19DF0F0", Offset = "0x19DE2F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	private static float get_time_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19DF1F0", Offset = "0x19DE3F0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "get_TotalTime", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SyncJobs(false)->GetTotalSecPosition")]
	[Token(Token = "0x6000008")]
	public float get_totalTime() { }

	[Address(RVA = "0x19DF1B0", Offset = "0x19DE3B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	private static float get_totalTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19DE640", Offset = "0x19DD840", Length = "0x78")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "Pause", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "UserCode_RpcPause", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "InvokeUserCode_RpcPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public void Pause() { }

	[Address(RVA = "0x19DE6C0", Offset = "0x19DD8C0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	[Token(Token = "0x600000F")]
	public void Pause(bool withChildren) { }

	[Address(RVA = "0x19DE5F0", Offset = "0x19DD7F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	private static void Pause_Injected(IntPtr _unity_self, bool withChildren) { }

	[Address(RVA = "0x19DE7A0", Offset = "0x19DD9A0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	[Token(Token = "0x600000D")]
	public void Play(bool withChildren) { }

	[Address(RVA = "0x19DE830", Offset = "0x19DDA30", Length = "0x78")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "Play", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "UserCode_RpcPlay", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "InvokeUserCode_RpcPlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public void Play() { }

	[Address(RVA = "0x19DE750", Offset = "0x19DD950", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	private static void Play_Injected(IntPtr _unity_self, bool withChildren) { }

	[Address(RVA = "0x19DE920", Offset = "0x19DDB20", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	[Token(Token = "0x6000009")]
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	[Address(RVA = "0x19DEB20", Offset = "0x19DDD20", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	public void Simulate(float t, bool withChildren, bool restart) { }

	[Address(RVA = "0x19DE9E0", Offset = "0x19DDBE0", Length = "0x92")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "Simulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "UserCode_RpcSimulate__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "InvokeUserCode_RpcSimulate__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public void Simulate(float t) { }

	[Address(RVA = "0x19DEA80", Offset = "0x19DDC80", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public void Simulate(float t, bool withChildren) { }

	[Address(RVA = "0x19DE8B0", Offset = "0x19DDAB0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	private static void Simulate_Injected(IntPtr _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	[Address(RVA = "0x19DECC0", Offset = "0x19DDEC0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000012")]
	public void Stop(bool withChildren) { }

	[Address(RVA = "0x19DEC30", Offset = "0x19DDE30", Length = "0x80")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "OnHide", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "UserCode_RpcStop", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "InvokeUserCode_RpcStop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public void Stop() { }

	[Address(RVA = "0x19DED50", Offset = "0x19DDF50", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	[Token(Token = "0x6000011")]
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	[Address(RVA = "0x19DEBD0", Offset = "0x19DDDD0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002A")]
	private static void Stop_Injected(IntPtr _unity_self, bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

}

