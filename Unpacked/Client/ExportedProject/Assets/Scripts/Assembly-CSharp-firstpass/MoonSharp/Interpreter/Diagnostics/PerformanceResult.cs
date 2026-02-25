namespace MoonSharp.Interpreter.Diagnostics;

[Token(Token = "0x2000157")]
public class PerformanceResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400057F")]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000580")]
	private long <Counter>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000581")]
	private int <Instances>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000582")]
	private bool <Global>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000583")]
	private PerformanceCounterType <Type>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170001A8")]
	public internal long Counter
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC4")]
		 get { } //Length: 5
		[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC5")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x170001AA")]
	public internal bool Global
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC8")]
		 get { } //Length: 5
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC9")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170001A9")]
	public internal int Instances
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC6")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC7")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170001A7")]
	public internal string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC2")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC3")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001AB")]
	public internal PerformanceCounterType Type
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CCA")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CCB")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCE")]
	public PerformanceResult() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC4")]
	public long get_Counter() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC8")]
	public bool get_Global() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC6")]
	public int get_Instances() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC2")]
	public string get_Name() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCA")]
	public PerformanceCounterType get_Type() { }

	[Address(RVA = "0x387520", Offset = "0x386720", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000CCD")]
	public static string PerformanceCounterTypeToString(PerformanceCounterType Type) { }

	[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC5")]
	internal void set_Counter(long value) { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC9")]
	internal void set_Global(bool value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC7")]
	internal void set_Instances(int value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC3")]
	internal void set_Name(string value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCB")]
	internal void set_Type(PerformanceCounterType value) { }

	[Address(RVA = "0x387610", Offset = "0x386810", Length = "0x326")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6000CCC")]
	public virtual string ToString() { }

}

