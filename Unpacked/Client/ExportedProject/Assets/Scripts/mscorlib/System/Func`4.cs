namespace System;

[Token(Token = "0x20000A9")]
public sealed class Func : MulticastDelegate
{

	[Address(RVA = "0xC48CB0", Offset = "0xC47EB0", Length = "0x125")]
	[CalledBy(Type = typeof(ObjectReader), Member = "GetSimplyNamedTypeFromAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(string), typeof(Type&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessMouseEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D4")]
	public Func`4(object object, IntPtr method) { }

	[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D5")]
	public override TResult Invoke(T1 arg1, T2 arg2, T3 arg3) { }

}

