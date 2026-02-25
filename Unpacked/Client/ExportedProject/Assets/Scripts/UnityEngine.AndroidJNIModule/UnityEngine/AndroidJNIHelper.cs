namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000C")]
[UsedByNativeCode]
public static class AndroidJNIHelper
{

	[Address(RVA = "0x19033C0", Offset = "0x19025C0", Length = "0x11D")]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181901F10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000055")]
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	[Address(RVA = "0x1903300", Offset = "0x1902500", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(jvalue), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6000056")]
	public static IntPtr Box(int value) { }

	[Address(RVA = "0x1903360", Offset = "0x1902560", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000057")]
	public static IntPtr Box(bool value) { }

	[Address(RVA = "0x60AB70", Offset = "0x609D70", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000053")]
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	[Address(RVA = "0x1903620", Offset = "0x1902820", Length = "0x249")]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004F")]
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	[Address(RVA = "0x1903870", Offset = "0x1902A70", Length = "0x140")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaProxy)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[Address(RVA = "0x19034E0", Offset = "0x19026E0", Length = "0x13B")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800233A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Token(Token = "0x6000050")]
	public static void CreateJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	[Address(RVA = "0x19039B0", Offset = "0x1902BB0", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000051")]
	public static void DeleteJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	[Address(RVA = "0x1903D60", Offset = "0x1902F60", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600004C")]
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	[Address(RVA = "0x1903B60", Offset = "0x1902D60", Length = "0x1F0")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	[Address(RVA = "0x1903DC0", Offset = "0x1902FC0", Length = "0x81")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(Object[]), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600004D")]
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	[Address(RVA = "0x60AF40", Offset = "0x60A140", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(Object[]), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000054")]
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

}

