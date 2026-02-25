namespace UnityEngine;

[Token(Token = "0x2000008")]
public class AndroidJavaClass : AndroidJavaObject
{

	[Address(RVA = "0x1909590", Offset = "0x1908790", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002E")]
	private void _AndroidJavaClass(string className) { }

	[Address(RVA = "0x1909820", Offset = "0x1908A20", Length = "0x18E")]
	[CalledBy(Type = typeof(AndroidJavaRunnableProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "UnboxArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaObject)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002D")]
	public AndroidJavaClass(string className) { }

	[Address(RVA = "0x1909720", Offset = "0x1908920", Length = "0xFF")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002F")]
	internal AndroidJavaClass(IntPtr jclass) { }

}

