namespace UnityEngine.UI;

[AddComponentMenu("Layout/Layout Element", 140)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200004D")]
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000173")]
	private bool m_IgnoreLayout; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000174")]
	private float m_MinWidth; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000175")]
	private float m_MinHeight; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000176")]
	private float m_PreferredWidth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000177")]
	private float m_PreferredHeight; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000178")]
	private float m_FlexibleWidth; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000179")]
	private float m_FlexibleHeight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400017A")]
	private int m_LayoutPriority; //Field offset: 0x3C

	[Token(Token = "0x170000C5")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC0690", Offset = "0x1CBF890", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002D1")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C4")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CE")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC06F0", Offset = "0x1CBF8F0", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002CF")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000BF")]
	public override bool ignoreLayout
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C2")]
		 get { } //Length: 5
		[Address(RVA = "0x1CC0750", Offset = "0x1CBF950", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002C3")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C6")]
	public override int layoutPriority
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D2")]
		 get { } //Length: 4
		[Address(RVA = "0x1CC07B0", Offset = "0x1CBF9B0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002D3")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170000C1")]
	public override float minHeight
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C8")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC0810", Offset = "0x1CBFA10", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002C9")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C0")]
	public override float minWidth
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C6")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC0870", Offset = "0x1CBFA70", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002C7")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C3")]
	public override float preferredHeight
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CC")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC08D0", Offset = "0x1CBFAD0", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002CD")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C2")]
	public override float preferredWidth
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CA")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC0930", Offset = "0x1CBFB30", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[Token(Token = "0x60002CB")]
		 set { } //Length: 89
	}

	[Address(RVA = "0x1CC0650", Offset = "0x1CBF850", Length = "0x38")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002D4")]
	protected LayoutElement() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C4")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C5")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D0")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CE")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C2")]
	public override bool get_ignoreLayout() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D2")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C8")]
	public override float get_minHeight() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C6")]
	public override float get_minWidth() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CC")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CA")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x1CC0560", Offset = "0x1CBF760", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D9")]
	protected virtual void OnBeforeTransformParentChanged() { }

	[Address(RVA = "0x1CC0560", Offset = "0x1CBF760", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D8")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1CC0570", Offset = "0x1CBF770", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002D7")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CC0590", Offset = "0x1CBF790", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002D5")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CC0560", Offset = "0x1CBF760", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D6")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1CC0690", Offset = "0x1CBF890", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002D1")]
	public override void set_flexibleHeight(float value) { }

	[Address(RVA = "0x1CC06F0", Offset = "0x1CBF8F0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002CF")]
	public override void set_flexibleWidth(float value) { }

	[Address(RVA = "0x1CC0750", Offset = "0x1CBF950", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002C3")]
	public override void set_ignoreLayout(bool value) { }

	[Address(RVA = "0x1CC07B0", Offset = "0x1CBF9B0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002D3")]
	public override void set_layoutPriority(int value) { }

	[Address(RVA = "0x1CC0810", Offset = "0x1CBFA10", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002C9")]
	public override void set_minHeight(float value) { }

	[Address(RVA = "0x1CC0870", Offset = "0x1CBFA70", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002C7")]
	public override void set_minWidth(float value) { }

	[Address(RVA = "0x1CC08D0", Offset = "0x1CBFAD0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002CD")]
	public override void set_preferredHeight(float value) { }

	[Address(RVA = "0x1CC0930", Offset = "0x1CBFB30", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x60002CB")]
	public override void set_preferredWidth(float value) { }

	[Address(RVA = "0x1CC05B0", Offset = "0x1CBF7B0", Length = "0x94")]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_layoutPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_flexibleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_flexibleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_preferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_ignoreLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_preferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DA")]
	protected void SetDirty() { }

}

