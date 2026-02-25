namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200015D")]
public sealed class DefaultPropertyAttribute : Attribute
{
	[Token(Token = "0x40005F6")]
	public static readonly DefaultPropertyAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F5")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000190")]
	public string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000870")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x179BEC0", Offset = "0x179B0C0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000873")]
	private static DefaultPropertyAttribute() { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086F")]
	public DefaultPropertyAttribute(string name) { }

	[Address(RVA = "0x179BE50", Offset = "0x179B050", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000871")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000870")]
	public string get_Name() { }

	[Address(RVA = "0x177CCF0", Offset = "0x177BEF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000872")]
	public virtual int GetHashCode() { }

}

