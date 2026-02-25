namespace System.Text.RegularExpressions;

[Token(Token = "0x20000DB")]
public class Capture
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400034D")]
	private int <Index>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400034E")]
	private int <Length>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400034F")]
	private string <Text>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000C2")]
	public int Index
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600046F")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000470")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000C3")]
	public int Length
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000471")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000472")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000C4")]
	internal string Text
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000473")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000474")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000C5")]
	public string Value
	{
		[Address(RVA = "0x174E910", Offset = "0x174DB10", Length = "0x28")]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000475")]
		 get { } //Length: 40
	}

	[Address(RVA = "0x174E970", Offset = "0x174DB70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600046E")]
	internal Capture(string text, int index, int length) { }

	[Address(RVA = "0x174E940", Offset = "0x174DB40", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000479")]
	internal Capture() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600046F")]
	public int get_Index() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000471")]
	public int get_Length() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000473")]
	internal string get_Text() { }

	[Address(RVA = "0x174E910", Offset = "0x174DB10", Length = "0x28")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000475")]
	public string get_Value() { }

	[Address(RVA = "0x174E7B0", Offset = "0x174D9B0", Length = "0x96")]
	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Token(Token = "0x6000477")]
	internal ReadOnlySpan<Char> GetLeftSubstring() { }

	[Address(RVA = "0x174E850", Offset = "0x174DA50", Length = "0xB1")]
	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000478")]
	internal ReadOnlySpan<Char> GetRightSubstring() { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000470")]
	 void set_Index(int value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000472")]
	 void set_Length(int value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000474")]
	 void set_Text(string value) { }

	[Address(RVA = "0x174E910", Offset = "0x174DB10", Length = "0x28")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000476")]
	public virtual string ToString() { }

}

