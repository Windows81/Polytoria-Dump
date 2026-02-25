namespace GLTFast;

[Token(Token = "0x200004C")]
internal abstract class PrimitiveCreateContextBase
{
	[Token(Token = "0x400018A")]
	public const MeshUpdateFlags defaultMeshUpdateFlags = 15; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400018B")]
	protected string m_MeshName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400018C")]
	protected Int32[] m_Materials; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400018D")]
	private readonly int <MeshIndex>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400018E")]
	private readonly int <PrimitiveIndex>k__BackingField; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400018F")]
	public MorphTargetsContext morphTargetsContext; //Field offset: 0x28

	[Token(Token = "0x17000029")]
	public abstract bool IsCompleted
	{
		[Token(Token = "0x6000143")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000027")]
	public int MeshIndex
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000141")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000028")]
	public int PrimitiveIndex
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000142")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1078B70", Offset = "0x1077D70", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000144")]
	protected PrimitiveCreateContextBase(int meshIndex, int primitiveIndex, int subMeshCount, string meshName) { }

	[Token(Token = "0x6000146")]
	public abstract Task<Nullable`1<MeshResult>> CreatePrimitive() { }

	[Token(Token = "0x6000143")]
	public abstract bool get_IsCompleted() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000141")]
	public int get_MeshIndex() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000142")]
	public int get_PrimitiveIndex() { }

	[Address(RVA = "0x1078B40", Offset = "0x1077D40", Length = "0x2B")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000145")]
	public void SetMaterial(int subMesh, int materialIndex) { }

}

