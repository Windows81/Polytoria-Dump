namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001DB")]
public abstract class DerStringBase : Asn1Object
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600111D")]
	protected DerStringBase() { }

	[Address(RVA = "0x110B930", Offset = "0x110AB30", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001120")]
	protected virtual int Asn1GetHashCode() { }

	[Token(Token = "0x600111E")]
	public abstract string GetString() { }

	[Address(RVA = "0x110B970", Offset = "0x110AB70", Length = "0x14")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600111F")]
	public virtual string ToString() { }

}

