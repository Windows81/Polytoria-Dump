namespace RLD;

[Token(Token = "0x2000140")]
public class CameraZoomSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40005BB")]
	private CameraZoomMode _zoomMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40005BC")]
	private float _orthoStandardZoomSensitivity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40005BD")]
	private float _perspStandardZoomSensitivity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40005BE")]
	private float _orthoSmoothZoomSensitivity; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40005BF")]
	private float _perspSmoothZoomSensitivity; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40005C0")]
	private float _orthoZoomSmoothValue; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40005C1")]
	private float _perspZoomSmoothValue; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40005C2")]
	private bool _invertZoomAxis; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	[Token(Token = "0x40005C3")]
	private bool _isZoomEnabled; //Field offset: 0x45

	[Token(Token = "0x1700050B")]
	public bool InvertZoomAxis
	{
		[Address(RVA = "0x53EA60", Offset = "0x53DC60", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB7")]
		 get { } //Length: 5
		[Address(RVA = "0x53EA80", Offset = "0x53DC80", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700050C")]
	public bool IsZoomEnabled
	{
		[Address(RVA = "0x53EA70", Offset = "0x53DC70", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000EB9")]
		 get { } //Length: 5
		[Address(RVA = "0x53EA90", Offset = "0x53DC90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000EBA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000507")]
	public float OrthoSmoothZoomSensitivity
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAF")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB0")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000505")]
	public float OrthoStandardZoomSensitivity
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAB")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAC")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000509")]
	public float OrthoZoomSmoothValue
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB3")]
		 get { } //Length: 6
		[Address(RVA = "0x53EAA0", Offset = "0x53DCA0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000EB4")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000508")]
	public float PerspSmoothZoomSensitivity
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB1")]
		 get { } //Length: 6
		[Address(RVA = "0x53EAB0", Offset = "0x53DCB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000EB2")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000506")]
	public float PerspStandardZoomSensitivity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAD")]
		 get { } //Length: 6
		[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAE")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700050A")]
	public float PerspZoomSmoothValue
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EB5")]
		 get { } //Length: 6
		[Address(RVA = "0x53EAC0", Offset = "0x53DCC0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000EB6")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000504")]
	public CameraZoomMode ZoomMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA9")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EAA")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x53E9D0", Offset = "0x53DBD0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EBD")]
	public CameraZoomSettings() { }

	[Address(RVA = "0x53EA60", Offset = "0x53DC60", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB7")]
	public bool get_InvertZoomAxis() { }

	[Address(RVA = "0x53EA70", Offset = "0x53DC70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EB9")]
	public bool get_IsZoomEnabled() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAF")]
	public float get_OrthoSmoothZoomSensitivity() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAB")]
	public float get_OrthoStandardZoomSensitivity() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB3")]
	public float get_OrthoZoomSmoothValue() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB1")]
	public float get_PerspSmoothZoomSensitivity() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAD")]
	public float get_PerspStandardZoomSensitivity() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB5")]
	public float get_PerspZoomSmoothValue() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA9")]
	public CameraZoomMode get_ZoomMode() { }

	[Address(RVA = "0x53E910", Offset = "0x53DB10", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EBC")]
	public float GetZoomSensitivity(Camera camera) { }

	[Address(RVA = "0x53E990", Offset = "0x53DB90", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EBB")]
	public float GetZoomSmoothValue(Camera camera) { }

	[Address(RVA = "0x53EA80", Offset = "0x53DC80", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB8")]
	public void set_InvertZoomAxis(bool value) { }

	[Address(RVA = "0x53EA90", Offset = "0x53DC90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EBA")]
	public void set_IsZoomEnabled(bool value) { }

	[Address(RVA = "0x53B9B0", Offset = "0x53ABB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB0")]
	public void set_OrthoSmoothZoomSensitivity(float value) { }

	[Address(RVA = "0x53B9C0", Offset = "0x53ABC0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAC")]
	public void set_OrthoStandardZoomSensitivity(float value) { }

	[Address(RVA = "0x53EAA0", Offset = "0x53DCA0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EB4")]
	public void set_OrthoZoomSmoothValue(float value) { }

	[Address(RVA = "0x53EAB0", Offset = "0x53DCB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EB2")]
	public void set_PerspSmoothZoomSensitivity(float value) { }

	[Address(RVA = "0x53B9A0", Offset = "0x53ABA0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAE")]
	public void set_PerspStandardZoomSensitivity(float value) { }

	[Address(RVA = "0x53EAC0", Offset = "0x53DCC0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EB6")]
	public void set_PerspZoomSmoothValue(float value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAA")]
	public void set_ZoomMode(CameraZoomMode value) { }

}

