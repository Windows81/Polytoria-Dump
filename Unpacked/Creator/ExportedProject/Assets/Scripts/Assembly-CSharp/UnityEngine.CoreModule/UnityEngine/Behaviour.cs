namespace UnityEngine;

[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[Token(Token = "0x2000137")]
[UsedByNativeCode]
public class Behaviour : Component
{

	[NativeProperty]
	[RequiredByNativeCode]
	[Token(Token = "0x17000182")]
	public bool enabled
	{
		[Address(RVA = "0x195D7D0", Offset = "0x195C9D0", Length = "0x76")]
		[CallerCount(Count = 61)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600090B")]
		 get { } //Length: 118
		[Address(RVA = "0x195D960", Offset = "0x195CB60", Length = "0x86")]
		[CallerCount(Count = 79)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600090C")]
		 set { } //Length: 134
	}

	[NativeProperty]
	[Token(Token = "0x17000183")]
	public bool isActiveAndEnabled
	{
		[Address(RVA = "0x195D890", Offset = "0x195CA90", Length = "0x76")]
		[CallerCount(Count = 53)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("IsAddedToManager")]
		[Token(Token = "0x600090D")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x195D740", Offset = "0x195C940", Length = "0x49")]
	[CallerCount(Count = 182)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600090E")]
	public Behaviour() { }

	[Address(RVA = "0x195D7D0", Offset = "0x195C9D0", Length = "0x76")]
	[CallerCount(Count = 61)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600090B")]
	public bool get_enabled() { }

	[Address(RVA = "0x195D790", Offset = "0x195C990", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600090F")]
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x195D890", Offset = "0x195CA90", Length = "0x76")]
	[CallerCount(Count = 53)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("IsAddedToManager")]
	[Token(Token = "0x600090D")]
	public bool get_isActiveAndEnabled() { }

	[Address(RVA = "0x195D850", Offset = "0x195CA50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000911")]
	private static bool get_isActiveAndEnabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x195D960", Offset = "0x195CB60", Length = "0x86")]
	[CallerCount(Count = 79)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600090C")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x195D910", Offset = "0x195CB10", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000910")]
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

}

