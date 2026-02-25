namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x200017A")]
public sealed class TypeConverterAttribute : Attribute
{
	[Token(Token = "0x400061E")]
	public static readonly TypeConverterAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061F")]
	private readonly string <ConverterTypeName>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001B8")]
	public string ConverterTypeName
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000925")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17A9E10", Offset = "0x17A9010", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000928")]
	private static TypeConverterAttribute() { }

	[Address(RVA = "0x177EE40", Offset = "0x177E040", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000922")]
	public TypeConverterAttribute() { }

	[Address(RVA = "0x17A9EA0", Offset = "0x17A90A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000923")]
	public TypeConverterAttribute(Type type) { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000924")]
	public TypeConverterAttribute(string typeName) { }

	[Address(RVA = "0x17A9DA0", Offset = "0x17A8FA0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000926")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000925")]
	public string get_ConverterTypeName() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000927")]
	public virtual int GetHashCode() { }

}

