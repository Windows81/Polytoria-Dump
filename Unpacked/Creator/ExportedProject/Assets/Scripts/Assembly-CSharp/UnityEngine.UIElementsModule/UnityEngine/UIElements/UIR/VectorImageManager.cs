namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005B1")]
internal class VectorImageManager : IDisposable
{
	[Token(Token = "0x4001489")]
	public static List<VectorImageManager> instances; //Field offset: 0x0
	[Token(Token = "0x400148A")]
	private static ProfilerMarker s_MarkerRegister; //Field offset: 0x8
	[Token(Token = "0x400148B")]
	private static ProfilerMarker s_MarkerUnregister; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400148C")]
	private readonly AtlasBase m_Atlas; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400148D")]
	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400148E")]
	private VectorImageRenderInfoPool m_RenderInfoPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400148F")]
	private GradientRemapPool m_GradientRemapPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001490")]
	private GradientSettingsAtlas m_GradientSettingsAtlas; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001491")]
	private bool m_LoggedExhaustedSettingsAtlas; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4001492")]
	private bool <disposed>k__BackingField; //Field offset: 0x39

	[Token(Token = "0x17000A27")]
	public Texture2D atlas
	{
		[Address(RVA = "0x1BBC570", Offset = "0x1BBB770", Length = "0x20")]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002886")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000A28")]
	protected private bool disposed
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002888")]
		 get { } //Length: 5
		[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002889")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1BBBF20", Offset = "0x1BBB120", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600288F")]
	private static VectorImageManager() { }

	[Address(RVA = "0x1BBC020", Offset = "0x1BBB220", Length = "0x54A")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSettingsAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6002887")]
	public VectorImageManager(AtlasBase atlas) { }

	[Address(RVA = "0x1BBB7E0", Offset = "0x1BBA9E0", Length = "0xF3")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VectorImageManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(VectorImageRenderInfo))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288D")]
	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	[Address(RVA = "0x1BBB8E0", Offset = "0x1BBAAE0", Length = "0x2F")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GradientSettingsAtlas), Member = "Commit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288C")]
	public void Commit() { }

	[Address(RVA = "0x1BBBA30", Offset = "0x1BBAC30", Length = "0x61")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600288A")]
	public override void Dispose() { }

	[Address(RVA = "0x1BBB910", Offset = "0x1BBAB10", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSettingsAtlas), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288B")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1BBC570", Offset = "0x1BBB770", Length = "0x20")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002886")]
	public Texture2D get_atlas() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002888")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1BBBAA0", Offset = "0x1BBACA0", Length = "0x47F")]
	[CalledBy(Type = typeof(VectorImageManager), Member = "AddUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(GradientRemap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(GradientSettingsAtlas), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc), typeof(GradientSettings[]), typeof(GradientRemap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GradientSettingsAtlas), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600288E")]
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002889")]
	private void set_disposed(bool value) { }

}

