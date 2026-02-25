namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000026")]
internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable>
{
	[Token(Token = "0x4000062")]
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000061")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1913200", Offset = "0x1912400", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000C1")]
	private static AnimationRemoveScalePlayable() { }

	[Address(RVA = "0x1913340", Offset = "0x1912540", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000BE")]
	internal AnimationRemoveScalePlayable(PlayableHandle handle) { }

	[Address(RVA = "0x1913160", Offset = "0x1912360", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C0")]
	public override bool Equals(AnimationRemoveScalePlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BF")]
	public override PlayableHandle GetHandle() { }

}

