namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003CB")]
public class UIImageProxy : UIFieldProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001015")]
	private readonly UIImage uiImage; //Field offset: 0x20

	[Token(Token = "0x17000C7E")]
	public bool Clickable
	{
		[Address(RVA = "0x4B5B30", Offset = "0x4B4D30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002947")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5BC0", Offset = "0x4B4DC0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIImage), Member = "set_Clickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002948")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C7D")]
	public Color Color
	{
		[Address(RVA = "0x4B5B50", Offset = "0x4B4D50", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002945")]
		 get { } //Length: 36
		[Address(RVA = "0x4B5BE0", Offset = "0x4B4DE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIImage), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002946")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C7B")]
	public string ImageID
	{
		[Address(RVA = "0x4B5B80", Offset = "0x4B4D80", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002941")]
		 get { } //Length: 30
		[Address(RVA = "0x4B5C10", Offset = "0x4B4E10", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIImage), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002942")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C7C")]
	public ImageType ImageType
	{
		[Address(RVA = "0x4B58D0", Offset = "0x4B4AD0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002943")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5C30", Offset = "0x4B4E30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIImage), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002944")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C7F")]
	public bool Loading
	{
		[Address(RVA = "0x4B5BA0", Offset = "0x4B4DA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002949")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002940")]
	public UIImageProxy(UIImage target) { }

	[Address(RVA = "0x4B5B30", Offset = "0x4B4D30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002947")]
	public bool get_Clickable() { }

	[Address(RVA = "0x4B5B50", Offset = "0x4B4D50", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002945")]
	public Color get_Color() { }

	[Address(RVA = "0x4B5B80", Offset = "0x4B4D80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002941")]
	public string get_ImageID() { }

	[Address(RVA = "0x4B58D0", Offset = "0x4B4AD0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002943")]
	public ImageType get_ImageType() { }

	[Address(RVA = "0x4B5BA0", Offset = "0x4B4DA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002949")]
	public bool get_Loading() { }

	[Address(RVA = "0x4B5BC0", Offset = "0x4B4DC0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIImage), Member = "set_Clickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002948")]
	public void set_Clickable(bool value) { }

	[Address(RVA = "0x4B5BE0", Offset = "0x4B4DE0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIImage), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002946")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4B5C10", Offset = "0x4B4E10", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIImage), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002942")]
	public void set_ImageID(string value) { }

	[Address(RVA = "0x4B5C30", Offset = "0x4B4E30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIImage), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002944")]
	public void set_ImageType(ImageType value) { }

}

