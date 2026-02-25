namespace GLTFast;

[Token(Token = "0x2000041")]
public class InstantiationSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000162")]
	[Tooltip("Filter component instantiation based on type")]
	private ComponentType mask; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000163")]
	[Tooltip("Instantiated objects will be assigned to this layer")]
	private int layer; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000164")]
	[Tooltip("When checked, calculate the mesh bounds on every frame, even when the mesh is not visible")]
	private bool skinUpdateWhenOffscreen; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000165")]
	[Tooltip("Light intensity values are multiplied by this factor")]
	private float lightIntensityFactor; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000166")]
	[Tooltip("Scene object creation method. Determines whether or when a GameObject/Entity representing the scene should get created.")]
	private SceneObjectCreation sceneObjectCreation; //Field offset: 0x20

	[Token(Token = "0x17000022")]
	public int Layer
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000123")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public float LightIntensityFactor
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000125")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000021")]
	public ComponentType Mask
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000122")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000025")]
	public SceneObjectCreation SceneObjectCreation
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000126")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000023")]
	public bool SkinUpdateWhenOffscreen
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000124")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1075A80", Offset = "0x1074C80", Length = "0x20")]
	[CalledBy(Type = typeof(GameObjectBoundsInstantiator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfReadable), typeof(Transform), typeof(ICodeLogger), typeof(InstantiationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameObjectInstantiator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfReadable), typeof(Transform), typeof(ICodeLogger), typeof(InstantiationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfAsset), Member = "GetDefaultInstantiator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICodeLogger)}, ReturnType = typeof(IInstantiator))]
	[CalledBy(Type = typeof(GltfBoundsAsset), Member = "GetDefaultInstantiator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICodeLogger)}, ReturnType = typeof(IInstantiator))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<InstantiateMainSceneAsync>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000127")]
	public InstantiationSettings() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000123")]
	public int get_Layer() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	public float get_LightIntensityFactor() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000122")]
	public ComponentType get_Mask() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000126")]
	public SceneObjectCreation get_SceneObjectCreation() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000124")]
	public bool get_SkinUpdateWhenOffscreen() { }

}

