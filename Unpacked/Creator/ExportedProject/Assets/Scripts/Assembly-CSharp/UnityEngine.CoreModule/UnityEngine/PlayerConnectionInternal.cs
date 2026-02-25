namespace UnityEngine;

[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
[Token(Token = "0x2000109")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000872")]
	public PlayerConnectionInternal() { }

	[Address(RVA = "0x1969E20", Offset = "0x1969020", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	[Token(Token = "0x6000871")]
	private static void DisconnectAll() { }

	[Address(RVA = "0x1969E50", Offset = "0x1969050", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	[Token(Token = "0x600086B")]
	private static void Initialize() { }

	[Address(RVA = "0x1969E80", Offset = "0x1969080", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	[Token(Token = "0x600086A")]
	private static bool IsConnected() { }

	[Address(RVA = "0x1969EB0", Offset = "0x19690B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	[Token(Token = "0x6000870")]
	private static void PollInternal() { }

	[Address(RVA = "0x1969F20", Offset = "0x1969120", Length = "0x16A")]
	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.RegisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	[Token(Token = "0x600086C")]
	private static void RegisterInternal(string messageId) { }

	[Address(RVA = "0x1969EE0", Offset = "0x19690E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000873")]
	private static void RegisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

	[Address(RVA = "0x196A0F0", Offset = "0x19692F0", Length = "0x228")]
	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	[Token(Token = "0x600086E")]
	private static void SendMessage(string messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x196A090", Offset = "0x1969290", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000875")]
	private static void SendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	[Address(RVA = "0x196A380", Offset = "0x1969580", Length = "0x231")]
	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.TrySendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	[Token(Token = "0x600086F")]
	private static bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x196A320", Offset = "0x1969520", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000876")]
	private static bool TrySendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	[Address(RVA = "0x1969E20", Offset = "0x1969020", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000869")]
	private override void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[Address(RVA = "0x1969E50", Offset = "0x1969050", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000867")]
	private override void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	[Address(RVA = "0x1969E80", Offset = "0x1969080", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000868")]
	private override bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	[Address(RVA = "0x1969EB0", Offset = "0x19690B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000864")]
	private override void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	[Address(RVA = "0x196A5C0", Offset = "0x19697C0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "RegisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000865")]
	private override void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	[Address(RVA = "0x196A610", Offset = "0x1969810", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000862")]
	private override void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x196A700", Offset = "0x1969900", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "TrySendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000863")]
	private override bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x196A7F0", Offset = "0x19699F0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "UnregisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000866")]
	private override void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	[Address(RVA = "0x196A880", Offset = "0x1969A80", Length = "0x16A")]
	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	[Token(Token = "0x600086D")]
	private static void UnregisterInternal(string messageId) { }

	[Address(RVA = "0x196A840", Offset = "0x1969A40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000874")]
	private static void UnregisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

}

