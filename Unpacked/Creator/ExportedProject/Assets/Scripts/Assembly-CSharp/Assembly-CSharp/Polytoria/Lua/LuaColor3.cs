namespace Polytoria.Lua;

[Token(Token = "0x2000303")]
public class LuaColor3
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BBC")]
	public LuaColor3() { }

	[Address(RVA = "0x40DF20", Offset = "0x40D120", Length = "0x29")]
	[CalledBy(Type = typeof(SunLight), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001BBA")]
	public static Color FromHex(string hex) { }

	[Address(RVA = "0x40DF50", Offset = "0x40D150", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BBB")]
	public static Color Lerp(Color a, Color b, float t) { }

	[Address(RVA = "0x40E070", Offset = "0x40D270", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB5")]
	public static Color New() { }

	[Address(RVA = "0x40E030", Offset = "0x40D230", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BB6")]
	public static Color New(float d) { }

	[Address(RVA = "0x40E050", Offset = "0x40D250", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BB7")]
	public static Color New(float r, float g, float b) { }

	[Address(RVA = "0x40E010", Offset = "0x40D210", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB8")]
	public static Color New(float r, float g, float b, float a) { }

	[Address(RVA = "0x40E090", Offset = "0x40D290", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6001BB9")]
	public static Color Random() { }

}

