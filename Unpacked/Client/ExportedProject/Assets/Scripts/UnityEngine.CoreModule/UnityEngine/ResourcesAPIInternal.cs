namespace UnityEngine;

[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[Token(Token = "0x200011A")]
internal static class ResourcesAPIInternal
{

	[Address(RVA = "0x196E2C0", Offset = "0x196D4C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	[Token(Token = "0x60008A4")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[Address(RVA = "0x196E340", Offset = "0x196D540", Length = "0x1D3")]
	[CalledBy(Type = typeof(ResourcesAPI), Member = "FindShaderByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959F60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetShaderNameRegistry().FindShader")]
	[Token(Token = "0x60008A5")]
	public static Shader FindShaderByName(string name) { }

	[Address(RVA = "0x196E300", Offset = "0x196D500", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008A7")]
	private static IntPtr FindShaderByName_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x196E570", Offset = "0x196D770", Length = "0x1F4")]
	[CalledBy(Type = typeof(ResourcesAPI), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Resources_Bindings::Load")]
	[NativeThrows]
	[Token(Token = "0x60008A6")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedBySecondArgument (1))]
	public static object Load(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x196E520", Offset = "0x196D720", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008A8")]
	private static IntPtr Load_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance) { }

}

