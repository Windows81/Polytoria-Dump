namespace System.Net.Http.Headers;

[Token(Token = "0x2000021")]
internal static class HashCodeCalculator
{

	[Address(RVA = "0x6D2C60", Offset = "0x6D1E60", Length = "0x1FA")]
	[CalledBy(Type = typeof(TransferCodingHeaderValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CacheControlHeaderValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ContentDispositionHeaderValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MediaTypeHeaderValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NameValueWithParametersHeaderValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RangeHeaderValue), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E3")]
	public static int Calculate(ICollection<T> list) { }

}

