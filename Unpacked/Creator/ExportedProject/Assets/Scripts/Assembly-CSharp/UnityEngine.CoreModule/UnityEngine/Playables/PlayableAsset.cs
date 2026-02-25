namespace UnityEngine.Playables;

[AssetFileNameExtension("playable", new IL2CPP_TYPE_STRING[] {})]
[RequiredByNativeCode]
[Token(Token = "0x2000296")]
public abstract class PlayableAsset : ScriptableObject
{

	[Token(Token = "0x17000214")]
	public override double duration
	{
		[Address(RVA = "0x1986800", Offset = "0x1985A00", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000D28")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000215")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x1986850", Offset = "0x1985A50", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000D29")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2C")]
	protected PlayableAsset() { }

	[Token(Token = "0x6000D27")]
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x1986800", Offset = "0x1985A00", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D28")]
	public override double get_duration() { }

	[Address(RVA = "0x1986850", Offset = "0x1985A50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D29")]
	public override IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x1986690", Offset = "0x1985890", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000D2A")]
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[Address(RVA = "0x19867C0", Offset = "0x19859C0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000D2B")]
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

}

