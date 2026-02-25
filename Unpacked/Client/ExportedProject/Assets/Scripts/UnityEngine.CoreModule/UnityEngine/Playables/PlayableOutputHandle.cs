namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[Token(Token = "0x200029D")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	[Token(Token = "0x40006E2")]
	private static readonly PlayableOutputHandle m_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E0")]
	internal IntPtr m_Handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006E1")]
	internal uint m_Version; //Field offset: 0x8

	[Token(Token = "0x17000217")]
	public static PlayableOutputHandle Null
	{
		[Address(RVA = "0x1986F00", Offset = "0x1986100", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000D48")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x1986EC0", Offset = "0x19860C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000D51")]
	private static PlayableOutputHandle() { }

	[Address(RVA = "0xE0F560", Offset = "0xE0E760", Length = "0x1C")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D4E")]
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[Address(RVA = "0x1986CA0", Offset = "0x1985EA0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D4C")]
	public virtual bool Equals(object p) { }

	[Address(RVA = "0x1986DB0", Offset = "0x1985FB0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D4D")]
	public override bool Equals(PlayableOutputHandle other) { }

	[Address(RVA = "0x1986F00", Offset = "0x1986100", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D48")]
	public static PlayableOutputHandle get_Null() { }

	[Address(RVA = "0x1986AE0", Offset = "0x1985CE0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D4A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1986E40", Offset = "0x1986040", Length = "0x33")]
	[CalledBy(Type = typeof(PlayableOutputHandle), Member = "IsPlayableOutputOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000D50")]
	internal Type GetPlayableOutputType() { }

	[Address(RVA = "0x72AAE0", Offset = "0x729CE0", Length = "0x92")]
	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = "Internal_CallOnPlayerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "GetPlayableOutputType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D49")]
	[VisibleToOtherModules]
	internal bool IsPlayableOutputOfType() { }

	[Address(RVA = "0x1986E80", Offset = "0x1986080", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = "Internal_CallOnPlayerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D4F")]
	[VisibleToOtherModules]
	internal bool IsValid() { }

	[Address(RVA = "0x1986F60", Offset = "0x1986160", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D4B")]
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

}

