namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003CA")]
public class UIHVLayoutProxy : UIFieldProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001014")]
	private readonly UIHVLayout uiHVLayout; //Field offset: 0x20

	[Token(Token = "0x17000C79")]
	public TextAnchor ChildAlignment
	{
		[Address(RVA = "0x4B57F0", Offset = "0x4B49F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600293C")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5990", Offset = "0x4B4B90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600293D")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C70")]
	public bool ChildControlHeight
	{
		[Address(RVA = "0x4B5810", Offset = "0x4B4A10", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600292A")]
		 get { } //Length: 30
		[Address(RVA = "0x4B59B0", Offset = "0x4B4BB0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600292B")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C6F")]
	public bool ChildControlWidth
	{
		[Address(RVA = "0x4B5830", Offset = "0x4B4A30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002928")]
		 get { } //Length: 30
		[Address(RVA = "0x4B59D0", Offset = "0x4B4BD0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002929")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C74")]
	public bool ChildForceExpandHeight
	{
		[Address(RVA = "0x4B5850", Offset = "0x4B4A50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002932")]
		 get { } //Length: 30
		[Address(RVA = "0x4B59F0", Offset = "0x4B4BF0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002933")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C73")]
	public bool ChildForceExpandWidth
	{
		[Address(RVA = "0x4B5870", Offset = "0x4B4A70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002930")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5A10", Offset = "0x4B4C10", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002931")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C72")]
	public bool ChildScaleHeight
	{
		[Address(RVA = "0x4B5890", Offset = "0x4B4A90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600292E")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5A30", Offset = "0x4B4C30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600292F")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C71")]
	public bool ChildScaleWidth
	{
		[Address(RVA = "0x4B58B0", Offset = "0x4B4AB0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600292C")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5A50", Offset = "0x4B4C50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600292D")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C78")]
	public int PaddingBottom
	{
		[Address(RVA = "0x4B58D0", Offset = "0x4B4AD0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600293A")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5A70", Offset = "0x4B4C70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600293B")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C75")]
	public int PaddingLeft
	{
		[Address(RVA = "0x4B58F0", Offset = "0x4B4AF0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002934")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5A90", Offset = "0x4B4C90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002935")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C76")]
	public int PaddingRight
	{
		[Address(RVA = "0x4B5910", Offset = "0x4B4B10", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002936")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5AB0", Offset = "0x4B4CB0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002937")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C77")]
	public int PaddingTop
	{
		[Address(RVA = "0x4B5930", Offset = "0x4B4B30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002938")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5AD0", Offset = "0x4B4CD0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002939")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C7A")]
	public bool ReverseAlignment
	{
		[Address(RVA = "0x4B5950", Offset = "0x4B4B50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600293E")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5AF0", Offset = "0x4B4CF0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600293F")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C6E")]
	public float Spacing
	{
		[Address(RVA = "0x4B5970", Offset = "0x4B4B70", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002926")]
		 get { } //Length: 31
		[Address(RVA = "0x4B5B10", Offset = "0x4B4D10", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIHVLayout), Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002927")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002925")]
	public UIHVLayoutProxy(UIHVLayout target) { }

	[Address(RVA = "0x4B57F0", Offset = "0x4B49F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600293C")]
	public TextAnchor get_ChildAlignment() { }

	[Address(RVA = "0x4B5810", Offset = "0x4B4A10", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600292A")]
	public bool get_ChildControlHeight() { }

	[Address(RVA = "0x4B5830", Offset = "0x4B4A30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002928")]
	public bool get_ChildControlWidth() { }

	[Address(RVA = "0x4B5850", Offset = "0x4B4A50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002932")]
	public bool get_ChildForceExpandHeight() { }

	[Address(RVA = "0x4B5870", Offset = "0x4B4A70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002930")]
	public bool get_ChildForceExpandWidth() { }

	[Address(RVA = "0x4B5890", Offset = "0x4B4A90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600292E")]
	public bool get_ChildScaleHeight() { }

	[Address(RVA = "0x4B58B0", Offset = "0x4B4AB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600292C")]
	public bool get_ChildScaleWidth() { }

	[Address(RVA = "0x4B58D0", Offset = "0x4B4AD0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600293A")]
	public int get_PaddingBottom() { }

	[Address(RVA = "0x4B58F0", Offset = "0x4B4AF0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002934")]
	public int get_PaddingLeft() { }

	[Address(RVA = "0x4B5910", Offset = "0x4B4B10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002936")]
	public int get_PaddingRight() { }

	[Address(RVA = "0x4B5930", Offset = "0x4B4B30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002938")]
	public int get_PaddingTop() { }

	[Address(RVA = "0x4B5950", Offset = "0x4B4B50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600293E")]
	public bool get_ReverseAlignment() { }

	[Address(RVA = "0x4B5970", Offset = "0x4B4B70", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002926")]
	public float get_Spacing() { }

	[Address(RVA = "0x4B5990", Offset = "0x4B4B90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600293D")]
	public void set_ChildAlignment(TextAnchor value) { }

	[Address(RVA = "0x4B59B0", Offset = "0x4B4BB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600292B")]
	public void set_ChildControlHeight(bool value) { }

	[Address(RVA = "0x4B59D0", Offset = "0x4B4BD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002929")]
	public void set_ChildControlWidth(bool value) { }

	[Address(RVA = "0x4B59F0", Offset = "0x4B4BF0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002933")]
	public void set_ChildForceExpandHeight(bool value) { }

	[Address(RVA = "0x4B5A10", Offset = "0x4B4C10", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002931")]
	public void set_ChildForceExpandWidth(bool value) { }

	[Address(RVA = "0x4B5A30", Offset = "0x4B4C30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600292F")]
	public void set_ChildScaleHeight(bool value) { }

	[Address(RVA = "0x4B5A50", Offset = "0x4B4C50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ChildScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600292D")]
	public void set_ChildScaleWidth(bool value) { }

	[Address(RVA = "0x4B5A70", Offset = "0x4B4C70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600293B")]
	public void set_PaddingBottom(int value) { }

	[Address(RVA = "0x4B5A90", Offset = "0x4B4C90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002935")]
	public void set_PaddingLeft(int value) { }

	[Address(RVA = "0x4B5AB0", Offset = "0x4B4CB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002937")]
	public void set_PaddingRight(int value) { }

	[Address(RVA = "0x4B5AD0", Offset = "0x4B4CD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002939")]
	public void set_PaddingTop(int value) { }

	[Address(RVA = "0x4B5AF0", Offset = "0x4B4CF0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_ReverseAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600293F")]
	public void set_ReverseAlignment(bool value) { }

	[Address(RVA = "0x4B5B10", Offset = "0x4B4D10", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIHVLayout), Member = "set_Spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002927")]
	public void set_Spacing(float value) { }

}

