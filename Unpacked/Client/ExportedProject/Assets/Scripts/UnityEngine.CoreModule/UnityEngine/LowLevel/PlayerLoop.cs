namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
[Token(Token = "0x20001EC")]
public class PlayerLoop
{

	[Address(RVA = "0x1989480", Offset = "0x1988680", Length = "0x78")]
	[CalledBy(Type = "Mirror.NetworkLoop", Member = "RuntimeInitializeOnLoad", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystemInternal[]), typeof(Int32&)}, ReturnType = typeof(PlayerLoopSystem))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CCD")]
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	[Address(RVA = "0x1989450", Offset = "0x1988650", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsFreeFunction = True)]
	[Token(Token = "0x6000CD1")]
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	[Address(RVA = "0x1989500", Offset = "0x1988700", Length = "0x2D2")]
	[CalledBy(Type = typeof(PlayerLoop), Member = "GetCurrentPlayerLoop", ReturnType = typeof(PlayerLoopSystem))]
	[CalledBy(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystemInternal[]), typeof(Int32&)}, ReturnType = typeof(PlayerLoopSystem))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystemInternal[]), typeof(Int32&)}, ReturnType = typeof(PlayerLoopSystem))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CD0")]
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	[Address(RVA = "0x19897E0", Offset = "0x19889E0", Length = "0x305")]
	[CalledBy(Type = typeof(PlayerLoop), Member = "SetPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerLoop), Member = "PlayerLoopSystemToInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem), typeof(List`1<PlayerLoopSystemInternal>&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerLoop), Member = "PlayerLoopSystemToInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem), typeof(List`1<PlayerLoopSystemInternal>&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CCF")]
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal>& internalSys) { }

	[Address(RVA = "0x1989B30", Offset = "0x1988D30", Length = "0xDF")]
	[CalledBy(Type = "Mirror.NetworkLoop", Member = "RuntimeInitializeOnLoad", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlayerLoop), Member = "PlayerLoopSystemToInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem), typeof(List`1<PlayerLoopSystemInternal>&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CCE")]
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	[Address(RVA = "0x1989AF0", Offset = "0x1988CF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsFreeFunction = True)]
	[Token(Token = "0x6000CD2")]
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

}

