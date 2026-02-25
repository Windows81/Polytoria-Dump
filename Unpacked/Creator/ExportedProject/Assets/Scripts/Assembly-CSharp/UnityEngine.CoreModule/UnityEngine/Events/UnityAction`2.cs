namespace UnityEngine.Events;

[Token(Token = "0x20001CB")]
public sealed class UnityAction : MulticastDelegate
{

	[Address(RVA = "0x83FCB0", Offset = "0x83EEB0", Length = "0xA6")]
	[CalledBy(Type = "LeanTween", Member = "init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C62")]
	public UnityAction`2(object object, IntPtr method) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C63")]
	public override void Invoke(T0 arg0, T1 arg1) { }

}

