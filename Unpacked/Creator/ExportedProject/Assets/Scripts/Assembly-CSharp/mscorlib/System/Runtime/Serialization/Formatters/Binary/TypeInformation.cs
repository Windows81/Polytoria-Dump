namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200041A")]
internal sealed class TypeInformation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010D0")]
	private string fullTypeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010D1")]
	private string assemblyString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010D2")]
	private bool hasTypeForwardedFrom; //Field offset: 0x20

	[Token(Token = "0x170003D9")]
	internal string AssemblyString
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EAC")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003D8")]
	internal string FullTypeName
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EAB")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003DA")]
	internal bool HasTypeForwardedFrom
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EAD")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x13A9EC0", Offset = "0x13A90C0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EAE")]
	internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EAC")]
	internal string get_AssemblyString() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EAB")]
	internal string get_FullTypeName() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EAD")]
	internal bool get_HasTypeForwardedFrom() { }

}

