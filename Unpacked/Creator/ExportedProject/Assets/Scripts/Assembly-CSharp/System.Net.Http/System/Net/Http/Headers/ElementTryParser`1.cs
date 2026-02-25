namespace System.Net.Http.Headers;

[Token(Token = "0x200001C")]
internal sealed class ElementTryParser : MulticastDelegate
{

	[Address(RVA = "0xAE00B0", Offset = "0xADF2B0", Length = "0x125")]
	[CalledBy(Type = typeof(StringWithQualityHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<StringWithQualityHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WarningHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<WarningHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ViaHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<ViaHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransferCodingWithQualityHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<TransferCodingWithQualityHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransferCodingHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<TransferCodingHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProductHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<ProductHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NameValueWithParametersHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<NameValueWithParametersHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MediaTypeWithQualityHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<MediaTypeWithQualityHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EntityTagHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<EntityTagHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CollectionParser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<String>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticationHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<AuthenticationHeaderValue>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NameValueHeaderValue), Member = "TryParsePragma", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(List`1<NameValueHeaderValue>&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BC")]
	public ElementTryParser`1(object object, IntPtr method) { }

	[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BD")]
	public override bool Invoke(Lexer lexer, out T parsedValue, out Token token) { }

}

