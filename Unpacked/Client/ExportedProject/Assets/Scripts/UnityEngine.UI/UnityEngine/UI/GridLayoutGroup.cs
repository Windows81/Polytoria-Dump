namespace UnityEngine.UI;

[AddComponentMenu("Layout/Grid Layout Group", 152)]
[Token(Token = "0x2000042")]
public class GridLayoutGroup : LayoutGroup
{
	[Token(Token = "0x2000044")]
	internal enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x2000045")]
	internal enum Constraint
	{
		Flexible = 0,
		FixedColumnCount = 1,
		FixedRowCount = 2,
	}

	[Token(Token = "0x2000043")]
	internal enum Corner
	{
		UpperLeft = 0,
		UpperRight = 1,
		LowerLeft = 2,
		LowerRight = 3,
	}

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000159")]
	protected Corner m_StartCorner; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400015A")]
	protected Axis m_StartAxis; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400015B")]
	protected Vector2 m_CellSize; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400015C")]
	protected Vector2 m_Spacing; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400015D")]
	protected Constraint m_Constraint; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x400015E")]
	protected int m_ConstraintCount; //Field offset: 0x7C

	[Token(Token = "0x170000AB")]
	public Vector2 cellSize
	{
		[Address(RVA = "0x96AC30", Offset = "0x969E30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028F")]
		 get { } //Length: 19
		[Address(RVA = "0x1CB3D30", Offset = "0x1CB2F30", Length = "0x51")]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000290")]
		 set { } //Length: 81
	}

	[Token(Token = "0x170000AD")]
	public Constraint constraint
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000293")]
		 get { } //Length: 4
		[Address(RVA = "0x1CB3DF0", Offset = "0x1CB2FF0", Length = "0x4B")]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		[Token(Token = "0x6000294")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000AE")]
	public int constraintCount
	{
		[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000295")]
		 get { } //Length: 4
		[Address(RVA = "0x1CB3D90", Offset = "0x1CB2F90", Length = "0x55")]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "set_ContainersPerGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000296")]
		 set { } //Length: 85
	}

	[Token(Token = "0x170000AC")]
	public Vector2 spacing
	{
		[Address(RVA = "0x96AB10", Offset = "0x969D10", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000291")]
		 get { } //Length: 19
		[Address(RVA = "0x1CB3E40", Offset = "0x1CB3040", Length = "0x51")]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000292")]
		 set { } //Length: 81
	}

	[Token(Token = "0x170000AA")]
	public Axis startAxis
	{
		[Address(RVA = "0x5215D0", Offset = "0x5207D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028D")]
		 get { } //Length: 4
		[Address(RVA = "0x1CB3EA0", Offset = "0x1CB30A0", Length = "0x4B")]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		[Token(Token = "0x600028E")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000A9")]
	public Corner startCorner
	{
		[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028B")]
		 get { } //Length: 4
		[Address(RVA = "0x1CB3EF0", Offset = "0x1CB30F0", Length = "0x4B")]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		[Token(Token = "0x600028C")]
		 set { } //Length: 75
	}

	[Address(RVA = "0x1CB3CC0", Offset = "0x1CB2EC0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000297")]
	protected GridLayoutGroup() { }

	[Address(RVA = "0x1CB3170", Offset = "0x1CB2370", Length = "0x1F7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000298")]
	public virtual void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x1CB3370", Offset = "0x1CB2570", Length = "0x1DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000299")]
	public virtual void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x96AC30", Offset = "0x969E30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028F")]
	public Vector2 get_cellSize() { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000293")]
	public Constraint get_constraint() { }

	[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000295")]
	public int get_constraintCount() { }

	[Address(RVA = "0x96AB10", Offset = "0x969D10", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000291")]
	public Vector2 get_spacing() { }

	[Address(RVA = "0x5215D0", Offset = "0x5207D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028D")]
	public Axis get_startAxis() { }

	[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028B")]
	public Corner get_startCorner() { }

	[Address(RVA = "0x1CB3D30", Offset = "0x1CB2F30", Length = "0x51")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000290")]
	public void set_cellSize(Vector2 value) { }

	[Address(RVA = "0x1CB3DF0", Offset = "0x1CB2FF0", Length = "0x4B")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000294")]
	public void set_constraint(Constraint value) { }

	[Address(RVA = "0x1CB3D90", Offset = "0x1CB2F90", Length = "0x55")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "set_ContainersPerGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000296")]
	public void set_constraintCount(int value) { }

	[Address(RVA = "0x1CB3E40", Offset = "0x1CB3040", Length = "0x51")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000292")]
	public void set_spacing(Vector2 value) { }

	[Address(RVA = "0x1CB3EA0", Offset = "0x1CB30A0", Length = "0x4B")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Token(Token = "0x600028E")]
	public void set_startAxis(Axis value) { }

	[Address(RVA = "0x1CB3EF0", Offset = "0x1CB30F0", Length = "0x4B")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Token(Token = "0x600028C")]
	public void set_startCorner(Corner value) { }

	[Address(RVA = "0x1CB3550", Offset = "0x1CB2750", Length = "0x743")]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805E6AE0")]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC010")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600029C")]
	private void SetCellsAlongAxis(int axis) { }

	[Address(RVA = "0x1CB3CA0", Offset = "0x1CB2EA0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600029A")]
	public virtual void SetLayoutHorizontal() { }

	[Address(RVA = "0x1CB3CB0", Offset = "0x1CB2EB0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600029B")]
	public virtual void SetLayoutVertical() { }

}

