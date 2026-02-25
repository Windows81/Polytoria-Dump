namespace UnityEngine;

[Token(Token = "0x2000005")]
internal class AndroidJavaRunnableProxy : AndroidJavaProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000004")]
	private AndroidJavaRunnable mRunnable; //Field offset: 0x20

	[Address(RVA = "0x190BAA0", Offset = "0x190ACA0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable) { }

	[Address(RVA = "0x190B9F0", Offset = "0x190ABF0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetArrayLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	[Address(RVA = "0x12725F0", Offset = "0x12717F0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public void run() { }

}

