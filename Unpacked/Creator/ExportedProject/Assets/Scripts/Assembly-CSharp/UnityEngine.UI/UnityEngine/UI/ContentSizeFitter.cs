namespace UnityEngine.UI;

[AddComponentMenu("Layout/Content Size Fitter", 141)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000040")]
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	[Token(Token = "0x2000041")]
	internal enum FitMode
	{
		Unconstrained = 0,
		MinSize = 1,
		PreferredSize = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000151")]
	protected FitMode m_HorizontalFit; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000152")]
	protected FitMode m_VerticalFit; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000153")]
	private RectTransform m_Rect; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000154")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x30

	[Token(Token = "0x170000A6")]
	public FitMode horizontalFit
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600027E")]
		 get { } //Length: 4
		[Address(RVA = "0x1CB3030", Offset = "0x1CB2230", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x600027F")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170000A8")]
	private RectTransform rectTransform
	{
		[Address(RVA = "0x1CB2FA0", Offset = "0x1CB21A0", Length = "0x8D")]
		[CalledBy(Type = typeof(ContentSizeFitter), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000282")]
		private get { } //Length: 141
	}

	[Token(Token = "0x170000A7")]
	public FitMode verticalFit
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000280")]
		 get { } //Length: 4
		[Address(RVA = "0x1CB3090", Offset = "0x1CB2290", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x6000281")]
		 set { } //Length: 86
	}

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000283")]
	protected ContentSizeFitter() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027E")]
	public FitMode get_horizontalFit() { }

	[Address(RVA = "0x1CB2FA0", Offset = "0x1CB21A0", Length = "0x8D")]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000282")]
	private RectTransform get_rectTransform() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000280")]
	public FitMode get_verticalFit() { }

	[Address(RVA = "0x1CB2D50", Offset = "0x1CB1F50", Length = "0xDB")]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContentSizeFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000287")]
	private void HandleSelfFittingAlongAxis(int axis) { }

	[Address(RVA = "0x1CB2E30", Offset = "0x1CB2030", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ContentSizeFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000285")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CB2EB0", Offset = "0x1CB20B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000284")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CB2ED0", Offset = "0x1CB20D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6000286")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1CB3030", Offset = "0x1CB2230", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600027F")]
	public void set_horizontalFit(FitMode value) { }

	[Address(RVA = "0x1CB3090", Offset = "0x1CB2290", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x6000281")]
	public void set_verticalFit(FitMode value) { }

	[Address(RVA = "0x1CB2EE0", Offset = "0x1CB20E0", Length = "0x76")]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "set_horizontalFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FitMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "set_verticalFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FitMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ContentSizeFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600028A")]
	protected void SetDirty() { }

	[Address(RVA = "0x1CB2F60", Offset = "0x1CB2160", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000288")]
	public override void SetLayoutHorizontal() { }

	[Address(RVA = "0x1CB2F90", Offset = "0x1CB2190", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000289")]
	public override void SetLayoutVertical() { }

}

