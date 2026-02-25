namespace Unity.Properties.Internal;

[Token(Token = "0x200006F")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.PropertiesModule"})]
internal static class PropertiesInitialization
{

	[Address(RVA = "0x1A0D380", Offset = "0x1A0C580", Length = "0x10E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.PropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemVersionPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 30)]
	[RequiredByNativeCode(False)]
	[Token(Token = "0x600026A")]
	public static void InitializeProperties() { }

}

