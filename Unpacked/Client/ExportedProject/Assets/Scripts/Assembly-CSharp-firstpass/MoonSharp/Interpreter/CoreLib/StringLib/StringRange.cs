namespace MoonSharp.Interpreter.CoreLib.StringLib;

[Token(Token = "0x200018E")]
internal class StringRange
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000620")]
	private int <Start>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000621")]
	private int <End>k__BackingField; //Field offset: 0x14

	[Token(Token = "0x170001DB")]
	public int End
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB2")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001DA")]
	public int Start
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB0")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB1")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3A2AB0", Offset = "0x3A1CB0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EB4")]
	public StringRange() { }

	[Address(RVA = "0x3A2A70", Offset = "0x3A1C70", Length = "0x34")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB5")]
	public StringRange(int start, int end) { }

	[Address(RVA = "0x3A28E0", Offset = "0x3A1AE0", Length = "0x91")]
	[CalledBy(Type = typeof(StringModule), Member = "PerformByteLike", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), typeof(DynValue), typeof(System.Func`2<System.Int32, System.Int32>)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EB7")]
	public string ApplyToString(string value) { }

	[Address(RVA = "0x3A2980", Offset = "0x3A1B80", Length = "0xD0")]
	[CalledBy(Type = typeof(StringModule), Member = "PerformByteLike", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue), typeof(DynValue), typeof(System.Func`2<System.Int32, System.Int32>)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(StringModule), Member = "sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EB6")]
	public static StringRange FromLuaRange(DynValue start, DynValue end, Nullable<Int32> defaultEnd = null) { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB2")]
	public int get_End() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB0")]
	public int get_Start() { }

	[Address(RVA = "0x3A2A60", Offset = "0x3A1C60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EB8")]
	public int Length() { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB3")]
	public void set_End(int value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB1")]
	public void set_Start(int value) { }

}

