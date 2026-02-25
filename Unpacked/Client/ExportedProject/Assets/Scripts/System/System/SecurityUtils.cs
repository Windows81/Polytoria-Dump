namespace System;

[Token(Token = "0x20000B9")]
internal static class SecurityUtils
{

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000383")]
	private static void DemandReflectionAccess(Type type) { }

	[Address(RVA = "0x1746010", Offset = "0x1745210", Length = "0x12")]
	[CalledBy(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000384")]
	private static bool HasReflectionPermission(Type type) { }

	[Address(RVA = "0x1746030", Offset = "0x1745230", Length = "0x166")]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityUtils), Member = "HasReflectionPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000387")]
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic) { }

	[Address(RVA = "0x17461A0", Offset = "0x17453A0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityUtils), Member = "HasReflectionPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000388")]
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	[Address(RVA = "0x1746310", Offset = "0x1745510", Length = "0xB1")]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000385")]
	internal static object SecureCreateInstance(Type type) { }

	[Address(RVA = "0x17463D0", Offset = "0x17455D0", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityUtils), Member = "HasReflectionPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000386")]
	internal static object SecureCreateInstance(Type type, Object[] args, bool allowNonPublic) { }

}

