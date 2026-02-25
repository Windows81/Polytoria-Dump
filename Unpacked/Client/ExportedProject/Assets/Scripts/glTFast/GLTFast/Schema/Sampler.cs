namespace GLTFast.Schema;

[Token(Token = "0x20000CA")]
public class Sampler : NamedObject
{
	[Token(Token = "0x20000CB")]
	internal enum MagFilterMode
	{
		None = 0,
		Nearest = 9728,
		Linear = 9729,
	}

	[Token(Token = "0x20000CC")]
	internal enum MinFilterMode
	{
		None = 0,
		Nearest = 9728,
		Linear = 9729,
		NearestMipmapNearest = 9984,
		LinearMipmapNearest = 9985,
		NearestMipmapLinear = 9986,
		LinearMipmapLinear = 9987,
	}

	[Token(Token = "0x20000CD")]
	internal enum WrapMode
	{
		None = 0,
		ClampToEdge = 33071,
		MirroredRepeat = 33648,
		Repeat = 10497,
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002CE")]
	public MagFilterMode magFilter; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002CF")]
	public MinFilterMode minFilter; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D0")]
	public WrapMode wrapS; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002D1")]
	public WrapMode wrapT; //Field offset: 0x24

	[Token(Token = "0x17000082")]
	public FilterMode FilterMode
	{
		[Address(RVA = "0x107A4B0", Offset = "0x10796B0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000263")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000083")]
	public TextureWrapMode WrapU
	{
		[Address(RVA = "0x107A4F0", Offset = "0x10796F0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000264")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000084")]
	public TextureWrapMode WrapV
	{
		[Address(RVA = "0x107A520", Offset = "0x1079720", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000265")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x107A490", Offset = "0x1079690", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000268")]
	public Sampler() { }

	[Address(RVA = "0x107A2D0", Offset = "0x10794D0", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000269")]
	public void Apply(Texture2D image, MinFilterMode defaultMinFilter = 9729, MagFilterMode defaultMagFilter = 9729) { }

	[Address(RVA = "0x107A420", Offset = "0x1079620", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000266")]
	private static FilterMode ConvertFilterMode(MinFilterMode minFilterToConvert, MagFilterMode magFilterToConvert) { }

	[Address(RVA = "0x107A460", Offset = "0x1079660", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000267")]
	private static TextureWrapMode ConvertWrapMode(WrapMode wrapMode) { }

	[Address(RVA = "0x107A4B0", Offset = "0x10796B0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000263")]
	public FilterMode get_FilterMode() { }

	[Address(RVA = "0x107A4F0", Offset = "0x10796F0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000264")]
	public TextureWrapMode get_WrapU() { }

	[Address(RVA = "0x107A520", Offset = "0x1079720", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000265")]
	public TextureWrapMode get_WrapV() { }

}

