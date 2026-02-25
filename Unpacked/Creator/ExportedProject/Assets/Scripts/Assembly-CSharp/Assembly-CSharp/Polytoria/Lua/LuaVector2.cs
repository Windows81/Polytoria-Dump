namespace Polytoria.Lua;

[Token(Token = "0x2000307")]
public class LuaVector2
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BDC")]
	public LuaVector2() { }

	[Address(RVA = "0x40ECA0", Offset = "0x40DEA0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BDB")]
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	[Address(RVA = "0x40ED10", Offset = "0x40DF10", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BD8")]
	public static Vector2 New() { }

	[Address(RVA = "0x40ED20", Offset = "0x40DF20", Length = "0xC")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BD9")]
	public static Vector2 New(float d) { }

	[Address(RVA = "0x40ED30", Offset = "0x40DF30", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BDA")]
	public static Vector2 New(float x, float y) { }

}

