namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200003C")]
public struct BindingInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000137")]
	private readonly VisualElement <targetElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000138")]
	private readonly BindingId <bindingId>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000139")]
	private readonly Binding <binding>k__BackingField; //Field offset: 0xA0

	[Token(Token = "0x1700003C")]
	public Binding binding
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1A945C0", Offset = "0x1A937C0", Length = "0xDD")]
	[CalledBy(Type = typeof(BindingInfo), Member = "FromBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData&)}, ReturnType = typeof(BindingInfo))]
	[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001EF")]
	private BindingInfo(VisualElement targetElement, in BindingId bindingId, Binding binding) { }

	[Address(RVA = "0x1A94250", Offset = "0x1A93450", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(BindingInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001F1")]
	internal static BindingInfo FromBindingData(in BindingData bindingData) { }

	[Address(RVA = "0x1A94360", Offset = "0x1A93560", Length = "0x254")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001F0")]
	internal static BindingInfo FromRequest(VisualElement target, in PropertyPath targetPath, Binding binding) { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EE")]
	public Binding get_binding() { }

}

