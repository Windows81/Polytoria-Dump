namespace GLTFast;

[Token(Token = "0x200001F")]
public abstract class GltfImportBase : GltfImportBase, IGltfReadable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007D")]
	private TRoot m_Root; //Field offset: 0x0

	[Token(Token = "0x17000015")]
	protected virtual RootBase Root
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007D")]
		 get { } //Length: 8
		[Address(RVA = "0xC58D50", Offset = "0xC57F50", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x600007E")]
		 set { } //Length: 227
	}

	[Address(RVA = "0xC58CD0", Offset = "0xC57ED0", Length = "0x7F")]
	[CalledBy(Type = "GLTFast.GltfAssetBase+<Load>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImport), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GltfImportBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public GltfImportBase`1(IDownloadProvider downloadProvider = null, IDeferAgent deferAgent = null, IMaterialGenerator materialGenerator = null, ICodeLogger logger = null) { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	protected virtual RootBase get_Root() { }

	[Address(RVA = "0xC58D50", Offset = "0xC57F50", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	protected virtual void set_Root(RootBase value) { }

}

