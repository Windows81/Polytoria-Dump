namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000316")]
public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F7")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x1985380", Offset = "0x1984580", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EDC")]
	public override bool Equals(MaterialEffectPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDB")]
	public override PlayableHandle GetHandle() { }

}

