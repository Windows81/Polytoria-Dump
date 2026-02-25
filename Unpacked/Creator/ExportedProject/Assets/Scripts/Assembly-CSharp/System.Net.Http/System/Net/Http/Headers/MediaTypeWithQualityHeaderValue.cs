namespace System.Net.Http.Headers;

[Token(Token = "0x2000035")]
public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	private MediaTypeWithQualityHeaderValue() { }

	[Address(RVA = "0x16153B0", Offset = "0x16145B0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ElementTryParser`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionParser), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "System.Net.Http.Headers.ElementTryParser`1<T>", "System.Collections.Generic.List`1<T>&"}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000166")]
	internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue>& result) { }

	[Address(RVA = "0x16151E0", Offset = "0x16143E0", Length = "0x1C2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MediaTypeHeaderValue), Member = "TryParseMediaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(String&)}, ReturnType = typeof(System.Nullable`1<System.Net.Http.Headers.Token>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NameValueHeaderValue), Member = "TryParseParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(List`1<NameValueHeaderValue>&), typeof(Token&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000165")]
	private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out Token t) { }

}

