namespace System.Net.Http.Headers;

[Extension]
[Token(Token = "0x200001B")]
internal static class CollectionExtensions
{

	[Address(RVA = "0x687100", Offset = "0x686300", Length = "0x98")]
	[CalledBy(Type = typeof(CacheControlHeaderValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContentDispositionHeaderValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MediaTypeHeaderValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NameValueWithParametersHeaderValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RangeHeaderValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransferCodingHeaderValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000B9")]
	public static bool SequenceEqual(List<TSource> first, List<TSource> second) { }

	[Address(RVA = "0x687900", Offset = "0x686B00", Length = "0xFA")]
	[CalledBy(Type = typeof(ContentDispositionHeaderValue), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MediaTypeHeaderValue), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NameValueWithParametersHeaderValue), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TransferCodingHeaderValue), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000BA")]
	public static string ToString(List<T> list) { }

	[Address(RVA = "0x687690", Offset = "0x686890", Length = "0xC7")]
	[CalledBy(Type = typeof(CacheControlHeaderValue), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60000BB")]
	public static void ToStringBuilder(List<T> list, StringBuilder sb) { }

}

