namespace System;

[Token(Token = "0x2000104")]
public class InvalidOperationException : SystemException
{

	[Address(RVA = "0x14A1970", Offset = "0x14A0B70", Length = "0x44")]
	[CallerCount(Count = 157)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000811")]
	public InvalidOperationException() { }

	[Address(RVA = "0x14A19E0", Offset = "0x14A0BE0", Length = "0x1E")]
	[CallerCount(Count = 818)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000812")]
	public InvalidOperationException(string message) { }

	[Address(RVA = "0x14A19C0", Offset = "0x14A0BC0", Length = "0x1E")]
	[CalledBy(Type = "System.Net.ExceptionHelper", Member = "get_TimeoutException", ReturnType = "System.Net.WebException")]
	[CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception), "System.Net.WebExceptionStatus", "System.Net.WebResponse", "System.Net.WebExceptionInternalStatus"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), "System.Net.WebExceptionStatus", "System.Net.WebResponse", "System.Net.WebExceptionInternalStatus"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception), "System.Net.WebExceptionStatus", "System.Net.WebResponse"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), "System.Net.WebExceptionStatus", "System.Net.WebResponse"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.WebExceptionStatus", "System.Net.WebExceptionInternalStatus", typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Array), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int), typeof(object), typeof(IComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Array+SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Array+SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1ParsingException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.DerOctetStringParser", Member = "ToAsn1Object", ReturnType = "Mirror.BouncyCastle.Asn1.Asn1Object")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000813")]
	public InvalidOperationException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000814")]
	protected InvalidOperationException(SerializationInfo info, StreamingContext context) { }

}

