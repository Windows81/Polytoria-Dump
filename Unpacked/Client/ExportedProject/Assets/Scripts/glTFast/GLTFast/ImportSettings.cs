namespace GLTFast;

[Token(Token = "0x2000040")]
public class ImportSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400015C")]
	[Tooltip("Controls how node names are created.")]
	private NameImportMethod nodeNameMethod; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x400015D")]
	[Tooltip("Target animation system.")]
	private AnimationMethod animationMethod; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400015E")]
	[Tooltip("Controls if mipmaps are created for imported textures.")]
	private bool generateMipMaps; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x400015F")]
	[Tooltip("Minification filter mode fallback if no mode was provided.")]
	private MinFilterMode defaultMinFilterMode; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000160")]
	[Tooltip("Magnification filter mode fallback if no mode was provided.")]
	private MagFilterMode defaultMagFilterMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000161")]
	[Tooltip("Anisotropic filtering level for imported textures.")]
	private int anisotropicFilterLevel; //Field offset: 0x24

	[Token(Token = "0x1700001C")]
	public AnimationMethod AnimationMethod
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	public int AnisotropicFilterLevel
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000120")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700001F")]
	public MagFilterMode DefaultMagFilterMode
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public MinFilterMode DefaultMinFilterMode
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700001D")]
	public bool GenerateMipMaps
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001B")]
	public NameImportMethod NodeNameMethod
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011A")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1075A50", Offset = "0x1074C50", Length = "0x23")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<Load>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000121")]
	public ImportSettings() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011C")]
	public AnimationMethod get_AnimationMethod() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000120")]
	public int get_AnisotropicFilterLevel() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011F")]
	public MagFilterMode get_DefaultMagFilterMode() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011E")]
	public MinFilterMode get_DefaultMinFilterMode() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011D")]
	public bool get_GenerateMipMaps() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011A")]
	public NameImportMethod get_NodeNameMethod() { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	public void set_NodeNameMethod(NameImportMethod value) { }

}

