namespace GLTFast.Schema;

[Token(Token = "0x20000C8")]
public abstract class RootBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C9")]
	public String[] extensionsUsed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002CA")]
	public String[] extensionsRequired; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002CB")]
	public int scene; //Field offset: 0x20

	[Token(Token = "0x17000073")]
	public abstract IReadOnlyList<AccessorBase> Accessors
	{
		[Token(Token = "0x600024D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000074")]
	public abstract IReadOnlyList<AnimationBase> Animations
	{
		[Token(Token = "0x600024E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000075")]
	public abstract IReadOnlyList<Buffer> Buffers
	{
		[Token(Token = "0x600024F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000076")]
	public abstract IReadOnlyList<BufferViewBase> BufferViews
	{
		[Token(Token = "0x6000250")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000077")]
	public abstract IReadOnlyList<CameraBase> Cameras
	{
		[Token(Token = "0x6000251")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000080")]
	public abstract RootExtensions Extensions
	{
		[Token(Token = "0x600025A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000081")]
	public bool HasAnimation
	{
		[Address(RVA = "0x1079D60", Offset = "0x1078F60", Length = "0x82")]
		[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600025C")]
		 get { } //Length: 130
	}

	[Token(Token = "0x17000078")]
	public abstract IReadOnlyList<Image> Images
	{
		[Token(Token = "0x6000252")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000079")]
	public abstract IReadOnlyList<MaterialBase> Materials
	{
		[Token(Token = "0x6000253")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007A")]
	public abstract IReadOnlyList<MeshBase> Meshes
	{
		[Token(Token = "0x6000254")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007B")]
	public abstract IReadOnlyList<NodeBase> Nodes
	{
		[Token(Token = "0x6000255")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007C")]
	public abstract IReadOnlyList<Sampler> Samplers
	{
		[Token(Token = "0x6000256")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007D")]
	public abstract IReadOnlyList<Scene> Scenes
	{
		[Token(Token = "0x6000257")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007E")]
	public abstract IReadOnlyList<Skin> Skins
	{
		[Token(Token = "0x6000258")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007F")]
	public abstract IReadOnlyList<TextureBase> Textures
	{
		[Token(Token = "0x6000259")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1079D50", Offset = "0x1078F50", Length = "0xE")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000260")]
	protected RootBase() { }

	[Token(Token = "0x600024D")]
	public abstract IReadOnlyList<AccessorBase> get_Accessors() { }

	[Token(Token = "0x600024E")]
	public abstract IReadOnlyList<AnimationBase> get_Animations() { }

	[Token(Token = "0x600024F")]
	public abstract IReadOnlyList<Buffer> get_Buffers() { }

	[Token(Token = "0x6000250")]
	public abstract IReadOnlyList<BufferViewBase> get_BufferViews() { }

	[Token(Token = "0x6000251")]
	public abstract IReadOnlyList<CameraBase> get_Cameras() { }

	[Token(Token = "0x600025A")]
	public abstract RootExtensions get_Extensions() { }

	[Address(RVA = "0x1079D60", Offset = "0x1078F60", Length = "0x82")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025C")]
	public bool get_HasAnimation() { }

	[Token(Token = "0x6000252")]
	public abstract IReadOnlyList<Image> get_Images() { }

	[Token(Token = "0x6000253")]
	public abstract IReadOnlyList<MaterialBase> get_Materials() { }

	[Token(Token = "0x6000254")]
	public abstract IReadOnlyList<MeshBase> get_Meshes() { }

	[Token(Token = "0x6000255")]
	public abstract IReadOnlyList<NodeBase> get_Nodes() { }

	[Token(Token = "0x6000256")]
	public abstract IReadOnlyList<Sampler> get_Samplers() { }

	[Token(Token = "0x6000257")]
	public abstract IReadOnlyList<Scene> get_Scenes() { }

	[Token(Token = "0x6000258")]
	public abstract IReadOnlyList<Skin> get_Skins() { }

	[Token(Token = "0x6000259")]
	public abstract IReadOnlyList<TextureBase> get_Textures() { }

	[Address(RVA = "0x10795B0", Offset = "0x10787B0", Length = "0x280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x600025F")]
	public override void JsonUtilityCleanup() { }

	[Address(RVA = "0x1078EE0", Offset = "0x10780E0", Length = "0x6C9")]
	[CalledBy(Type = typeof(GltfJsonUtilityParser), Member = "ParseJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RootBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 22)]
	[Token(Token = "0x600025E")]
	internal void JsonUtilityCleanupAgainstSecondParse(Root fakeRoot) { }

	[Address(RVA = "0x1079840", Offset = "0x1078A40", Length = "0x507")]
	[CalledBy(Type = typeof(GltfJsonUtilityParser), Member = "ParseJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RootBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 14)]
	[Token(Token = "0x600025D")]
	internal bool JsonUtilitySecondParseRequired() { }

	[Token(Token = "0x600025B")]
	internal abstract void UnsetExtensions() { }

}

