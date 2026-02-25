namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[Token(Token = "0x200029B")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	[Token(Token = "0x40006DD")]
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DB")]
	internal IntPtr m_Handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006DC")]
	internal uint m_Version; //Field offset: 0x8

	[Token(Token = "0x17000216")]
	public static PlayableHandle Null
	{
		[Address(RVA = "0x1986BD0", Offset = "0x1985DD0", Length = "0x60")]
		[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000D3B")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x1986B90", Offset = "0x1985D90", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000D43")]
	private static PlayableHandle() { }

	[Address(RVA = "0xE0F560", Offset = "0xE0E760", Length = "0x1C")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D40")]
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[Address(RVA = "0x1986940", Offset = "0x1985B40", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D3D")]
	public virtual bool Equals(object p) { }

	[Address(RVA = "0x1986A50", Offset = "0x1985C50", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D3E")]
	public override bool Equals(PlayableHandle other) { }

	[Address(RVA = "0x1986BD0", Offset = "0x1985DD0", Length = "0x60")]
	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D3B")]
	public static PlayableHandle get_Null() { }

	[Address(RVA = "0x1986AE0", Offset = "0x1985CE0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D3F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1986B10", Offset = "0x1985D10", Length = "0x33")]
	[CalledBy(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000D42")]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	[Address(RVA = "0x72AA40", Offset = "0x729C40", Length = "0x92")]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetPlayableType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D3A")]
	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[Address(RVA = "0x1986B50", Offset = "0x1985D50", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D41")]
	[VisibleToOtherModules]
	internal bool IsValid() { }

	[Address(RVA = "0x1986C30", Offset = "0x1985E30", Length = "0x6D")]
	[CalledBy(Type = "UnityEngine.Animations.AnimationClipPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationClipPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationLayerMixerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationMixerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationMotionXToDeltaPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationScriptPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimatorControllerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Audio.AudioClipPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Audio.AudioClipPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Audio.AudioMixerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Audio.AudioMixerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Experimental.Video.VideoClipPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Video.VideoClipPlayable"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D3C")]
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

}

