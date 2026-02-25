namespace Unity.IntegerTime;

[Extension]
[Token(Token = "0x200001B")]
public static class RationalTimeExtensions
{

	[Address(RVA = "0x193A390", Offset = "0x1939590", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[FreeFunction("IntegerTime::RationalTime::ConvertRate", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6000053")]
	public static RationalTime Convert(RationalTime time, TicksPerSecond rate) { }

	[Address(RVA = "0x193A330", Offset = "0x1939530", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	private static void Convert_Injected(in RationalTime time, in TicksPerSecond rate, out RationalTime ret) { }

}

