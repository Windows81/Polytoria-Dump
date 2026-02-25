namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000009")]
public sealed class Rigidbody2D : Component
{

	[Token(Token = "0x1700000C")]
	public float angularDamping
	{
		[Address(RVA = "0x19E2540", Offset = "0x19E1740", Length = "0x76")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		 get { } //Length: 118
		[Address(RVA = "0x19E2A70", Offset = "0x19E1C70", Length = "0x86")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003C")]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("angularDrag has been deprecated. Please use angularDamping. (UnityUpgradable) -> angularDamping", False)]
	[Token(Token = "0x17000011")]
	public float angularDrag
	{
		[Address(RVA = "0x19E2540", Offset = "0x19E1740", Length = "0x76")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000045")]
		 get { } //Length: 118
		[Address(RVA = "0x19E2A70", Offset = "0x19E1C70", Length = "0x86")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000046")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000A")]
	public float angularVelocity
	{
		[Address(RVA = "0x19E2600", Offset = "0x19E1800", Length = "0x76")]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendVelocity", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000037")]
		 get { } //Length: 118
		[Address(RVA = "0x19E2B50", Offset = "0x19E1D50", Length = "0x86")]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnAngularVelocityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000038")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000E")]
	public RigidbodyType2D bodyType
	{
		[Address(RVA = "0x19E26C0", Offset = "0x19E18C0", Length = "0x76")]
		[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003F")]
		 get { } //Length: 118
		[Address(RVA = "0x19E2C20", Offset = "0x19E1E20", Length = "0x83")]
		[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnStopServer", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnStopClient", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnStopServer", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnStopClient", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("SetBodyType_Binding")]
		[Token(Token = "0x6000040")]
		 set { } //Length: 131
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("drag has been deprecated. Please use linearDamping. (UnityUpgradable) -> linearDamping", False)]
	[Token(Token = "0x17000010")]
	public float drag
	{
		[Address(RVA = "0x19E2740", Offset = "0x19E1940", Length = "0x76")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		 get { } //Length: 118
		[Address(RVA = "0x19E2CB0", Offset = "0x19E1EB0", Length = "0x86")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000044")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000D")]
	public float gravityScale
	{
		[Address(RVA = "0x19E2800", Offset = "0x19E1A00", Length = "0x76")]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendRigidBodySettings", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003D")]
		 get { } //Length: 118
		[Address(RVA = "0x19E2D90", Offset = "0x19E1F90", Length = "0x86")]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnGravityScaleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003E")]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("isKinematic has been deprecated. Please use bodyType.", False)]
	[Token(Token = "0x1700000F")]
	public bool isKinematic
	{
		[Address(RVA = "0x19E2880", Offset = "0x19E1A80", Length = "0x7C")]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendRigidBodySettings", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000041")]
		 get { } //Length: 124
		[Address(RVA = "0x19E2E20", Offset = "0x19E2020", Length = "0x84")]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnIsKinematicChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000042")]
		 set { } //Length: 132
	}

	[Token(Token = "0x1700000B")]
	public float linearDamping
	{
		[Address(RVA = "0x19E2740", Offset = "0x19E1940", Length = "0x76")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		 get { } //Length: 118
		[Address(RVA = "0x19E2CB0", Offset = "0x19E1EB0", Length = "0x86")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000009")]
	public Vector2 linearVelocity
	{
		[Address(RVA = "0x19E2990", Offset = "0x19E1B90", Length = "0x87")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		 get { } //Length: 135
		[Address(RVA = "0x19E2F50", Offset = "0x19E2150", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000036")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000007")]
	public Vector2 position
	{
		[Address(RVA = "0x19E3030", Offset = "0x19E2230", Length = "0x80")]
		[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000033")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000008")]
	public float rotation
	{
		[Address(RVA = "0x19E3110", Offset = "0x19E2310", Length = "0x86")]
		[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000034")]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("velocity has been deprecated. Please use linearVelocity. (UnityUpgradable) -> linearVelocity", False)]
	[Token(Token = "0x17000012")]
	public Vector2 velocity
	{
		[Address(RVA = "0x19E2990", Offset = "0x19E1B90", Length = "0x87")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000047")]
		 get { } //Length: 135
		[Address(RVA = "0x19E31A0", Offset = "0x19E23A0", Length = "0x128")]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnVelocityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Physics", Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<ContactPairHeader>+ReadOnly<ContactPairHeader>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6000048")]
		 set { } //Length: 296
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000049")]
	public Rigidbody2D() { }

	[Address(RVA = "0x19E2540", Offset = "0x19E1740", Length = "0x76")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public float get_angularDamping() { }

	[Address(RVA = "0x19E2500", Offset = "0x19E1700", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	private static float get_angularDamping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E2540", Offset = "0x19E1740", Length = "0x76")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000045")]
	public float get_angularDrag() { }

	[Address(RVA = "0x19E2600", Offset = "0x19E1800", Length = "0x76")]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendVelocity", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	public float get_angularVelocity() { }

	[Address(RVA = "0x19E25C0", Offset = "0x19E17C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	private static float get_angularVelocity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E26C0", Offset = "0x19E18C0", Length = "0x76")]
	[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	public RigidbodyType2D get_bodyType() { }

	[Address(RVA = "0x19E2680", Offset = "0x19E1880", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	private static RigidbodyType2D get_bodyType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E2740", Offset = "0x19E1940", Length = "0x76")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public float get_drag() { }

	[Address(RVA = "0x19E2800", Offset = "0x19E1A00", Length = "0x76")]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendRigidBodySettings", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	public float get_gravityScale() { }

	[Address(RVA = "0x19E27C0", Offset = "0x19E19C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	private static float get_gravityScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E2880", Offset = "0x19E1A80", Length = "0x7C")]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendRigidBodySettings", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000041")]
	public bool get_isKinematic() { }

	[Address(RVA = "0x19E2740", Offset = "0x19E1940", Length = "0x76")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public float get_linearDamping() { }

	[Address(RVA = "0x19E2900", Offset = "0x19E1B00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000050")]
	private static float get_linearDamping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19E2990", Offset = "0x19E1B90", Length = "0x87")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public Vector2 get_linearVelocity() { }

	[Address(RVA = "0x19E2940", Offset = "0x19E1B40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x19E2990", Offset = "0x19E1B90", Length = "0x87")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000047")]
	public Vector2 get_velocity() { }

	[Address(RVA = "0x19E2A70", Offset = "0x19E1C70", Length = "0x86")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003C")]
	public void set_angularDamping(float value) { }

	[Address(RVA = "0x19E2A20", Offset = "0x19E1C20", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	private static void set_angularDamping_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E2A70", Offset = "0x19E1C70", Length = "0x86")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000046")]
	public void set_angularDrag(float value) { }

	[Address(RVA = "0x19E2B50", Offset = "0x19E1D50", Length = "0x86")]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnAngularVelocityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	public void set_angularVelocity(float value) { }

	[Address(RVA = "0x19E2B00", Offset = "0x19E1D00", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004F")]
	private static void set_angularVelocity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E2C20", Offset = "0x19E1E20", Length = "0x83")]
	[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnStopServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnStopClient", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnStopServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnStopClient", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetBodyType_Binding")]
	[Token(Token = "0x6000040")]
	public void set_bodyType(RigidbodyType2D value) { }

	[Address(RVA = "0x19E2BE0", Offset = "0x19E1DE0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000057")]
	private static void set_bodyType_Injected(IntPtr _unity_self, RigidbodyType2D value) { }

	[Address(RVA = "0x19E2CB0", Offset = "0x19E1EB0", Length = "0x86")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	public void set_drag(float value) { }

	[Address(RVA = "0x19E2D90", Offset = "0x19E1F90", Length = "0x86")]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnGravityScaleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	public void set_gravityScale(float value) { }

	[Address(RVA = "0x19E2D40", Offset = "0x19E1F40", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000055")]
	private static void set_gravityScale_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E2E20", Offset = "0x19E2020", Length = "0x84")]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnIsKinematicChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	public void set_isKinematic(bool value) { }

	[Address(RVA = "0x19E2CB0", Offset = "0x19E1EB0", Length = "0x86")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	public void set_linearDamping(float value) { }

	[Address(RVA = "0x19E2EB0", Offset = "0x19E20B0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000051")]
	private static void set_linearDamping_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E2F50", Offset = "0x19E2150", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	public void set_linearVelocity(Vector2 value) { }

	[Address(RVA = "0x19E2F00", Offset = "0x19E2100", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	private static void set_linearVelocity_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x19E3030", Offset = "0x19E2230", Length = "0x80")]
	[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x19E2FE0", Offset = "0x19E21E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	private static void set_position_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x19E3110", Offset = "0x19E2310", Length = "0x86")]
	[CalledBy(Type = "Mirror.NetworkRigidbodyReliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRigidbodyUnreliable2D", Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	public void set_rotation(float value) { }

	[Address(RVA = "0x19E30C0", Offset = "0x19E22C0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	private static void set_rotation_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19E31A0", Offset = "0x19E23A0", Length = "0x128")]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnVelocityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Physics", Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<ContactPairHeader>+ReadOnly<ContactPairHeader>"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000048")]
	public void set_velocity(Vector2 value) { }

}

