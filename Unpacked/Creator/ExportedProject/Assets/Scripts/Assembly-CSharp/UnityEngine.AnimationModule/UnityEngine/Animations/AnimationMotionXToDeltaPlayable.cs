namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000022")]
internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable>
{
	[Token(Token = "0x400005B")]
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005A")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x19129C0", Offset = "0x1911BC0", Length = "0x139")]
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
	[Token(Token = "0x60000B5")]
	private static AnimationMotionXToDeltaPlayable() { }

	[Address(RVA = "0x1912B00", Offset = "0x1911D00", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000B2")]
	private AnimationMotionXToDeltaPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x1912920", Offset = "0x1911B20", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000B4")]
	public override bool Equals(AnimationMotionXToDeltaPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	public override PlayableHandle GetHandle() { }

}

