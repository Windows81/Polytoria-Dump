namespace UnityEngine.UI;

[ExecuteAlways]
[Token(Token = "0x2000047")]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
{
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400016B")]
	protected float m_Spacing; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400016C")]
	protected bool m_ChildForceExpandWidth; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[SerializeField]
	[Token(Token = "0x400016D")]
	protected bool m_ChildForceExpandHeight; //Field offset: 0x65
	[FieldOffset(Offset = "0x66")]
	[SerializeField]
	[Token(Token = "0x400016E")]
	protected bool m_ChildControlWidth; //Field offset: 0x66
	[FieldOffset(Offset = "0x67")]
	[SerializeField]
	[Token(Token = "0x400016F")]
	protected bool m_ChildControlHeight; //Field offset: 0x67
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000170")]
	protected bool m_ChildScaleWidth; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[SerializeField]
	[Token(Token = "0x4000171")]
	protected bool m_ChildScaleHeight; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[SerializeField]
	[Token(Token = "0x4000172")]
	protected bool m_ReverseArrangement; //Field offset: 0x6A

	[Token(Token = "0x170000B3")]
	public bool childControlHeight
	{
		[Address(RVA = "0x1609250", Offset = "0x1608450", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002AA")]
		 get { } //Length: 5
		[Address(RVA = "0x1CB4DF0", Offset = "0x1CB3FF0", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002AB")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B2")]
	public bool childControlWidth
	{
		[Address(RVA = "0x1609240", Offset = "0x1608440", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A8")]
		 get { } //Length: 5
		[Address(RVA = "0x1CB4E40", Offset = "0x1CB4040", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002A9")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B1")]
	public bool childForceExpandHeight
	{
		[Address(RVA = "0x1609230", Offset = "0x1608430", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A6")]
		 get { } //Length: 5
		[Address(RVA = "0x1CB4E90", Offset = "0x1CB4090", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002A7")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B0")]
	public bool childForceExpandWidth
	{
		[Address(RVA = "0x16091A0", Offset = "0x16083A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A4")]
		 get { } //Length: 5
		[Address(RVA = "0x1CB4EE0", Offset = "0x1CB40E0", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002A5")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B5")]
	public bool childScaleHeight
	{
		[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002AE")]
		 get { } //Length: 5
		[Address(RVA = "0x1CB4F30", Offset = "0x1CB4130", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002AF")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B4")]
	public bool childScaleWidth
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002AC")]
		 get { } //Length: 5
		[Address(RVA = "0x1CB4F80", Offset = "0x1CB4180", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002AD")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B6")]
	public bool reverseArrangement
	{
		[Address(RVA = "0x17658A0", Offset = "0x1764AA0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B0")]
		 get { } //Length: 5
		[Address(RVA = "0x1CB4FD0", Offset = "0x1CB41D0", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002B1")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000AF")]
	public float spacing
	{
		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A2")]
		 get { } //Length: 6
		[Address(RVA = "0x1CB5020", Offset = "0x1CB4220", Length = "0x4D")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x60002A3")]
		 set { } //Length: 77
	}

	[Address(RVA = "0x1CB3FA0", Offset = "0x1CB31A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B5")]
	protected HorizontalOrVerticalLayoutGroup() { }

	[Address(RVA = "0x1CB3FB0", Offset = "0x1CB31B0", Length = "0x3F0")]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002B2")]
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	[Address(RVA = "0x1609250", Offset = "0x1608450", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AA")]
	public bool get_childControlHeight() { }

	[Address(RVA = "0x1609240", Offset = "0x1608440", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A8")]
	public bool get_childControlWidth() { }

	[Address(RVA = "0x1609230", Offset = "0x1608430", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A6")]
	public bool get_childForceExpandHeight() { }

	[Address(RVA = "0x16091A0", Offset = "0x16083A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A4")]
	public bool get_childForceExpandWidth() { }

	[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AE")]
	public bool get_childScaleHeight() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AC")]
	public bool get_childScaleWidth() { }

	[Address(RVA = "0x17658A0", Offset = "0x1764AA0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B0")]
	public bool get_reverseArrangement() { }

	[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A2")]
	public float get_spacing() { }

	[Address(RVA = "0x1CB43B0", Offset = "0x1CB35B0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60002B4")]
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	[Address(RVA = "0x1CB4DF0", Offset = "0x1CB3FF0", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002AB")]
	public void set_childControlHeight(bool value) { }

	[Address(RVA = "0x1CB4E40", Offset = "0x1CB4040", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A9")]
	public void set_childControlWidth(bool value) { }

	[Address(RVA = "0x1CB4E90", Offset = "0x1CB4090", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A7")]
	public void set_childForceExpandHeight(bool value) { }

	[Address(RVA = "0x1CB4EE0", Offset = "0x1CB40E0", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A5")]
	public void set_childForceExpandWidth(bool value) { }

	[Address(RVA = "0x1CB4F30", Offset = "0x1CB4130", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002AF")]
	public void set_childScaleHeight(bool value) { }

	[Address(RVA = "0x1CB4F80", Offset = "0x1CB4180", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002AD")]
	public void set_childScaleWidth(bool value) { }

	[Address(RVA = "0x1CB4FD0", Offset = "0x1CB41D0", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B1")]
	public void set_reverseArrangement(bool value) { }

	[Address(RVA = "0x1CB5020", Offset = "0x1CB4220", Length = "0x4D")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A3")]
	public void set_spacing(float value) { }

	[Address(RVA = "0x1CB44C0", Offset = "0x1CB36C0", Length = "0x921")]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002B3")]
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

}

