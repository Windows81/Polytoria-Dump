namespace System.Net.Http.Headers;

[Token(Token = "0x200001D")]
internal static class CollectionParser
{

	[Address(RVA = "0x687A00", Offset = "0x686C00", Length = "0x220")]
	[CalledBy(Type = typeof(ViaHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<ViaHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WarningHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<WarningHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransferCodingWithQualityHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<TransferCodingWithQualityHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StringWithQualityHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<StringWithQualityHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProductHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<ProductHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NameValueWithParametersHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<NameValueWithParametersHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransferCodingHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<TransferCodingHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MediaTypeWithQualityHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<MediaTypeWithQualityHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EntityTagHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<EntityTagHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CollectionParser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<String>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticationHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<AuthenticationHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NameValueHeaderValue), Member = "TryParsePragma", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<NameValueHeaderValue>&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BE")]
	public static bool TryParse(string input, int minimalCount, ElementTryParser<T> parser, out List<T>& result) { }

	[Address(RVA = "0x1609410", Offset = "0x1608610", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ElementTryParser`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionParser), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "System.Net.Http.Headers.ElementTryParser`1<T>", "System.Collections.Generic.List`1<T>&"}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000BF")]
	public static bool TryParse(string input, int minimalCount, out List<String>& result) { }

	[Address(RVA = "0x16092A0", Offset = "0x16084A0", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Lexer), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C0")]
	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }

}

