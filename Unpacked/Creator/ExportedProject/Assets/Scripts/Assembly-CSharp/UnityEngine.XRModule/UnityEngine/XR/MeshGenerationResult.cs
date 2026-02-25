namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000019")]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000068")]
	private readonly MeshId <MeshId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000069")]
	private readonly Mesh <Mesh>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006A")]
	private readonly MeshCollider <MeshCollider>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400006B")]
	private readonly MeshGenerationStatus <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400006C")]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400006D")]
	private readonly ulong <Timestamp>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400006E")]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400006F")]
	private readonly Quaternion <Rotation>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000070")]
	private readonly Vector3 <Scale>k__BackingField; //Field offset: 0x4C

	[Token(Token = "0x17000011")]
	public MeshVertexAttributes Attributes
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000036")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public Mesh Mesh
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000033")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000F")]
	public MeshCollider MeshCollider
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000034")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000D")]
	public MeshId MeshId
	{
		[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000032")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000012")]
	public Vector3 Position
	{
		[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000037")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000013")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000038")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000014")]
	public Vector3 Scale
	{
		[Address(RVA = "0x1245810", Offset = "0x1244A10", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000039")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000010")]
	public MeshGenerationStatus Status
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000035")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1D01AB0", Offset = "0x1D00CB0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(MeshGenerationResult), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationResult)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600003A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1D01B90", Offset = "0x1D00D90", Length = "0x206")]
	[CalledBy(Type = typeof(MeshGenerationResult), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003B")]
	public override bool Equals(MeshGenerationResult other) { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000036")]
	public MeshVertexAttributes get_Attributes() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000033")]
	public Mesh get_Mesh() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000034")]
	public MeshCollider get_MeshCollider() { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000032")]
	public MeshId get_MeshId() { }

	[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000037")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000038")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x1245810", Offset = "0x1244A10", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000039")]
	public Vector3 get_Scale() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000035")]
	public MeshGenerationStatus get_Status() { }

	[Address(RVA = "0x1D01DA0", Offset = "0x1D00FA0", Length = "0x254")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600003C")]
	public virtual int GetHashCode() { }

}

