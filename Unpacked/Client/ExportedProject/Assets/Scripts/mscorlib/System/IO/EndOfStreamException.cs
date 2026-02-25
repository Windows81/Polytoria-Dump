namespace System.IO;

[Token(Token = "0x2000624")]
public class EndOfStreamException : IOException
{

	[Address(RVA = "0x1454880", Offset = "0x1453A80", Length = "0x44")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.IndefiniteLengthInputStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.IndefiniteLengthInputStream", Member = "RequireByte", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CC4")]
	public EndOfStreamException() { }

	[Address(RVA = "0x14548D0", Offset = "0x1453AD0", Length = "0x1E")]
	[CalledBy(Type = "Mirror.NetworkReader", Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadGuidNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = "System.Nullable`1<Guid>")]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(Guid))]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadBytesAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.NetworkReader", Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.ArraySegment`1<Byte>")]
	[CalledBy(Type = "Mirror.NetworkReader", Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.DefiniteLengthInputStream", Member = "ToArray", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.DefiniteLengthInputStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.DefiniteLengthInputStream", Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1InputStream", Member = "CreateDerBmpString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Asn1.DefiniteLengthInputStream"}, ReturnType = "Mirror.BouncyCastle.Asn1.DerBmpString")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1InputStream", Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1InputStream", Member = "ReadTagNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.DefiniteLengthInputStream", Member = "ReadAllIntoByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = "T[]")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CC5")]
	public EndOfStreamException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CC6")]
	protected EndOfStreamException(SerializationInfo info, StreamingContext context) { }

}

