namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000144")]
public sealed class BrowsableAttribute : Attribute
{
	[Token(Token = "0x40005CD")]
	public static readonly BrowsableAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x40005CE")]
	public static readonly BrowsableAttribute No; //Field offset: 0x8
	[Token(Token = "0x40005CF")]
	public static readonly BrowsableAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D0")]
	private readonly bool <Browsable>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000177")]
	public bool Browsable
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60007FF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x177C500", Offset = "0x177B700", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000803")]
	private static BrowsableAttribute() { }

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FE")]
	public BrowsableAttribute(bool browsable) { }

	[Address(RVA = "0x177C3D0", Offset = "0x177B5D0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000800")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FF")]
	public bool get_Browsable() { }

	[Address(RVA = "0x11DDC40", Offset = "0x11DCE40", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000801")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x177C490", Offset = "0x177B690", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000802")]
	public virtual bool IsDefaultAttribute() { }

}

