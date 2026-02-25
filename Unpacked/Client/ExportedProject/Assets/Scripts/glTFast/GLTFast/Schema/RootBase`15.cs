namespace GLTFast.Schema;

[Token(Token = "0x20000C7")]
public abstract class RootBase5 : RootBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BB")]
	public TAccessor[] accessors; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BC")]
	public TAnimation[] animations; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BD")]
	public TBuffer[] buffers; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BE")]
	public TBufferView[] bufferViews; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BF")]
	public TCamera[] cameras; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C0")]
	public TImage[] images; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C1")]
	public TMaterial[] materials; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C2")]
	public TNode[] nodes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C3")]
	public TSampler[] samplers; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C4")]
	public TScene[] scenes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C5")]
	public TSkin[] skins; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C6")]
	public TTexture[] textures; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C7")]
	public TExtensions extensions; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C8")]
	public TMesh[] meshes; //Field offset: 0x0

	[Token(Token = "0x17000065")]
	public virtual IReadOnlyList<AccessorBase> Accessors
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000066")]
	public virtual IReadOnlyList<AnimationBase> Animations
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600023E")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000067")]
	public virtual IReadOnlyList<Buffer> Buffers
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000068")]
	public virtual IReadOnlyList<BufferViewBase> BufferViews
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000240")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000069")]
	public virtual IReadOnlyList<CameraBase> Cameras
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000241")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000071")]
	public virtual RootExtensions Extensions
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000249")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700006A")]
	public virtual IReadOnlyList<Image> Images
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000242")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006B")]
	public virtual IReadOnlyList<MaterialBase> Materials
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000243")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000072")]
	public virtual IReadOnlyList<MeshBase> Meshes
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600024B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700006C")]
	public virtual IReadOnlyList<NodeBase> Nodes
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000244")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006D")]
	public virtual IReadOnlyList<Sampler> Samplers
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000245")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006E")]
	public virtual IReadOnlyList<Scene> Scenes
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000246")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006F")]
	public virtual IReadOnlyList<Skin> Skins
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000247")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000070")]
	public virtual IReadOnlyList<TextureBase> Textures
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000248")]
		 get { } //Length: 8
	}

	[Address(RVA = "0xF0D3E0", Offset = "0xF0C5E0", Length = "0x7")]
	[CalledBy(Type = typeof(Root), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024C")]
	protected RootBase`15() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023D")]
	public virtual IReadOnlyList<AccessorBase> get_Accessors() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600023E")]
	public virtual IReadOnlyList<AnimationBase> get_Animations() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023F")]
	public virtual IReadOnlyList<Buffer> get_Buffers() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000240")]
	public virtual IReadOnlyList<BufferViewBase> get_BufferViews() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000241")]
	public virtual IReadOnlyList<CameraBase> get_Cameras() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000249")]
	public virtual RootExtensions get_Extensions() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000242")]
	public virtual IReadOnlyList<Image> get_Images() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000243")]
	public virtual IReadOnlyList<MaterialBase> get_Materials() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024B")]
	public virtual IReadOnlyList<MeshBase> get_Meshes() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000244")]
	public virtual IReadOnlyList<NodeBase> get_Nodes() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000245")]
	public virtual IReadOnlyList<Sampler> get_Samplers() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000246")]
	public virtual IReadOnlyList<Scene> get_Scenes() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000247")]
	public virtual IReadOnlyList<Skin> get_Skins() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000248")]
	public virtual IReadOnlyList<TextureBase> get_Textures() { }

	[Address(RVA = "0xF0D3D0", Offset = "0xF0C5D0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024A")]
	internal virtual void UnsetExtensions() { }

}

