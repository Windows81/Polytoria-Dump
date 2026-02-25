namespace Polytoria.Datamodel;

[Token(Token = "0x2000369")]
public class UIHVLayout : UIField
{
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000E92")]
	protected HorizontalOrVerticalLayoutGroup layoutGroup; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[SyncVar(hook = "SyncSpacing")]
	[Token(Token = "0x4000E93")]
	protected float spacing; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A4")]
	[SyncVar(hook = "SyncChildControlWidth")]
	[Token(Token = "0x4000E94")]
	protected bool childControlWidth; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A5")]
	[SyncVar(hook = "SyncChildControlHeight")]
	[Token(Token = "0x4000E95")]
	protected bool childControlHeight; //Field offset: 0x1A5
	[FieldOffset(Offset = "0x1A6")]
	[SyncVar(hook = "SyncChildScaleWidth")]
	[Token(Token = "0x4000E96")]
	protected bool childScaleWidth; //Field offset: 0x1A6
	[FieldOffset(Offset = "0x1A7")]
	[SyncVar(hook = "SyncChildScaleHeight")]
	[Token(Token = "0x4000E97")]
	protected bool childScaleHeight; //Field offset: 0x1A7
	[FieldOffset(Offset = "0x1A8")]
	[SyncVar(hook = "SyncChildForceExpandWidth")]
	[Token(Token = "0x4000E98")]
	protected bool childForceExpandWidth; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1A9")]
	[SyncVar(hook = "SyncChildForceExpandHeight")]
	[Token(Token = "0x4000E99")]
	protected bool childForceExpandHeight; //Field offset: 0x1A9
	[FieldOffset(Offset = "0x1AC")]
	[SyncVar(hook = "SyncPaddingLeft")]
	[Token(Token = "0x4000E9A")]
	protected int paddingLeft; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[SyncVar(hook = "SyncPaddingRight")]
	[Token(Token = "0x4000E9B")]
	protected int paddingRight; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[SyncVar(hook = "SyncPaddingTop")]
	[Token(Token = "0x4000E9C")]
	protected int paddingTop; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[SyncVar(hook = "SyncPaddingBottom")]
	[Token(Token = "0x4000E9D")]
	protected int paddingBottom; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[SyncVar(hook = "SyncChildAlignment")]
	[Token(Token = "0x4000E9E")]
	protected TextAnchor childAlignment; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[SyncVar(hook = "SyncReverseAlignment")]
	[Token(Token = "0x4000E9F")]
	protected bool reverseAlignment; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000EA0")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_spacing; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000EA1")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childControlWidth; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000EA2")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childControlHeight; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000EA3")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childScaleWidth; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000EA4")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childScaleHeight; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000EA5")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childForceExpandWidth; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000EA6")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_childForceExpandHeight; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000EA7")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingLeft; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000EA8")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingRight; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000EA9")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingTop; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000EAA")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_paddingBottom; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000EAB")]
	public Action<TextAnchor, TextAnchor> _Mirror_SyncVarHookDelegate_childAlignment; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EAC")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_reverseAlignment; //Field offset: 0x228

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000ADE")]
	public TextAnchor ChildAlignment
	{
		[Address(RVA = "0x495CB0", Offset = "0x494EB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002453")]
		 get { } //Length: 7
		[Address(RVA = "0x495D60", Offset = "0x494F60", Length = "0x7F")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor), typeof(TextAnchor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(LayoutGroup), Member = "set_childAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002454")]
		 set { } //Length: 127
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AD5")]
	public bool ChildControlHeight
	{
		[Address(RVA = "0x495CC0", Offset = "0x494EC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002441")]
		 get { } //Length: 8
		[Address(RVA = "0x495DE0", Offset = "0x494FE0", Length = "0x84")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002442")]
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AD4")]
	public bool ChildControlWidth
	{
		[Address(RVA = "0x495CD0", Offset = "0x494ED0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600243F")]
		 get { } //Length: 8
		[Address(RVA = "0x495E70", Offset = "0x495070", Length = "0x84")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002440")]
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AD9")]
	public bool ChildForceExpandHeight
	{
		[Address(RVA = "0x495CE0", Offset = "0x494EE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002449")]
		 get { } //Length: 8
		[Address(RVA = "0x495F00", Offset = "0x495100", Length = "0x84")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600244A")]
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AD8")]
	public bool ChildForceExpandWidth
	{
		[Address(RVA = "0x495CF0", Offset = "0x494EF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002447")]
		 get { } //Length: 8
		[Address(RVA = "0x495F90", Offset = "0x495190", Length = "0x84")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002448")]
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AD7")]
	public bool ChildScaleHeight
	{
		[Address(RVA = "0x495D00", Offset = "0x494F00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002445")]
		 get { } //Length: 8
		[Address(RVA = "0x496020", Offset = "0x495220", Length = "0x84")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002446")]
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AD6")]
	public bool ChildScaleWidth
	{
		[Address(RVA = "0x495D10", Offset = "0x494F10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002443")]
		 get { } //Length: 8
		[Address(RVA = "0x4960B0", Offset = "0x4952B0", Length = "0x84")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002444")]
		 set { } //Length: 132
	}

	[Token(Token = "0x17000AEB")]
	public TextAnchor NetworkchildAlignment
	{
		[Address(RVA = "0x495CB0", Offset = "0x494EB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600247F")]
		 get { } //Length: 7
		[Address(RVA = "0x496140", Offset = "0x495340", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002480")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000AE2")]
	public bool NetworkchildControlHeight
	{
		[Address(RVA = "0x495CC0", Offset = "0x494EC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246D")]
		 get { } //Length: 8
		[Address(RVA = "0x4961B0", Offset = "0x4953B0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x600246E")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AE1")]
	public bool NetworkchildControlWidth
	{
		[Address(RVA = "0x495CD0", Offset = "0x494ED0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246B")]
		 get { } //Length: 8
		[Address(RVA = "0x496220", Offset = "0x495420", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x600246C")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AE6")]
	public bool NetworkchildForceExpandHeight
	{
		[Address(RVA = "0x495CE0", Offset = "0x494EE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002475")]
		 get { } //Length: 8
		[Address(RVA = "0x496290", Offset = "0x495490", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002476")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AE5")]
	public bool NetworkchildForceExpandWidth
	{
		[Address(RVA = "0x495CF0", Offset = "0x494EF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002473")]
		 get { } //Length: 8
		[Address(RVA = "0x496300", Offset = "0x495500", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002474")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AE4")]
	public bool NetworkchildScaleHeight
	{
		[Address(RVA = "0x495D00", Offset = "0x494F00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002471")]
		 get { } //Length: 8
		[Address(RVA = "0x496370", Offset = "0x495570", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002472")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AE3")]
	public bool NetworkchildScaleWidth
	{
		[Address(RVA = "0x495D10", Offset = "0x494F10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246F")]
		 get { } //Length: 8
		[Address(RVA = "0x4963E0", Offset = "0x4955E0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002470")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AEA")]
	public int NetworkpaddingBottom
	{
		[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600247D")]
		 get { } //Length: 7
		[Address(RVA = "0x496450", Offset = "0x495650", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Token(Token = "0x600247E")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000AE7")]
	public int NetworkpaddingLeft
	{
		[Address(RVA = "0x460220", Offset = "0x45F420", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002477")]
		 get { } //Length: 7
		[Address(RVA = "0x4964C0", Offset = "0x4956C0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Token(Token = "0x6002478")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000AE8")]
	public int NetworkpaddingRight
	{
		[Address(RVA = "0x45FC20", Offset = "0x45EE20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002479")]
		 get { } //Length: 7
		[Address(RVA = "0x496530", Offset = "0x495730", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Token(Token = "0x600247A")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000AE9")]
	public int NetworkpaddingTop
	{
		[Address(RVA = "0x495D30", Offset = "0x494F30", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600247B")]
		 get { } //Length: 7
		[Address(RVA = "0x4965A0", Offset = "0x4957A0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Token(Token = "0x600247C")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000AEC")]
	public bool NetworkreverseAlignment
	{
		[Address(RVA = "0x495D40", Offset = "0x494F40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002481")]
		 get { } //Length: 8
		[Address(RVA = "0x496610", Offset = "0x495810", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002482")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AE0")]
	public float Networkspacing
	{
		[Address(RVA = "0x495D50", Offset = "0x494F50", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002469")]
		 get { } //Length: 9
		[Address(RVA = "0x496680", Offset = "0x495880", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x600246A")]
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000ADD")]
	public int PaddingBottom
	{
		[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002451")]
		 get { } //Length: 7
		[Address(RVA = "0x4966F0", Offset = "0x4958F0", Length = "0x88")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Calls(Type = typeof(RectOffset), Member = "set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002452")]
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000ADA")]
	public int PaddingLeft
	{
		[Address(RVA = "0x460220", Offset = "0x45F420", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600244B")]
		 get { } //Length: 7
		[Address(RVA = "0x496780", Offset = "0x495980", Length = "0x88")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Calls(Type = typeof(RectOffset), Member = "set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600244C")]
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000ADB")]
	public int PaddingRight
	{
		[Address(RVA = "0x45FC20", Offset = "0x45EE20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600244D")]
		 get { } //Length: 7
		[Address(RVA = "0x496810", Offset = "0x495A10", Length = "0x88")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Calls(Type = typeof(RectOffset), Member = "set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600244E")]
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000ADC")]
	public int PaddingTop
	{
		[Address(RVA = "0x495D30", Offset = "0x494F30", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600244F")]
		 get { } //Length: 7
		[Address(RVA = "0x4968A0", Offset = "0x495AA0", Length = "0x88")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Calls(Type = typeof(RectOffset), Member = "set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002450")]
		 set { } //Length: 136
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000ADF")]
	public bool ReverseAlignment
	{
		[Address(RVA = "0x495D40", Offset = "0x494F40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002455")]
		 get { } //Length: 8
		[Address(RVA = "0x496930", Offset = "0x495B30", Length = "0x84")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_reverseArrangement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002456")]
		 set { } //Length: 132
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AD3")]
	public float Spacing
	{
		[Address(RVA = "0x495D50", Offset = "0x494F50", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600243D")]
		 get { } //Length: 9
		[Address(RVA = "0x4969C0", Offset = "0x495BC0", Length = "0x83")]
		[CalledBy(Type = typeof(UIHVLayout), Member = "SyncSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600243E")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x4958B0", Offset = "0x494AB0", Length = "0x3FC")]
	[CalledBy(Type = typeof(UIHorizontalLayout), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIVerticalLayout), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002467")]
	public UIHVLayout() { }

	[Address(RVA = "0x494D50", Offset = "0x493F50", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIHVLayout), Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002466")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x494ED0", Offset = "0x4940D0", Length = "0x5E8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(System.Action`2<System.Int32, System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(System.Action`2<System.Int32Enum, System.Int32Enum>), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002484")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x495CB0", Offset = "0x494EB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002453")]
	public TextAnchor get_ChildAlignment() { }

	[Address(RVA = "0x495CC0", Offset = "0x494EC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002441")]
	public bool get_ChildControlHeight() { }

	[Address(RVA = "0x495CD0", Offset = "0x494ED0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600243F")]
	public bool get_ChildControlWidth() { }

	[Address(RVA = "0x495CE0", Offset = "0x494EE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002449")]
	public bool get_ChildForceExpandHeight() { }

	[Address(RVA = "0x495CF0", Offset = "0x494EF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002447")]
	public bool get_ChildForceExpandWidth() { }

	[Address(RVA = "0x495D00", Offset = "0x494F00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002445")]
	public bool get_ChildScaleHeight() { }

	[Address(RVA = "0x495D10", Offset = "0x494F10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002443")]
	public bool get_ChildScaleWidth() { }

	[Address(RVA = "0x495CB0", Offset = "0x494EB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600247F")]
	public TextAnchor get_NetworkchildAlignment() { }

	[Address(RVA = "0x495CC0", Offset = "0x494EC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246D")]
	public bool get_NetworkchildControlHeight() { }

	[Address(RVA = "0x495CD0", Offset = "0x494ED0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246B")]
	public bool get_NetworkchildControlWidth() { }

	[Address(RVA = "0x495CE0", Offset = "0x494EE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002475")]
	public bool get_NetworkchildForceExpandHeight() { }

	[Address(RVA = "0x495CF0", Offset = "0x494EF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002473")]
	public bool get_NetworkchildForceExpandWidth() { }

	[Address(RVA = "0x495D00", Offset = "0x494F00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002471")]
	public bool get_NetworkchildScaleHeight() { }

	[Address(RVA = "0x495D10", Offset = "0x494F10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246F")]
	public bool get_NetworkchildScaleWidth() { }

	[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600247D")]
	public int get_NetworkpaddingBottom() { }

	[Address(RVA = "0x460220", Offset = "0x45F420", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002477")]
	public int get_NetworkpaddingLeft() { }

	[Address(RVA = "0x45FC20", Offset = "0x45EE20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002479")]
	public int get_NetworkpaddingRight() { }

	[Address(RVA = "0x495D30", Offset = "0x494F30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600247B")]
	public int get_NetworkpaddingTop() { }

	[Address(RVA = "0x495D40", Offset = "0x494F40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002481")]
	public bool get_NetworkreverseAlignment() { }

	[Address(RVA = "0x495D50", Offset = "0x494F50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002469")]
	public float get_Networkspacing() { }

	[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002451")]
	public int get_PaddingBottom() { }

	[Address(RVA = "0x460220", Offset = "0x45F420", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600244B")]
	public int get_PaddingLeft() { }

	[Address(RVA = "0x45FC20", Offset = "0x45EE20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600244D")]
	public int get_PaddingRight() { }

	[Address(RVA = "0x495D30", Offset = "0x494F30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600244F")]
	public int get_PaddingTop() { }

	[Address(RVA = "0x495D40", Offset = "0x494F40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002455")]
	public bool get_ReverseAlignment() { }

	[Address(RVA = "0x495D50", Offset = "0x494F50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600243D")]
	public float get_Spacing() { }

	[Address(RVA = "0x4954C0", Offset = "0x4946C0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002465")]
	private void LateUpdate() { }

	[Address(RVA = "0x495550", Offset = "0x494750", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002483")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x495D60", Offset = "0x494F60", Length = "0x7F")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor), typeof(TextAnchor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(LayoutGroup), Member = "set_childAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002454")]
	public void set_ChildAlignment(TextAnchor value) { }

	[Address(RVA = "0x495DE0", Offset = "0x494FE0", Length = "0x84")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002442")]
	public void set_ChildControlHeight(bool value) { }

	[Address(RVA = "0x495E70", Offset = "0x495070", Length = "0x84")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002440")]
	public void set_ChildControlWidth(bool value) { }

	[Address(RVA = "0x495F00", Offset = "0x495100", Length = "0x84")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600244A")]
	public void set_ChildForceExpandHeight(bool value) { }

	[Address(RVA = "0x495F90", Offset = "0x495190", Length = "0x84")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002448")]
	public void set_ChildForceExpandWidth(bool value) { }

	[Address(RVA = "0x496020", Offset = "0x495220", Length = "0x84")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002446")]
	public void set_ChildScaleHeight(bool value) { }

	[Address(RVA = "0x4960B0", Offset = "0x4952B0", Length = "0x84")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002444")]
	public void set_ChildScaleWidth(bool value) { }

	[Address(RVA = "0x496140", Offset = "0x495340", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002480")]
	public void set_NetworkchildAlignment(in TextAnchor value) { }

	[Address(RVA = "0x4961B0", Offset = "0x4953B0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x600246E")]
	public void set_NetworkchildControlHeight(in bool value) { }

	[Address(RVA = "0x496220", Offset = "0x495420", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x600246C")]
	public void set_NetworkchildControlWidth(in bool value) { }

	[Address(RVA = "0x496290", Offset = "0x495490", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002476")]
	public void set_NetworkchildForceExpandHeight(in bool value) { }

	[Address(RVA = "0x496300", Offset = "0x495500", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002474")]
	public void set_NetworkchildForceExpandWidth(in bool value) { }

	[Address(RVA = "0x496370", Offset = "0x495570", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002472")]
	public void set_NetworkchildScaleHeight(in bool value) { }

	[Address(RVA = "0x4963E0", Offset = "0x4955E0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002470")]
	public void set_NetworkchildScaleWidth(in bool value) { }

	[Address(RVA = "0x496450", Offset = "0x495650", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Token(Token = "0x600247E")]
	public void set_NetworkpaddingBottom(in int value) { }

	[Address(RVA = "0x4964C0", Offset = "0x4956C0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Token(Token = "0x6002478")]
	public void set_NetworkpaddingLeft(in int value) { }

	[Address(RVA = "0x496530", Offset = "0x495730", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Token(Token = "0x600247A")]
	public void set_NetworkpaddingRight(in int value) { }

	[Address(RVA = "0x4965A0", Offset = "0x4957A0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Token(Token = "0x600247C")]
	public void set_NetworkpaddingTop(in int value) { }

	[Address(RVA = "0x496610", Offset = "0x495810", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002482")]
	public void set_NetworkreverseAlignment(in bool value) { }

	[Address(RVA = "0x496680", Offset = "0x495880", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x600246A")]
	public void set_Networkspacing(in float value) { }

	[Address(RVA = "0x4966F0", Offset = "0x4958F0", Length = "0x88")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(RectOffset), Member = "set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002452")]
	public void set_PaddingBottom(int value) { }

	[Address(RVA = "0x496780", Offset = "0x495980", Length = "0x88")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(RectOffset), Member = "set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600244C")]
	public void set_PaddingLeft(int value) { }

	[Address(RVA = "0x496810", Offset = "0x495A10", Length = "0x88")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(RectOffset), Member = "set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600244E")]
	public void set_PaddingRight(int value) { }

	[Address(RVA = "0x4968A0", Offset = "0x495AA0", Length = "0x88")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncPaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(RectOffset), Member = "set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002450")]
	public void set_PaddingTop(int value) { }

	[Address(RVA = "0x496930", Offset = "0x495B30", Length = "0x84")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_reverseArrangement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002456")]
	public void set_ReverseAlignment(bool value) { }

	[Address(RVA = "0x4969C0", Offset = "0x495BC0", Length = "0x83")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SyncSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayoutProxy), Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600243E")]
	public void set_Spacing(float value) { }

	[Address(RVA = "0x493BF0", Offset = "0x492DF0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002464")]
	protected virtual void Start() { }

	[Address(RVA = "0x4957E0", Offset = "0x4949E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002462")]
	private void SyncChildAlignment(TextAnchor oldValue, TextAnchor newValue) { }

	[Address(RVA = "0x4957F0", Offset = "0x4949F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002459")]
	private void SyncChildControlHeight(bool oldValue, bool newValue) { }

	[Address(RVA = "0x495800", Offset = "0x494A00", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002458")]
	private void SyncChildControlWidth(bool oldValue, bool newValue) { }

	[Address(RVA = "0x495810", Offset = "0x494A10", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600245D")]
	private void SyncChildForceExpandHeight(bool oldValue, bool newValue) { }

	[Address(RVA = "0x495820", Offset = "0x494A20", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600245C")]
	private void SyncChildForceExpandWidth(bool oldValue, bool newValue) { }

	[Address(RVA = "0x495830", Offset = "0x494A30", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600245B")]
	private void SyncChildScaleHeight(bool oldValue, bool newValue) { }

	[Address(RVA = "0x495840", Offset = "0x494A40", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600245A")]
	private void SyncChildScaleWidth(bool oldValue, bool newValue) { }

	[Address(RVA = "0x495850", Offset = "0x494A50", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002461")]
	private void SyncPaddingBottom(int oldValue, int newValue) { }

	[Address(RVA = "0x495860", Offset = "0x494A60", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600245E")]
	private void SyncPaddingLeft(int oldValue, int newValue) { }

	[Address(RVA = "0x495870", Offset = "0x494A70", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600245F")]
	private void SyncPaddingRight(int oldValue, int newValue) { }

	[Address(RVA = "0x495880", Offset = "0x494A80", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002460")]
	private void SyncPaddingTop(int oldValue, int newValue) { }

	[Address(RVA = "0x495890", Offset = "0x494A90", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002463")]
	private void SyncReverseAlignment(bool oldValue, bool newValue) { }

	[Address(RVA = "0x4958A0", Offset = "0x494AA0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002457")]
	private void SyncSpacing(float oldValue, float newValue) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002468")]
	public virtual bool Weaved() { }

}

