namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200001E")]
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000054")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1911500", Offset = "0x1910700", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000A8")]
	public override bool Equals(AnimationClipPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A7")]
	public override PlayableHandle GetHandle() { }

}

