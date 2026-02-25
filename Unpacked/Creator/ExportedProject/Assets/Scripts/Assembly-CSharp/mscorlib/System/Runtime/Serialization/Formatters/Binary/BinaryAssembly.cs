namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000400")]
internal sealed class BinaryAssembly
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FFD")]
	internal int assemId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FFE")]
	internal string assemblyString; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE0")]
	internal BinaryAssembly() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE4")]
	public void Dump() { }

	[Address(RVA = "0x1398B50", Offset = "0x1397D50", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE3")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1398BC0", Offset = "0x1397DC0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE1")]
	internal void Set(int assemId, string assemblyString) { }

	[Address(RVA = "0x1398BE0", Offset = "0x1397DE0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001DE2")]
	public override void Write(__BinaryWriter sout) { }

}

