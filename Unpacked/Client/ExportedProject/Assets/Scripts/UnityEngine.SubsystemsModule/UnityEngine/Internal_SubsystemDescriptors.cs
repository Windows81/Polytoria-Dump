namespace UnityEngine;

[Token(Token = "0x200000B")]
internal static class Internal_SubsystemDescriptors
{

	[Address(RVA = "0x1A19B60", Offset = "0x1A18D60", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SubsystemDescriptorStore), Member = "RegisterDescriptor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "TBaseTypeInList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "System.Collections.Generic.List`1<TBaseTypeInList>"}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600000F")]
	internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor) { }

}

