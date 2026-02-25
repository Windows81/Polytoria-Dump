namespace System;

[Token(Token = "0x20000B4")]
public class ArgumentException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002A6")]
	private string _paramName; //Field offset: 0x90

	[Token(Token = "0x17000053")]
	public virtual string Message
	{
		[Address(RVA = "0x140A950", Offset = "0x1409B50", Length = "0x91")]
		[CalledBy(Type = typeof(CultureNotFoundException), Member = "get_Message", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000401")]
		 get { } //Length: 145
	}

	[Address(RVA = "0x140A7B0", Offset = "0x14099B0", Length = "0x44")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketOptionLevel", "System.Net.Sockets.SocketOptionName", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.Raw.Nat", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mirror.BouncyCastle.Math.BigInteger"}, ReturnType = "System.UInt32[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.Raw.Nat", Member = "FromBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mirror.BouncyCastle.Math.BigInteger"}, ReturnType = "System.UInt64[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.Raw.Nat", Member = "GetLengthForBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.Raw.Nat", Member = "GetLengthForBits64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.AbstractF2mCurve", Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.BigInteger", "Mirror.BouncyCastle.Math.BigInteger"}, ReturnType = "Mirror.BouncyCastle.Math.EC.ECPoint")]
	[CalledBy(Type = "System.Linq.Expressions.BlockExpressionList", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.Utils.ListProvider`1", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+Token", Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.RangeItemHeaderValue", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Int64>", "System.Nullable`1<Int64>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003FA")]
	public ArgumentException() { }

	[Address(RVA = "0x140A790", Offset = "0x1409990", Length = "0x1E")]
	[CallerCount(Count = 1292)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003FB")]
	public ArgumentException(string message) { }

	[Address(RVA = "0x140A930", Offset = "0x1409B30", Length = "0x1E")]
	[CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(UltimateResourceFallbackLocation&)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.BouncyCastle.Security.PublicKeyFactory", Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo"}, ReturnType = "Mirror.BouncyCastle.Crypto.AsymmetricKeyParameter")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.X9.X962Parameters", Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "Mirror.BouncyCastle.Asn1.X9.X962Parameters")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003FC")]
	public ArgumentException(string message, Exception innerException) { }

	[Address(RVA = "0x140A800", Offset = "0x1409A00", Length = "0x46")]
	[CalledBy(Type = "System.ComponentModel.BaseNumberConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003FD")]
	public ArgumentException(string message, string paramName, Exception innerException) { }

	[Address(RVA = "0x140A850", Offset = "0x1409A50", Length = "0x40")]
	[CallerCount(Count = 665)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003FE")]
	public ArgumentException(string message, string paramName) { }

	[Address(RVA = "0x140A890", Offset = "0x1409A90", Length = "0x90")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FF")]
	protected ArgumentException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x140A950", Offset = "0x1409B50", Length = "0x91")]
	[CalledBy(Type = typeof(CultureNotFoundException), Member = "get_Message", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000401")]
	public virtual string get_Message() { }

	[Address(RVA = "0x140A6D0", Offset = "0x14098D0", Length = "0xB5")]
	[CalledBy(Type = typeof(CultureNotFoundException), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000400")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

