namespace System.Threading;

[Token(Token = "0x2000245")]
public static class Volatile
{
	[Token(Token = "0x2000246")]
	private struct VolatileBoolean
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA0")]
		public bool Value; //Field offset: 0x0

	}

	[Token(Token = "0x2000247")]
	private struct VolatileInt32
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA1")]
		public int Value; //Field offset: 0x0

	}

	[Token(Token = "0x2000248")]
	private struct VolatileObject
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA2")]
		public object Value; //Field offset: 0x0

	}


	[Address(RVA = "0x153B700", Offset = "0x153A900", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Intrinsic]
	[Token(Token = "0x6001303")]
	public static bool Read(ref bool location) { }

	[Address(RVA = "0x153B6E0", Offset = "0x153A8E0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Intrinsic]
	[Token(Token = "0x6001305")]
	public static int Read(ref int location) { }

	[Address(RVA = "0x7D2D30", Offset = "0x7D1F30", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Intrinsic]
	[Token(Token = "0x6001307")]
	public static T Read(ref T location) { }

	[Address(RVA = "0x153B750", Offset = "0x153A950", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Intrinsic]
	[Token(Token = "0x6001304")]
	public static void Write(ref bool location, bool value) { }

	[Address(RVA = "0x153B720", Offset = "0x153A920", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Intrinsic]
	[Token(Token = "0x6001306")]
	public static void Write(ref int location, int value) { }

	[Address(RVA = "0x7D2D50", Offset = "0x7D1F50", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Intrinsic]
	[Token(Token = "0x6001308")]
	public static void Write(ref T location, T value) { }

}

