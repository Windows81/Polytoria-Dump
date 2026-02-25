namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x200039E")]
public class DecalProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FE8")]
	private readonly Decal decal; //Field offset: 0x20

	[Token(Token = "0x17000B76")]
	public bool CastShadows
	{
		[Address(RVA = "0x4A3010", Offset = "0x4A2210", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026EA")]
		 get { } //Length: 30
		[Address(RVA = "0x4A3100", Offset = "0x4A2300", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decal), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026EB")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B75")]
	public Color Color
	{
		[Address(RVA = "0x4A3030", Offset = "0x4A2230", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E8")]
		 get { } //Length: 36
		[Address(RVA = "0x4A3120", Offset = "0x4A2320", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decal), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E9")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B71")]
	public string ImageID
	{
		[Address(RVA = "0x4A3060", Offset = "0x4A2260", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E0")]
		 get { } //Length: 30
		[Address(RVA = "0x4A3150", Offset = "0x4A2350", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decal), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E1")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B72")]
	public ImageType ImageType
	{
		[Address(RVA = "0x4A3080", Offset = "0x4A2280", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E2")]
		 get { } //Length: 29
		[Address(RVA = "0x4A3170", Offset = "0x4A2370", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decal), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E3")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B74")]
	public Vector2 TextureOffset
	{
		[Address(RVA = "0x4A30A0", Offset = "0x4A22A0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E6")]
		 get { } //Length: 47
		[Address(RVA = "0x4A3190", Offset = "0x4A2390", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decal), Member = "set_TextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E7")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B73")]
	public Vector2 TextureScale
	{
		[Address(RVA = "0x4A30D0", Offset = "0x4A22D0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E4")]
		 get { } //Length: 47
		[Address(RVA = "0x4A31B0", Offset = "0x4A23B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decal), Member = "set_TextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026E5")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026DF")]
	public DecalProxy(Decal target) { }

	[Address(RVA = "0x4A3010", Offset = "0x4A2210", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026EA")]
	public bool get_CastShadows() { }

	[Address(RVA = "0x4A3030", Offset = "0x4A2230", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E8")]
	public Color get_Color() { }

	[Address(RVA = "0x4A3060", Offset = "0x4A2260", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E0")]
	public string get_ImageID() { }

	[Address(RVA = "0x4A3080", Offset = "0x4A2280", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E2")]
	public ImageType get_ImageType() { }

	[Address(RVA = "0x4A30A0", Offset = "0x4A22A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E6")]
	public Vector2 get_TextureOffset() { }

	[Address(RVA = "0x4A30D0", Offset = "0x4A22D0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E4")]
	public Vector2 get_TextureScale() { }

	[Address(RVA = "0x4A3100", Offset = "0x4A2300", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decal), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026EB")]
	public void set_CastShadows(bool value) { }

	[Address(RVA = "0x4A3120", Offset = "0x4A2320", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decal), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E9")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4A3150", Offset = "0x4A2350", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decal), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E1")]
	public void set_ImageID(string value) { }

	[Address(RVA = "0x4A3170", Offset = "0x4A2370", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decal), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E3")]
	public void set_ImageType(ImageType value) { }

	[Address(RVA = "0x4A3190", Offset = "0x4A2390", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decal), Member = "set_TextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E7")]
	public void set_TextureOffset(Vector2 value) { }

	[Address(RVA = "0x4A31B0", Offset = "0x4A23B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decal), Member = "set_TextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026E5")]
	public void set_TextureScale(Vector2 value) { }

}

