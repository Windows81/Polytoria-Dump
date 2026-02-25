namespace Mirror;

[Token(Token = "0x2000095")]
public static class Mathd
{

	[Address(RVA = "0x128EA90", Offset = "0x128DC90", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004B9")]
	public static double Clamp(double value, double min, double max) { }

	[Address(RVA = "0x128EA70", Offset = "0x128DC70", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004BA")]
	public static double Clamp01(double value) { }

	[Address(RVA = "0x128EAB0", Offset = "0x128DCB0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004BB")]
	public static double InverseLerp(double a, double b, double value) { }

	[Address(RVA = "0x128EAF0", Offset = "0x128DCF0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004BC")]
	public static double LerpUnclamped(double a, double b, double t) { }

}

