namespace System.Net.Cache;

[Token(Token = "0x20002DA")]
internal class RequestCacheBinding
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C7B")]
	private RequestCache m_RequestCache; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C7C")]
	private RequestCacheValidator m_CacheValidator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C7D")]
	private RequestCachePolicy m_Policy; //Field offset: 0x20

	[Token(Token = "0x170003DA")]
	internal RequestCache Cache
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600121F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003DC")]
	internal RequestCachePolicy Policy
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001221")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003DB")]
	internal RequestCacheValidator Validator
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001220")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1013590", Offset = "0x1012790", Length = "0x6B")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600121E")]
	internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600121F")]
	internal RequestCache get_Cache() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001221")]
	internal RequestCachePolicy get_Policy() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001220")]
	internal RequestCacheValidator get_Validator() { }

}

