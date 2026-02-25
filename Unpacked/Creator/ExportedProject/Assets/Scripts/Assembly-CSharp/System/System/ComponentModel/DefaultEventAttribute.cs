namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200015C")]
public sealed class DefaultEventAttribute : Attribute
{
	[Token(Token = "0x40005F4")]
	public static readonly DefaultEventAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F3")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700018F")]
	public string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600086B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x179B7A0", Offset = "0x179A9A0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600086E")]
	private static DefaultEventAttribute() { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086A")]
	public DefaultEventAttribute(string name) { }

	[Address(RVA = "0x179B730", Offset = "0x179A930", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600086C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600086B")]
	public string get_Name() { }

	[Address(RVA = "0x177CCF0", Offset = "0x177BEF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x600086D")]
	public virtual int GetHashCode() { }

}

