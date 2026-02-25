namespace UnityEngine;

[Token(Token = "0x2000009")]
internal class AndroidReflection
{
	[Token(Token = "0x400000C")]
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; //Field offset: 0x8
	[Token(Token = "0x400000E")]
	private static readonly IntPtr s_ReflectionHelperGetMethodID; //Field offset: 0x10
	[Token(Token = "0x400000F")]
	private static readonly IntPtr s_ReflectionHelperGetFieldID; //Field offset: 0x18
	[Token(Token = "0x4000010")]
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; //Field offset: 0x20
	[Token(Token = "0x4000011")]
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; //Field offset: 0x28
	[Token(Token = "0x4000012")]
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; //Field offset: 0x30
	[Token(Token = "0x4000013")]
	private static readonly IntPtr s_FieldGetDeclaringClass; //Field offset: 0x38

	[Address(RVA = "0x190C360", Offset = "0x190B560", Length = "0x2D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AndroidReflection), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidReflection), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	private static AndroidReflection() { }

	[Address(RVA = "0x190BB80", Offset = "0x190AD80", Length = "0x13B")]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(AndroidJavaObject))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "InvokeJavaProxyMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaProxy), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000037")]
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	[Address(RVA = "0x190BCC0", Offset = "0x190AEC0", Length = "0x1AA")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181902120")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000034")]
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	[Address(RVA = "0x190BE70", Offset = "0x190B070", Length = "0xAF")]
	[CalledBy(Type = typeof(AndroidReflection), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901F10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	[Address(RVA = "0x190BF20", Offset = "0x190B120", Length = "0x216")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901E70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000035")]
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	[Address(RVA = "0x190C140", Offset = "0x190B340", Length = "0xAF")]
	[CalledBy(Type = typeof(AndroidReflection), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901F10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	[Address(RVA = "0x190C1F0", Offset = "0x190B3F0", Length = "0x26")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000031")]
	public static bool IsAssignableFrom(Type t, Type from) { }

	[Address(RVA = "0x5D1FF0", Offset = "0x5D11F0", Length = "0x19")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public static bool IsPrimitive(Type t) { }

	[Address(RVA = "0x190C220", Offset = "0x190B420", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

}

