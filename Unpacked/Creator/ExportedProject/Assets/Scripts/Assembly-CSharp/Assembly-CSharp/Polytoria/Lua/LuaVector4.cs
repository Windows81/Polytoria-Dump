namespace Polytoria.Lua;

[Token(Token = "0x2000309")]
public class LuaVector4
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BFB")]
	public LuaVector4() { }

	[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BF6")]
	public static Vector4 New() { }

	[Address(RVA = "0x40FAD0", Offset = "0x40ECD0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BF7")]
	public static Vector3 New(float d) { }

	[Address(RVA = "0x40FAB0", Offset = "0x40ECB0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BF8")]
	public static Vector4 New(float x, float y) { }

	[Address(RVA = "0x40FA90", Offset = "0x40EC90", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BF9")]
	public static Vector4 New(float x, float y, float z) { }

	[Address(RVA = "0x40E010", Offset = "0x40D210", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BFA")]
	public static Vector4 New(float x, float y, float z, float w) { }

}

