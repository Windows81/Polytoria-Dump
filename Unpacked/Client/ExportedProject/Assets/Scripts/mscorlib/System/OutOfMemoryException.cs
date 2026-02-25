namespace System;

[Token(Token = "0x2000169")]
public class OutOfMemoryException : SystemException
{

	[Address(RVA = "0x14BBC10", Offset = "0x14BAE10", Length = "0x81")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[CalledBy(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "JoinCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "ReplaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(System.ReadOnlySpan`1<System.Int32>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Convert), Member = "ToBase64_CalculateAndValidateOutputLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsError", Member = "GetErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "CheckValidationResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Net.Security.ChainValidationHelper", typeof(string), typeof(bool), "System.Security.Cryptography.X509Certificates.X509CertificateCollection", typeof(bool), "System.Security.Cryptography.X509Certificates.X509Chain", "Mono.Btls.MonoBtlsX509StoreCtx", typeof(bool), "System.Net.Security.SslPolicyErrors&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509", Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "Mono.Btls.MonoBtlsX509Format"}, ReturnType = "Mono.Btls.MonoBtlsX509")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000C4C")]
	public OutOfMemoryException() { }

	[Address(RVA = "0x14BBCA0", Offset = "0x14BAEA0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C4D")]
	public OutOfMemoryException(string message) { }

	[Address(RVA = "0x14B40D0", Offset = "0x14B32D0", Length = "0x74")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C4E")]
	protected OutOfMemoryException(SerializationInfo info, StreamingContext context) { }

}

