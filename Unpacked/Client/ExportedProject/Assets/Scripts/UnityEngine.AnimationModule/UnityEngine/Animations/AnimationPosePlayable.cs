namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000025")]
internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable>
{
	[Token(Token = "0x4000060")]
	private static readonly AnimationPosePlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005F")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1912F40", Offset = "0x1912140", Length = "0x139")]
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
	[Token(Token = "0x60000BD")]
	private static AnimationPosePlayable() { }

	[Address(RVA = "0x1913080", Offset = "0x1912280", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000BA")]
	internal AnimationPosePlayable(PlayableHandle handle) { }

	[Address(RVA = "0x1912EA0", Offset = "0x19120A0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BC")]
	public override bool Equals(AnimationPosePlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BB")]
	public override PlayableHandle GetHandle() { }

}

