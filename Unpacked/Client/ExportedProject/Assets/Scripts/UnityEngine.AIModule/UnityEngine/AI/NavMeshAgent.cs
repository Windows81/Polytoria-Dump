namespace UnityEngine.AI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshAgent.html")]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[Token(Token = "0x2000003")]
public sealed class NavMeshAgent : Behaviour
{

	[Token(Token = "0x17000008")]
	public float acceleration
	{
		[Address(RVA = "0x18FFC20", Offset = "0x18FEE20", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000014")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000007")]
	public float angularSpeed
	{
		[Address(RVA = "0x18FFD00", Offset = "0x18FEF00", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000013")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000004")]
	public float baseOffset
	{
		[Address(RVA = "0x18FFDE0", Offset = "0x18FEFE0", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000010")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000005")]
	public bool hasPath
	{
		[Address(RVA = "0x18FF8E0", Offset = "0x18FEAE0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("HasPath")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000003")]
	public float remainingDistance
	{
		[Address(RVA = "0x18FF9A0", Offset = "0x18FEBA0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationDistance", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationReached", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000006")]
	public float speed
	{
		[Address(RVA = "0x18FFEC0", Offset = "0x18FF0C0", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "set_WalkSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000012")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000001")]
	public float stoppingDistance
	{
		[Address(RVA = "0x18FFA60", Offset = "0x18FEC60", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000C")]
		 get { } //Length: 118
		[Address(RVA = "0x18FFFA0", Offset = "0x18FF1A0", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000002")]
	public Vector3 velocity
	{
		[Address(RVA = "0x18FFB30", Offset = "0x18FED30", Length = "0x90")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000E")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	public NavMeshAgent() { }

	[Address(RVA = "0x18FF8E0", Offset = "0x18FEAE0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("HasPath")]
	[Token(Token = "0x6000011")]
	public bool get_hasPath() { }

	[Address(RVA = "0x18FF8A0", Offset = "0x18FEAA0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001C")]
	private static bool get_hasPath_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x18FF9A0", Offset = "0x18FEBA0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationDistance", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationReached", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	public float get_remainingDistance() { }

	[Address(RVA = "0x18FF960", Offset = "0x18FEB60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	private static float get_remainingDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x18FFA60", Offset = "0x18FEC60", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public float get_stoppingDistance() { }

	[Address(RVA = "0x18FFA20", Offset = "0x18FEC20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000017")]
	private static float get_stoppingDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x18FFB30", Offset = "0x18FED30", Length = "0x90")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public Vector3 get_velocity() { }

	[Address(RVA = "0x18FFAE0", Offset = "0x18FECE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x18FFC20", Offset = "0x18FEE20", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	public void set_acceleration(float value) { }

	[Address(RVA = "0x18FFBD0", Offset = "0x18FEDD0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001F")]
	private static void set_acceleration_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x18FFD00", Offset = "0x18FEF00", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public void set_angularSpeed(float value) { }

	[Address(RVA = "0x18FFCB0", Offset = "0x18FEEB0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001E")]
	private static void set_angularSpeed_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x18FFDE0", Offset = "0x18FEFE0", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public void set_baseOffset(float value) { }

	[Address(RVA = "0x18FFD90", Offset = "0x18FEF90", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	private static void set_baseOffset_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x18FFEC0", Offset = "0x18FF0C0", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "set_WalkSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000012")]
	public void set_speed(float value) { }

	[Address(RVA = "0x18FFE70", Offset = "0x18FF070", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x18FFFA0", Offset = "0x18FF1A0", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnNetworkStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "<OnNetworkStart>g__onLoad|95_0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public void set_stoppingDistance(float value) { }

	[Address(RVA = "0x18FFF50", Offset = "0x18FF150", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	private static void set_stoppingDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x18FF810", Offset = "0x18FEA10", Length = "0x85")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "SetNavDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public bool SetDestination(Vector3 target) { }

	[Address(RVA = "0x18FF7C0", Offset = "0x18FE9C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	private static bool SetDestination_Injected(IntPtr _unity_self, in Vector3 target) { }

}

