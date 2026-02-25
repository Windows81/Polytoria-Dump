namespace Mirror.BouncyCastle.Asn1.X9;

[Token(Token = "0x200021B")]
public abstract class X9IntegerConverter
{

	[Address(RVA = "0x10BD610", Offset = "0x10BC810", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600124B")]
	public static int GetByteLength(ECFieldElement fe) { }

	[Address(RVA = "0x111E160", Offset = "0x111D360", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ToByteArrayUnsigned", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600124C")]
	public static Byte[] IntegerToBytes(BigInteger s, int qLength) { }

}

