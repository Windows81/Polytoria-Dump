namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000020")]
public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable>
{
	[Token(Token = "0x4000057")]
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000056")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1912490", Offset = "0x1911690", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
	[Calls(Type = typeof(AnimationLayerMixerPlayable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000AD")]
	private static AnimationLayerMixerPlayable() { }

	[Address(RVA = "0x1912520", Offset = "0x1911720", Length = "0x133")]
	[CalledBy(Type = typeof(AnimationLayerMixerPlayable), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A9")]
	internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true) { }

	[Address(RVA = "0x19123A0", Offset = "0x19115A0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000AB")]
	public override bool Equals(AnimationLayerMixerPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x1912440", Offset = "0x1911640", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x60000AC")]
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

}

