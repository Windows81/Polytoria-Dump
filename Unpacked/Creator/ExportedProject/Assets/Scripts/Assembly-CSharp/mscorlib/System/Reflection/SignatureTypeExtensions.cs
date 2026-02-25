namespace System.Reflection;

[Extension]
[Token(Token = "0x20004F1")]
internal static class SignatureTypeExtensions
{

	[Address(RVA = "0x13CAC70", Offset = "0x13C9E70", Length = "0x419")]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[Extension]
	[Token(Token = "0x60022B9")]
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Address(RVA = "0x13CB090", Offset = "0x13CA290", Length = "0xC0")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x60022B8")]
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Address(RVA = "0x13CB190", Offset = "0x13CA390", Length = "0x2C")]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60022BC")]
	private static Type TryMakeArrayType(Type type) { }

	[Address(RVA = "0x13CB160", Offset = "0x13CA360", Length = "0x2C")]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60022BD")]
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Address(RVA = "0x13CB1C0", Offset = "0x13CA3C0", Length = "0x2C")]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60022BE")]
	private static Type TryMakeByRefType(Type type) { }

	[Address(RVA = "0x13CB1F0", Offset = "0x13CA3F0", Length = "0x2C")]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60022C0")]
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }

	[Address(RVA = "0x13CB220", Offset = "0x13CA420", Length = "0x2C")]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60022BF")]
	private static Type TryMakePointerType(Type type) { }

	[Address(RVA = "0x13CB290", Offset = "0x13CA490", Length = "0x42A")]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeByRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakePointerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[])}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[Extension]
	[Token(Token = "0x60022BB")]
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Address(RVA = "0x13CB250", Offset = "0x13CA450", Length = "0x3F")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Extension]
	[Token(Token = "0x60022BA")]
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

}

