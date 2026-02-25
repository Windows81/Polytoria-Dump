namespace Mirror;

[Token(Token = "0x2000038")]
public struct TransformSnapshot : Snapshot
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000127")]
	private double <remoteTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000128")]
	private double <localTime>k__BackingField; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000129")]
	public Vector3 position; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400012A")]
	public Quaternion rotation; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400012B")]
	public Vector3 scale; //Field offset: 0x2C

	[Token(Token = "0x1700001A")]
	public override double localTime
	{
		[Address(RVA = "0xE304A0", Offset = "0xE2F6A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60001E8")]
		 get { } //Length: 6
		[Address(RVA = "0x12466E0", Offset = "0x12458E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E9")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000019")]
	public override double remoteTime
	{
		[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 5
		[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E7")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x12466A0", Offset = "0x12458A0", Length = "0x3B")]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "OnClientToServerDeltaSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "OnServerToClientDeltaSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60001EA")]
	public TransformSnapshot(double remoteTime, double localTime, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Address(RVA = "0xE304A0", Offset = "0xE2F6A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60001E8")]
	public override double get_localTime() { }

	[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x60001E6")]
	public override double get_remoteTime() { }

	[Address(RVA = "0x1246280", Offset = "0x1245480", Length = "0x169")]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "UpdateServerInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "UpdateClientInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateServerInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateClientInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "UpdateServer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "UpdateClient", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "SlerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001EB")]
	public static TransformSnapshot Interpolate(TransformSnapshot from, TransformSnapshot to, double t) { }

	[Address(RVA = "0x12466E0", Offset = "0x12458E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E9")]
	public override void set_localTime(double value) { }

	[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E7")]
	public override void set_remoteTime(double value) { }

	[Address(RVA = "0x12463F0", Offset = "0x12455F0", Length = "0x2A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001EC")]
	public virtual string ToString() { }

}

