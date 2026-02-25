namespace UnityEngine.Audio;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000E")]
public struct AudioClipPlayable : IEquatable<AudioClipPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000D")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1917E60", Offset = "0x1917060", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000056")]
	public override bool Equals(AudioClipPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	public override PlayableHandle GetHandle() { }

}

