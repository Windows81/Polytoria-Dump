namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutput.bindings.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutputExtensions.bindings.h")]
[NativeHeader("Modules/Director/DataPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("DataPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
internal struct DataPlayableOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x19946D0", Offset = "0x19938D0", Length = "0xDC")]
	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems+DataPlayableOutputList+DataPlayableOutputEnumerator", Member = "get_Current", ReturnType = typeof(DataPlayableOutput))]
	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems+DataPlayableOutputList", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataPlayableOutput))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsPlayableOutputOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000001")]
	internal DataPlayableOutput(PlayableOutputHandle handle) { }

	[Address(RVA = "0x1994480", Offset = "0x1993680", Length = "0x24F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsPlayableOutputOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000002")]
	private static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, object previousPlayer, object currentPlayer) { }

}

