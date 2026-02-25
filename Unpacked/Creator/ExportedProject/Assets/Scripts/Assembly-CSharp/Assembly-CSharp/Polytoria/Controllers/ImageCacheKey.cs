namespace Polytoria.Controllers;

[Token(Token = "0x2000406")]
public struct ImageCacheKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40010DF")]
	public string id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40010E0")]
	public string url; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010E1")]
	public ImageType type; //Field offset: 0x10

	[Address(RVA = "0x4C2B60", Offset = "0x4C1D60", Length = "0xC0")]
	[CalledBy(Type = typeof(Decal), Member = "<GetImage>b__41_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(ImageCacheEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "<GetImage>b__98_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(ImageCacheEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "<GetImage>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(ImageCacheEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002B1C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x4C2C30", Offset = "0x4C1E30", Length = "0x72")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002B1D")]
	public virtual int GetHashCode() { }

}

