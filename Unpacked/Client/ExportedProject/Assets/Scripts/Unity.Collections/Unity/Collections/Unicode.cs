namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000039")]
public struct Unicode
{
	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x200003A")]
	internal struct Rune
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		public int value; //Field offset: 0x0

		[Address(RVA = "0x1820A10", Offset = "0x181FC10", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[ExcludeFromBurstCompatTesting("Takes managed object")]
		[Token(Token = "0x6000068")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000069")]
		public virtual int GetHashCode() { }

	}


	[Token(Token = "0x1700000E")]
	public static Rune ReplacementCharacter
	{
		[Address(RVA = "0x1820F40", Offset = "0x1820140", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000064")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1820F40", Offset = "0x1820140", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000064")]
	public static Rune get_ReplacementCharacter() { }

	[Address(RVA = "0x1820B30", Offset = "0x181FD30", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000062")]
	public static bool IsValidCodePoint(int codepoint) { }

	[Address(RVA = "0x1820B40", Offset = "0x181FD40", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000063")]
	public static bool NotTrailer(byte b) { }

	[Address(RVA = "0x1820B50", Offset = "0x181FD50", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000066")]
	public static ConversionError UcsToUtf16(Char* buffer, ref int index, int capacity, Rune rune) { }

	[Address(RVA = "0x1820BF0", Offset = "0x181FDF0", Length = "0x24A")]
	[CalledBy(Type = typeof(Unicode), Member = "Utf8ToUtf16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000065")]
	public static ConversionError Utf8ToUcs(out Rune rune, Byte* buffer, ref int index, int capacity) { }

	[Address(RVA = "0x1820E40", Offset = "0x1820040", Length = "0xFC")]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Token(Token = "0x6000067")]
	public static ConversionError Utf8ToUtf16(Byte* utf8Buffer, int utf8Length, Char* utf16Buffer, out int utf16Length, int utf16Capacity) { }

}

