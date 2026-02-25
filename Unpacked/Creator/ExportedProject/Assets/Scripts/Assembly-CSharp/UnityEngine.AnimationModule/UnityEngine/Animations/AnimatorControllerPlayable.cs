namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000029")]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>
{
	[Token(Token = "0x400006D")]
	private static readonly AnimatorControllerPlayable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006C")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1914EC0", Offset = "0x19140C0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
	[Calls(Type = typeof(AnimatorControllerPlayable), Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000CA")]
	private static AnimatorControllerPlayable() { }

	[Address(RVA = "0x1914FC0", Offset = "0x19141C0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
	[Calls(Type = typeof(AnimatorControllerPlayable), Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C6")]
	internal AnimatorControllerPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x1914CD0", Offset = "0x1913ED0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000C9")]
	public override bool Equals(AnimatorControllerPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x1914D70", Offset = "0x1913F70", Length = "0x148")]
	[CalledBy(Type = typeof(AnimatorControllerPlayable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimatorControllerPlayable), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C8")]
	public void SetHandle(PlayableHandle handle) { }

}

