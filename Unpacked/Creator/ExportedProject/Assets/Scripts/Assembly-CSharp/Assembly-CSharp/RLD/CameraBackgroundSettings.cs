namespace RLD;

[Token(Token = "0x2000124")]
public class CameraBackgroundSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400053F")]
	private Color _firstColor; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000540")]
	private Color _secondColor; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000541")]
	private float _gradientOffset; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000542")]
	private bool _isVisible; //Field offset: 0x4C

	[Token(Token = "0x170004B2")]
	public Color FirstColor
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DFC")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DFD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170004B4")]
	public float GradientOffset
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E00")]
		 get { } //Length: 6
		[Address(RVA = "0x538C40", Offset = "0x537E40", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E01")]
		 set { } //Length: 38
	}

	[Token(Token = "0x170004B5")]
	public bool IsVisible
	{
		[Address(RVA = "0x3095E0", Offset = "0x3087E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E02")]
		 get { } //Length: 5
		[Address(RVA = "0x309640", Offset = "0x308840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E03")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004B3")]
	public Color SecondColor
	{
		[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DFE")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DFF")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x538BC0", Offset = "0x537DC0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_CameraBkGradientFirstColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_CameraBkGradientSecondColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E04")]
	public CameraBackgroundSettings() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DFC")]
	public Color get_FirstColor() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E00")]
	public float get_GradientOffset() { }

	[Address(RVA = "0x3095E0", Offset = "0x3087E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E02")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DFE")]
	public Color get_SecondColor() { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DFD")]
	public void set_FirstColor(Color value) { }

	[Address(RVA = "0x538C40", Offset = "0x537E40", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E01")]
	public void set_GradientOffset(float value) { }

	[Address(RVA = "0x309640", Offset = "0x308840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E03")]
	public void set_IsVisible(bool value) { }

	[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DFF")]
	public void set_SecondColor(Color value) { }

}

